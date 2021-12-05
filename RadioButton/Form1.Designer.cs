namespace RadioButton
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
            this.rbSiyah = new System.Windows.Forms.RadioButton();
            this.rbGri = new System.Windows.Forms.RadioButton();
            this.rbBeyaz = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSiyah
            // 
            this.rbSiyah.AutoSize = true;
            this.rbSiyah.Location = new System.Drawing.Point(12, 12);
            this.rbSiyah.Name = "rbSiyah";
            this.rbSiyah.Size = new System.Drawing.Size(53, 19);
            this.rbSiyah.TabIndex = 0;
            this.rbSiyah.TabStop = true;
            this.rbSiyah.Text = "Siyah";
            this.rbSiyah.UseVisualStyleBackColor = true;
            // 
            // rbGri
            // 
            this.rbGri.AutoSize = true;
            this.rbGri.Location = new System.Drawing.Point(12, 48);
            this.rbGri.Name = "rbGri";
            this.rbGri.Size = new System.Drawing.Size(40, 19);
            this.rbGri.TabIndex = 1;
            this.rbGri.TabStop = true;
            this.rbGri.Text = "Gri";
            this.rbGri.UseVisualStyleBackColor = true;
            // 
            // rbBeyaz
            // 
            this.rbBeyaz.AutoSize = true;
            this.rbBeyaz.Location = new System.Drawing.Point(12, 88);
            this.rbBeyaz.Name = "rbBeyaz";
            this.rbBeyaz.Size = new System.Drawing.Size(55, 19);
            this.rbBeyaz.TabIndex = 2;
            this.rbBeyaz.TabStop = true;
            this.rbBeyaz.Text = "Beyaz";
            this.rbBeyaz.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbBeyaz);
            this.Controls.Add(this.rbGri);
            this.Controls.Add(this.rbSiyah);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSiyah;
        private System.Windows.Forms.RadioButton rbGri;
        private System.Windows.Forms.RadioButton rbBeyaz;
        private Button button1;
    }
}