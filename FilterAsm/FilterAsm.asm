; rcx/xmm0 - pixels
; rdx/xmm1 - red multiplier array
; r8/xmm2 - green multiplier array
; r9/xmm3 - blue multiplier array
; r10 - pixel array start index
; r11 - pixel array end index/loop counter

.code
filter proc
	movdqu		xmm1, oword ptr[rdx]		; move red multiplier array to xmm1
	movdqu		xmm2, oword ptr[r8]			; move green multiplier array to xmm2
	movdqu		xmm3, oword ptr[r9]			; move blue multiplier array to xmm3
	
	mov			ebx, dword ptr[rbp + 48]	; move start index from stack (cannot move to r10 directly because of size mismatch)
	mov			r10, rbx					; move start index to r10
	mov			ebx, dword ptr[rbp + 56]	; move end index from stack (cannot move to r10 directly because of size mismatch)
	mov			r11, rbx					; move end index to r11	

	sub			r11, r10					; calculate loop counter
	shr			r11, 2						; divide counter by 4 (4 values per pixel)

	mov			rax, 4h						; prepare multiplying by 4
	mul			r10							; multiply start index by 4 (pixel size in bytes) 
	add			rcx, rax					; add result to pixel offset

											; prepare 4 255 values in xmm7
	mov			rax, 437F0000h				; prepare value in rax
	movq		xmm7, rax					; move to lowest dword of xmm7
	movlhps		xmm7, xmm7					; move lower half of xmm4 to upper half
	movsldup	xmm7, xmm7					; duplicate even index dwords to all indexes

	xorps		xmm8, xmm8					; put zero in xmm8

filterLoop:
	cmp			r11, 0h						; if counter reaches zero, exit loop
	je			exitLoop					
	
	movdqu		xmm0, oword ptr[rcx]		; move pixel values (ABGR) of one pixel to xmm0
	movaps		xmm4, xmm0					; save pixel to be restored later
	mulps		xmm0, xmm1					; multiply pixel by red multiplier array
	movaps		xmm5, xmm0					; save result in xmm5
	movaps		xmm0, xmm4					; restore pixel values in xmm0
	mulps		xmm0, xmm2					; multiply pixel by green multiplier array
	movaps		xmm6, xmm0					; save result in xmm6
	movaps		xmm0, xmm4					; restore pixel values in xmm0
	mulps		xmm0, xmm3					; multiply pixel by blue multiplier array
											; xmm5 - pixel*red, xmm6 - pixel*green, xmm0 - pixel*blue

											; sum values in the sub registers

											; blue
	movshdup    xmm4, xmm0					; moves odd index dwords from xmm0 and duplicates them into xmm4
    addps       xmm0, xmm4					; sums xmm0 and xmm4
    movhlps     xmm4, xmm0					; moves values from high quadword of xmm0 to low quadword of xmm4
    addps       xmm0, xmm4					; sums xmm0 and xmm4, the total sum is stored in the lowest dword of xmm0

											; green
	movshdup    xmm4, xmm6					; moves odd index dwords from xmm6 and duplicates them into xmm4
    addps       xmm6, xmm4					; sums xmm6 and xmm4
    movhlps     xmm4, xmm6					; moves values from high quadword of xmm6 to low quadword of xmm4
    addps       xmm6, xmm4					; sums xmm6 and xmm4, the total sum is stored in the lowest dword of xmm0

											; red
	movshdup    xmm4, xmm5					; moves odd index dwords from xmm5 and duplicates them into xmm4
    addps       xmm5, xmm4					; sums xmm5 and xmm4
    movhlps     xmm4, xmm5					; moves values from high quadword of xmm5 to low quadword of xmm4
    addps       xmm5, xmm4					; sums xmm5 and xmm4, the total sum is stored in the lowest dword of xmm0

	maxps		xmm0, xmm8					; make sure no values are below 0
	maxps		xmm5, xmm8
	maxps		xmm6, xmm8

	minps		xmm0, xmm7					; make sure no values exceed 255
	minps		xmm5, xmm7
	minps		xmm6, xmm7

	pextrd dword ptr [rcx+0], xmm0, 0		; save blue value in the pixel table
	pextrd dword ptr [rcx+4], xmm6, 0		; save green value in the pixel table
	pextrd dword ptr [rcx+8], xmm5, 0		; save red value in the pixel table
	
	add			rcx, 16						; move pointer one pixel forward, that means 16 bytes
	sub			r11, 1						; decrement loop counter
	jmp			filterLoop					; go back to the start of the loop

exitLoop:
    ret
filter endp
end