namespace StudentRecordSystem
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_title = new System.Windows.Forms.TextBox();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schoolpic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.login_title);
            this.panel1.Controls.Add(this.logopic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 55);
            this.panel1.TabIndex = 0;
            // 
            // login_title
            // 
            this.login_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.login_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_title.Location = new System.Drawing.Point(58, 0);
            this.login_title.Multiline = true;
            this.login_title.Name = "login_title";
            this.login_title.ReadOnly = true;
            this.login_title.Size = new System.Drawing.Size(549, 55);
            this.login_title.TabIndex = 1;
            this.login_title.Text = "CAPALONGA INSTITUTE INCORPORATED\r\nSTUDENT RECORD SYSTEM";
            this.login_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_title.TextChanged += new System.EventHandler(this.login_title_TextChanged);
            // 
            // logopic
            // 
            this.logopic.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.logopic.Dock = System.Windows.Forms.DockStyle.Left;
            this.logopic.Image = global::StudentRecordSystem.Properties.Resources.c_i_logo;
            this.logopic.Location = new System.Drawing.Point(0, 0);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(58, 55);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopic.TabIndex = 0;
            this.logopic.TabStop = false;
            this.logopic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 453);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // schoolpic
            // 
            this.schoolpic.BackColor = System.Drawing.Color.Transparent;
            this.schoolpic.BackgroundImage = global::StudentRecordSystem.Properties.Resources.schoolpic;
            this.schoolpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schoolpic.Image = global::StudentRecordSystem.Properties.Resources.schoolpic;
            this.schoolpic.Location = new System.Drawing.Point(0, 55);
            this.schoolpic.Name = "schoolpic";
            this.schoolpic.Size = new System.Drawing.Size(607, 453);
            this.schoolpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.schoolpic.TabIndex = 2;
            this.schoolpic.TabStop = false;
            this.schoolpic.Click += new System.EventHandler(this.schoolpic_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 508);
            this.Controls.Add(this.schoolpic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.TextBox login_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox schoolpic;
    }
}