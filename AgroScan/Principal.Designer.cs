using System.Windows.Forms;

namespace AgroScan
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.ProgressBar progressBar1;
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageUpload = new System.Windows.Forms.Button();
            this.bordeRich = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bordeRich.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btncerrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 89);
            this.panel2.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.MediumAquamarine;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Candara", 12F);
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(455, 34);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(65, 19);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Historial";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.MediumAquamarine;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumAquamarine;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Candara", 12F);
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(543, 34);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 19);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar sesión";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.MediumAquamarine;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimize.Location = new System.Drawing.Point(649, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Candara", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(337, 14);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(57, 54);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncerrar.BackgroundImage")));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Location = new System.Drawing.Point(680, 2);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(30, 27);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 14;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(32, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "AGROESCAN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(progressBar1);
            this.panel1.Controls.Add(this.ImageUpload);
            this.panel1.Controls.Add(this.bordeRich);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 350);
            this.panel1.TabIndex = 14;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = System.Drawing.Color.MediumAquamarine;
            progressBar1.ForeColor = System.Drawing.Color.Green;
            progressBar1.Location = new System.Drawing.Point(274, 117);
            progressBar1.Margin = new System.Windows.Forms.Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(139, 19);
            progressBar1.Step = 0;
            progressBar1.TabIndex = 17;
            progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // ImageUpload
            // 
            this.ImageUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.ImageUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.ImageUpload.FlatAppearance.BorderSize = 5;
            this.ImageUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageUpload.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.ImageUpload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ImageUpload.Location = new System.Drawing.Point(70, 36);
            this.ImageUpload.Margin = new System.Windows.Forms.Padding(2);
            this.ImageUpload.Name = "ImageUpload";
            this.ImageUpload.Size = new System.Drawing.Size(189, 179);
            this.ImageUpload.TabIndex = 16;
            this.ImageUpload.Text = "Subir imagen";
            this.ImageUpload.UseVisualStyleBackColor = false;
            this.ImageUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // bordeRich
            // 
            this.bordeRich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.bordeRich.Controls.Add(this.richTextBox1);
            this.bordeRich.Location = new System.Drawing.Point(431, 46);
            this.bordeRich.Margin = new System.Windows.Forms.Padding(2);
            this.bordeRich.Name = "bordeRich";
            this.bordeRich.Padding = new System.Windows.Forms.Padding(4);
            this.bordeRich.Size = new System.Drawing.Size(189, 179);
            this.bordeRich.TabIndex = 0;
            this.bordeRich.Paint += new System.Windows.Forms.PaintEventHandler(this.bordeRich_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(181, 171);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bordeRich.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button ImageUpload;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel bordeRich;
    }
}