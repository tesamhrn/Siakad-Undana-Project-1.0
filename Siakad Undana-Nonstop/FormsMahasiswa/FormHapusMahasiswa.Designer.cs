namespace Siakad_Undana_Nonstop.FormsMahasiswa
{
    partial class FormHapusMahasiswa
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
        private  void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxNIM);
            this.panel2.Controls.Add(this.label2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Masukkan NIM untuk menghapus : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Masukkan NIM untuk Menghapus data";
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(292, 169);
            this.textBoxNIM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(193, 22);
            this.textBoxNIM.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "NIM";
            // 
            // FormHapusMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormHapusMahasiswa";
            this.Text = "FormHapusMahasiswa";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox textBoxNIM;
        protected System.Windows.Forms.Label label3;
    }
}