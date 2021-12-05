namespace ComboBoxResimSec
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
            this.cmbResim = new System.Windows.Forms.ComboBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbResim
            // 
            this.cmbResim.BackColor = System.Drawing.Color.DimGray;
            this.cmbResim.FormattingEnabled = true;
            this.cmbResim.Location = new System.Drawing.Point(89, 27);
            this.cmbResim.Name = "cmbResim";
            this.cmbResim.Size = new System.Drawing.Size(409, 23);
            this.cmbResim.TabIndex = 0;
            this.cmbResim.SelectedIndexChanged += new System.EventHandler(this.cmbResim_SelectedIndexChanged);
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.Color.DimGray;
            this.pbResim.Location = new System.Drawing.Point(89, 65);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(409, 352);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 1;
            this.pbResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(615, 452);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cmbResim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbResim;
        private PictureBox pbResim;
    }
}