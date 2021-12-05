namespace SecilenDosyayiSecilenKlasoreKopyalama
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
            this.btnKopyala = new System.Windows.Forms.Button();
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.txtHedef = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnKaynak = new System.Windows.Forms.Button();
            this.btnHedef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKopyala
            // 
            this.btnKopyala.BackColor = System.Drawing.Color.Black;
            this.btnKopyala.ForeColor = System.Drawing.Color.White;
            this.btnKopyala.Location = new System.Drawing.Point(24, 125);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(752, 28);
            this.btnKopyala.TabIndex = 0;
            this.btnKopyala.Text = "Dosyayı Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = false;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // txtKaynak
            // 
            this.txtKaynak.BackColor = System.Drawing.Color.Silver;
            this.txtKaynak.Location = new System.Drawing.Point(104, 47);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.Size = new System.Drawing.Size(672, 23);
            this.txtKaynak.TabIndex = 3;
            // 
            // txtHedef
            // 
            this.txtHedef.BackColor = System.Drawing.Color.Silver;
            this.txtHedef.Location = new System.Drawing.Point(104, 76);
            this.txtHedef.Name = "txtHedef";
            this.txtHedef.Size = new System.Drawing.Size(672, 23);
            this.txtHedef.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKaynak
            // 
            this.btnKaynak.BackColor = System.Drawing.Color.Black;
            this.btnKaynak.ForeColor = System.Drawing.Color.White;
            this.btnKaynak.Location = new System.Drawing.Point(24, 47);
            this.btnKaynak.Name = "btnKaynak";
            this.btnKaynak.Size = new System.Drawing.Size(75, 23);
            this.btnKaynak.TabIndex = 5;
            this.btnKaynak.Text = "Kaynak";
            this.btnKaynak.UseVisualStyleBackColor = false;
            this.btnKaynak.Click += new System.EventHandler(this.btnKaynak_Click);
            // 
            // btnHedef
            // 
            this.btnHedef.BackColor = System.Drawing.Color.Black;
            this.btnHedef.ForeColor = System.Drawing.Color.White;
            this.btnHedef.Location = new System.Drawing.Point(24, 76);
            this.btnHedef.Name = "btnHedef";
            this.btnHedef.Size = new System.Drawing.Size(75, 23);
            this.btnHedef.TabIndex = 6;
            this.btnHedef.Text = "Hedef";
            this.btnHedef.UseVisualStyleBackColor = false;
            this.btnHedef.Click += new System.EventHandler(this.btnHedef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.btnHedef);
            this.Controls.Add(this.btnKaynak);
            this.Controls.Add(this.txtHedef);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.btnKopyala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKopyala;
        private TextBox txtKaynak;
        private TextBox txtHedef;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnKaynak;
        private Button btnHedef;
    }
}