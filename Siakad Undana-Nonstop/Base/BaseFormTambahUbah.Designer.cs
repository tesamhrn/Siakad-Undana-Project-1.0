namespace Siakad_Undana_Nonstop.Base
{
    partial class BaseFormTambahUbah
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormTambahUbah));
            this.LabelJudulUbahtambah = new System.Windows.Forms.Label();
            this.TitleBars = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitleBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelJudulUbahtambah
            // 
            this.LabelJudulUbahtambah.BackColor = System.Drawing.Color.Transparent;
            this.LabelJudulUbahtambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJudulUbahtambah.Location = new System.Drawing.Point(172, -2);
            this.LabelJudulUbahtambah.Name = "LabelJudulUbahtambah";
            this.LabelJudulUbahtambah.Size = new System.Drawing.Size(683, 48);
            this.LabelJudulUbahtambah.TabIndex = 15;
            this.LabelJudulUbahtambah.Text = "Judul";
            this.LabelJudulUbahtambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleBars
            // 
            this.TitleBars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleBars.Controls.Add(this.Clock);
            this.TitleBars.Controls.Add(this.pictureBox1);
            this.TitleBars.Controls.Add(this.BtnMin);
            this.TitleBars.Controls.Add(this.BtnMax);
            this.TitleBars.Controls.Add(this.label4);
            this.TitleBars.Controls.Add(this.BtnClose);
            this.TitleBars.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBars.Location = new System.Drawing.Point(0, 0);
            this.TitleBars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleBars.Name = "TitleBars";
            this.TitleBars.Size = new System.Drawing.Size(1067, 37);
            this.TitleBars.TabIndex = 17;
            this.TitleBars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBars_MouseDown);
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.Transparent;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Clock.Location = new System.Drawing.Point(472, 9);
            this.Clock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(58, 18);
            this.Clock.TabIndex = 18;
            this.Clock.Text = "xx:xx:xx";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMin.BackgroundImage")));
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(935, 2);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(37, 32);
            this.BtnMin.TabIndex = 9;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMax.BackgroundImage")));
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Location = new System.Drawing.Point(980, 2);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(37, 32);
            this.BtnMax.TabIndex = 7;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Siakad Undana";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(1025, 2);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(37, 32);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBar.BackgroundImage")));
            this.TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBar.Controls.Add(this.LabelJudulUbahtambah);
            this.TitleBar.Location = new System.Drawing.Point(0, 37);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1067, 41);
            this.TitleBar.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 82);
            this.panel1.TabIndex = 19;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.NavajoWhite;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(935, 23);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 37);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.NavajoWhite;
            this.buttonSimpan.Image = ((System.Drawing.Image)(resources.GetObject("buttonSimpan.Image")));
            this.buttonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSimpan.Location = new System.Drawing.Point(827, 23);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(103, 37);
            this.buttonSimpan.TabIndex = 0;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(208, 127);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 311);
            this.panel2.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BaseFormTambahUbah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBars);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaseFormTambahUbah";
            this.Text = "BasesFormTambahUbah";
            this.TitleBars.ResumeLayout(false);
            this.TitleBars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label LabelJudulUbahtambah;
        private System.Windows.Forms.Panel TitleBars;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel TitleBar;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.Button buttonSimpan;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}