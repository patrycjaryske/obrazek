namespace obrazek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Load = new Button();
            pictureBox1 = new PictureBox();
            OnlyGreen = new Button();
            Rotate = new Button();
            radioButton90 = new RadioButton();
            radioButton180 = new RadioButton();
            radioButton270 = new RadioButton();
            InvertColors = new Button();
            Upsidedown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Load
            // 
            Load.Location = new Point(123, 387);
            Load.Name = "Load";
            Load.Size = new Size(75, 23);
            Load.TabIndex = 0;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(321, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 340);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Rotate
            // 
            Rotate.Location = new Point(123, 149);
            Rotate.Name = "Rotate";
            Rotate.Size = new Size(75, 23);
            Rotate.TabIndex = 2;
            Rotate.Text = "Rotate";
            Rotate.UseVisualStyleBackColor = true;
            Rotate.Click += Rotate_Click;
            // 
            // radioButton90
            // 
            radioButton90.AutoSize = true;
            radioButton90.Location = new Point(126, 56);
            radioButton90.Name = "radioButton90";
            radioButton90.Size = new Size(37, 19);
            radioButton90.TabIndex = 3;
            radioButton90.TabStop = true;
            radioButton90.Text = "90";
            radioButton90.UseVisualStyleBackColor = true;
            // 
            // radioButton180
            // 
            radioButton180.AutoSize = true;
            radioButton180.Location = new Point(126, 81);
            radioButton180.Name = "radioButton180";
            radioButton180.Size = new Size(43, 19);
            radioButton180.TabIndex = 4;
            radioButton180.TabStop = true;
            radioButton180.Text = "180";
            radioButton180.UseVisualStyleBackColor = true;
            // 
            // radioButton270
            // 
            radioButton270.AutoSize = true;
            radioButton270.Location = new Point(126, 106);
            radioButton270.Name = "radioButton270";
            radioButton270.Size = new Size(43, 19);
            radioButton270.TabIndex = 5;
            radioButton270.TabStop = true;
            radioButton270.Text = "270";
            radioButton270.UseVisualStyleBackColor = true;
            // 
            // InvertColors
            // 
            InvertColors.Location = new Point(123, 178);
            InvertColors.Name = "InvertColors";
            InvertColors.Size = new Size(75, 38);
            InvertColors.TabIndex = 6;
            InvertColors.Text = "Invert Colors";
            InvertColors.UseVisualStyleBackColor = true;
            InvertColors.Click += InvertColors_Click;
            // 
            // Upsidedown
            // 
            Upsidedown.Location = new Point(123, 222);
            Upsidedown.Name = "Upsidedown";
            Upsidedown.Size = new Size(75, 41);
            Upsidedown.TabIndex = 7;
            Upsidedown.Text = "Upside Down";
            Upsidedown.UseVisualStyleBackColor = true;
            Upsidedown.Click += Upsidedown_Click;
            // 
            // OnlyGreen
            // 
            OnlyGreen.Location = new Point(123, 344);
            OnlyGreen.Name = "OnlyGreen";
            OnlyGreen.Size = new Size(75, 23);
            OnlyGreen.TabIndex = 2;
            OnlyGreen.Text = "Only Green";
            OnlyGreen.UseVisualStyleBackColor = true;
            OnlyGreen.Click += OnlyGreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Upsidedown);
            Controls.Add(InvertColors);
            Controls.Add(radioButton270);
            Controls.Add(radioButton180);
            Controls.Add(radioButton90);
            Controls.Add(Rotate);
            Controls.Add(OnlyGreen);
            Controls.Add(pictureBox1);
            Controls.Add(Load);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Load;
        private PictureBox pictureBox1;
        private Button Rotate;
        private RadioButton radioButton90;
        private RadioButton radioButton180;
        private RadioButton radioButton270;
        private Button InvertColors;
        private Button Upsidedown;
        private Button OnlyGreen;
    }
}
