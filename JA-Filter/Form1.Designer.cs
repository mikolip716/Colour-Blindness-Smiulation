namespace JA_Filter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBefore = new System.Windows.Forms.PictureBox();
            this.threadSlider = new System.Windows.Forms.TrackBar();
            this.threadGroupBox = new System.Windows.Forms.GroupBox();
            this.labelThread = new System.Windows.Forms.Label();
            this.LibrarygroupBox = new System.Windows.Forms.GroupBox();
            this.asmRadioButton = new System.Windows.Forms.RadioButton();
            this.cSharpRadioButton = new System.Windows.Forms.RadioButton();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.TritRadioButton = new System.Windows.Forms.RadioButton();
            this.DeuterRadioButton = new System.Windows.Forms.RadioButton();
            this.ProtanRadioButton = new System.Windows.Forms.RadioButton();
            this.strGroupBox = new System.Windows.Forms.GroupBox();
            this.strLabel = new System.Windows.Forms.Label();
            this.strTrackBar = new System.Windows.Forms.TrackBar();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxPerfTest = new System.Windows.Forms.CheckBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.imageAfter = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.loadImgButton = new System.Windows.Forms.Button();
            this.saveImgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadSlider)).BeginInit();
            this.threadGroupBox.SuspendLayout();
            this.LibrarygroupBox.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            this.strGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strTrackBar)).BeginInit();
            this.timeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBefore
            // 
            this.imageBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imageBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBefore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageBefore.Location = new System.Drawing.Point(39, 14);
            this.imageBefore.Margin = new System.Windows.Forms.Padding(5);
            this.imageBefore.Name = "imageBefore";
            this.imageBefore.Size = new System.Drawing.Size(700, 525);
            this.imageBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBefore.TabIndex = 12;
            this.imageBefore.TabStop = false;
            // 
            // threadSlider
            // 
            this.threadSlider.LargeChange = 1;
            this.threadSlider.Location = new System.Drawing.Point(57, 42);
            this.threadSlider.Maximum = 64;
            this.threadSlider.Minimum = 1;
            this.threadSlider.Name = "threadSlider";
            this.threadSlider.Size = new System.Drawing.Size(1405, 56);
            this.threadSlider.TabIndex = 14;
            this.threadSlider.Value = 1;
            this.threadSlider.Scroll += new System.EventHandler(this.threadSlider_Scroll);
            // 
            // threadGroupBox
            // 
            this.threadGroupBox.Controls.Add(this.labelThread);
            this.threadGroupBox.Controls.Add(this.threadSlider);
            this.threadGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.threadGroupBox.Location = new System.Drawing.Point(39, 547);
            this.threadGroupBox.Name = "threadGroupBox";
            this.threadGroupBox.Size = new System.Drawing.Size(1478, 100);
            this.threadGroupBox.TabIndex = 15;
            this.threadGroupBox.TabStop = false;
            this.threadGroupBox.Text = "Thread Amount";
            // 
            // labelThread
            // 
            this.labelThread.AutoSize = true;
            this.labelThread.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThread.Location = new System.Drawing.Point(26, 42);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(25, 26);
            this.labelThread.TabIndex = 15;
            this.labelThread.Text = "1";
            // 
            // LibrarygroupBox
            // 
            this.LibrarygroupBox.Controls.Add(this.asmRadioButton);
            this.LibrarygroupBox.Controls.Add(this.cSharpRadioButton);
            this.LibrarygroupBox.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibrarygroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.LibrarygroupBox.Location = new System.Drawing.Point(37, 651);
            this.LibrarygroupBox.Name = "LibrarygroupBox";
            this.LibrarygroupBox.Size = new System.Drawing.Size(164, 190);
            this.LibrarygroupBox.TabIndex = 16;
            this.LibrarygroupBox.TabStop = false;
            this.LibrarygroupBox.Text = "DLL Library";
            // 
            // asmRadioButton
            // 
            this.asmRadioButton.AutoSize = true;
            this.asmRadioButton.Location = new System.Drawing.Point(22, 119);
            this.asmRadioButton.Name = "asmRadioButton";
            this.asmRadioButton.Size = new System.Drawing.Size(126, 30);
            this.asmRadioButton.TabIndex = 1;
            this.asmRadioButton.TabStop = true;
            this.asmRadioButton.Text = "Assembly";
            this.asmRadioButton.UseVisualStyleBackColor = true;
            this.asmRadioButton.CheckedChanged += new System.EventHandler(this.asmRadioButton_CheckedChanged);
            // 
            // cSharpRadioButton
            // 
            this.cSharpRadioButton.AutoSize = true;
            this.cSharpRadioButton.Location = new System.Drawing.Point(22, 54);
            this.cSharpRadioButton.Name = "cSharpRadioButton";
            this.cSharpRadioButton.Size = new System.Drawing.Size(66, 30);
            this.cSharpRadioButton.TabIndex = 0;
            this.cSharpRadioButton.TabStop = true;
            this.cSharpRadioButton.Text = "C#";
            this.cSharpRadioButton.UseVisualStyleBackColor = true;
            this.cSharpRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.TritRadioButton);
            this.typeGroupBox.Controls.Add(this.DeuterRadioButton);
            this.typeGroupBox.Controls.Add(this.ProtanRadioButton);
            this.typeGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.typeGroupBox.Location = new System.Drawing.Point(207, 651);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(291, 190);
            this.typeGroupBox.TabIndex = 17;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Colour Blindness Type";
            // 
            // TritRadioButton
            // 
            this.TritRadioButton.AutoSize = true;
            this.TritRadioButton.Location = new System.Drawing.Point(18, 141);
            this.TritRadioButton.Name = "TritRadioButton";
            this.TritRadioButton.Size = new System.Drawing.Size(157, 30);
            this.TritRadioButton.TabIndex = 2;
            this.TritRadioButton.TabStop = true;
            this.TritRadioButton.Text = "Tritanomaly";
            this.TritRadioButton.UseVisualStyleBackColor = true;
            this.TritRadioButton.CheckedChanged += new System.EventHandler(this.TritRadioButton_CheckedChanged);
            // 
            // DeuterRadioButton
            // 
            this.DeuterRadioButton.AutoSize = true;
            this.DeuterRadioButton.Location = new System.Drawing.Point(18, 92);
            this.DeuterRadioButton.Name = "DeuterRadioButton";
            this.DeuterRadioButton.Size = new System.Drawing.Size(193, 30);
            this.DeuterRadioButton.TabIndex = 1;
            this.DeuterRadioButton.TabStop = true;
            this.DeuterRadioButton.Text = "Deuteranomaly";
            this.DeuterRadioButton.UseVisualStyleBackColor = true;
            this.DeuterRadioButton.CheckedChanged += new System.EventHandler(this.DeuterRadioButton_CheckedChanged);
            // 
            // ProtanRadioButton
            // 
            this.ProtanRadioButton.AutoSize = true;
            this.ProtanRadioButton.Location = new System.Drawing.Point(18, 41);
            this.ProtanRadioButton.Name = "ProtanRadioButton";
            this.ProtanRadioButton.Size = new System.Drawing.Size(164, 30);
            this.ProtanRadioButton.TabIndex = 0;
            this.ProtanRadioButton.TabStop = true;
            this.ProtanRadioButton.Text = "Protanomaly";
            this.ProtanRadioButton.UseVisualStyleBackColor = true;
            this.ProtanRadioButton.CheckedChanged += new System.EventHandler(this.ProtanRadioButton_CheckedChanged);
            // 
            // strGroupBox
            // 
            this.strGroupBox.Controls.Add(this.strLabel);
            this.strGroupBox.Controls.Add(this.strTrackBar);
            this.strGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.strGroupBox.Location = new System.Drawing.Point(504, 651);
            this.strGroupBox.Name = "strGroupBox";
            this.strGroupBox.Size = new System.Drawing.Size(567, 96);
            this.strGroupBox.TabIndex = 18;
            this.strGroupBox.TabStop = false;
            this.strGroupBox.Text = "Effect Strength";
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(27, 41);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(25, 26);
            this.strLabel.TabIndex = 1;
            this.strLabel.Text = "1";
            // 
            // strTrackBar
            // 
            this.strTrackBar.LargeChange = 1;
            this.strTrackBar.Location = new System.Drawing.Point(58, 37);
            this.strTrackBar.Minimum = 1;
            this.strTrackBar.Name = "strTrackBar";
            this.strTrackBar.Size = new System.Drawing.Size(496, 56);
            this.strTrackBar.TabIndex = 0;
            this.strTrackBar.Value = 1;
            this.strTrackBar.Scroll += new System.EventHandler(this.strTrackBar_Scroll);
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.checkBoxPerfTest);
            this.timeGroupBox.Controls.Add(this.timeLabel);
            this.timeGroupBox.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.timeGroupBox.Location = new System.Drawing.Point(504, 750);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(567, 91);
            this.timeGroupBox.TabIndex = 19;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "Time Elapsed";
            // 
            // checkBoxPerfTest
            // 
            this.checkBoxPerfTest.AutoSize = true;
            this.checkBoxPerfTest.Location = new System.Drawing.Point(313, 38);
            this.checkBoxPerfTest.Name = "checkBoxPerfTest";
            this.checkBoxPerfTest.Size = new System.Drawing.Size(212, 30);
            this.checkBoxPerfTest.TabIndex = 1;
            this.checkBoxPerfTest.Text = "Performance Test";
            this.checkBoxPerfTest.UseVisualStyleBackColor = true;
            this.checkBoxPerfTest.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(27, 42);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 26);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "...";
            // 
            // imageAfter
            // 
            this.imageAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imageAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageAfter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageAfter.Location = new System.Drawing.Point(817, 14);
            this.imageAfter.Margin = new System.Windows.Forms.Padding(5);
            this.imageAfter.Name = "imageAfter";
            this.imageAfter.Size = new System.Drawing.Size(700, 525);
            this.imageAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageAfter.TabIndex = 13;
            this.imageAfter.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.startButton.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(1086, 730);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(431, 53);
            this.startButton.TabIndex = 21;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadImgButton
            // 
            this.loadImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.loadImgButton.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImgButton.ForeColor = System.Drawing.Color.White;
            this.loadImgButton.Location = new System.Drawing.Point(1086, 669);
            this.loadImgButton.Name = "loadImgButton";
            this.loadImgButton.Size = new System.Drawing.Size(431, 53);
            this.loadImgButton.TabIndex = 22;
            this.loadImgButton.Text = "Load Image";
            this.loadImgButton.UseVisualStyleBackColor = false;
            this.loadImgButton.Click += new System.EventHandler(this.loadImgButton_Click);
            // 
            // saveImgButton
            // 
            this.saveImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.saveImgButton.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImgButton.ForeColor = System.Drawing.Color.White;
            this.saveImgButton.Location = new System.Drawing.Point(1086, 788);
            this.saveImgButton.Name = "saveImgButton";
            this.saveImgButton.Size = new System.Drawing.Size(431, 53);
            this.saveImgButton.TabIndex = 23;
            this.saveImgButton.Text = "Save Image";
            this.saveImgButton.UseVisualStyleBackColor = false;
            this.saveImgButton.Click += new System.EventHandler(this.saveImgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1582, 864);
            this.Controls.Add(this.saveImgButton);
            this.Controls.Add(this.loadImgButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.strGroupBox);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.LibrarygroupBox);
            this.Controls.Add(this.threadGroupBox);
            this.Controls.Add(this.imageAfter);
            this.Controls.Add(this.imageBefore);
            this.Name = "Form1";
            this.Text = "Colour Blindness Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadSlider)).EndInit();
            this.threadGroupBox.ResumeLayout(false);
            this.threadGroupBox.PerformLayout();
            this.LibrarygroupBox.ResumeLayout(false);
            this.LibrarygroupBox.PerformLayout();
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.strGroupBox.ResumeLayout(false);
            this.strGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strTrackBar)).EndInit();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAfter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBefore;
        private System.Windows.Forms.TrackBar threadSlider;
        private System.Windows.Forms.GroupBox threadGroupBox;
        private System.Windows.Forms.Label labelThread;
        private System.Windows.Forms.GroupBox LibrarygroupBox;
        private System.Windows.Forms.RadioButton asmRadioButton;
        private System.Windows.Forms.RadioButton cSharpRadioButton;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton TritRadioButton;
        private System.Windows.Forms.RadioButton DeuterRadioButton;
        private System.Windows.Forms.RadioButton ProtanRadioButton;
        private System.Windows.Forms.GroupBox strGroupBox;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.TrackBar strTrackBar;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox imageAfter;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadImgButton;
        private System.Windows.Forms.Button saveImgButton;
        private System.Windows.Forms.CheckBox checkBoxPerfTest;
    }
}

