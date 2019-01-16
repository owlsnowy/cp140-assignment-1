namespace Assignment_1_Colour_Changer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbRed1 = new System.Windows.Forms.RadioButton();
            this.rbBlue1 = new System.Windows.Forms.RadioButton();
            this.rbYellow1 = new System.Windows.Forms.RadioButton();
            this.rbRed2 = new System.Windows.Forms.RadioButton();
            this.rbBlue2 = new System.Windows.Forms.RadioButton();
            this.rbYellow2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYellow1);
            this.groupBox1.Controls.Add(this.rbBlue1);
            this.groupBox1.Controls.Add(this.rbRed1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select First Colour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbYellow2);
            this.groupBox2.Controls.Add(this.rbBlue2);
            this.groupBox2.Controls.Add(this.rbRed2);
            this.groupBox2.Location = new System.Drawing.Point(174, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Second Colour";
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(13, 163);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(140, 88);
            this.btnMix.TabIndex = 2;
            this.btnMix.Text = "Mix";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 88);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbRed1
            // 
            this.rbRed1.AutoSize = true;
            this.rbRed1.Location = new System.Drawing.Point(7, 20);
            this.rbRed1.Name = "rbRed1";
            this.rbRed1.Size = new System.Drawing.Size(45, 17);
            this.rbRed1.TabIndex = 0;
            this.rbRed1.Text = "Red";
            this.rbRed1.UseVisualStyleBackColor = true;
            // 
            // rbBlue1
            // 
            this.rbBlue1.AutoSize = true;
            this.rbBlue1.Location = new System.Drawing.Point(7, 60);
            this.rbBlue1.Name = "rbBlue1";
            this.rbBlue1.Size = new System.Drawing.Size(46, 17);
            this.rbBlue1.TabIndex = 1;
            this.rbBlue1.TabStop = true;
            this.rbBlue1.Text = "Blue";
            this.rbBlue1.UseVisualStyleBackColor = true;
            // 
            // rbYellow1
            // 
            this.rbYellow1.AutoSize = true;
            this.rbYellow1.Location = new System.Drawing.Point(7, 97);
            this.rbYellow1.Name = "rbYellow1";
            this.rbYellow1.Size = new System.Drawing.Size(56, 17);
            this.rbYellow1.TabIndex = 2;
            this.rbYellow1.TabStop = true;
            this.rbYellow1.Text = "Yellow";
            this.rbYellow1.UseVisualStyleBackColor = true;
            // 
            // rbRed2
            // 
            this.rbRed2.AutoSize = true;
            this.rbRed2.Location = new System.Drawing.Point(7, 20);
            this.rbRed2.Name = "rbRed2";
            this.rbRed2.Size = new System.Drawing.Size(45, 17);
            this.rbRed2.TabIndex = 0;
            this.rbRed2.TabStop = true;
            this.rbRed2.Text = "Red";
            this.rbRed2.UseVisualStyleBackColor = true;
            // 
            // rbBlue2
            // 
            this.rbBlue2.AutoSize = true;
            this.rbBlue2.Location = new System.Drawing.Point(7, 60);
            this.rbBlue2.Name = "rbBlue2";
            this.rbBlue2.Size = new System.Drawing.Size(46, 17);
            this.rbBlue2.TabIndex = 1;
            this.rbBlue2.TabStop = true;
            this.rbBlue2.Text = "Blue";
            this.rbBlue2.UseVisualStyleBackColor = true;
            // 
            // rbYellow2
            // 
            this.rbYellow2.AutoSize = true;
            this.rbYellow2.Location = new System.Drawing.Point(7, 97);
            this.rbYellow2.Name = "rbYellow2";
            this.rbYellow2.Size = new System.Drawing.Size(56, 17);
            this.rbYellow2.TabIndex = 2;
            this.rbYellow2.TabStop = true;
            this.rbYellow2.Text = "Yellow";
            this.rbYellow2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 263);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbYellow1;
        private System.Windows.Forms.RadioButton rbBlue1;
        private System.Windows.Forms.RadioButton rbRed1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbYellow2;
        private System.Windows.Forms.RadioButton rbBlue2;
        private System.Windows.Forms.RadioButton rbRed2;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnExit;
    }
}

