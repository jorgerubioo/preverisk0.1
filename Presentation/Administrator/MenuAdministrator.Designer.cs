namespace Presentation.Administrator
{
    partial class MenuAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrator));
            this.paneladmin = new System.Windows.Forms.Panel();
            this.btnPerfilUser = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2admin = new System.Windows.Forms.Panel();
            this.paneladmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneladmin
            // 
            this.paneladmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.paneladmin.Controls.Add(this.btnPerfilUser);
            this.paneladmin.Controls.Add(this.lblEmail);
            this.paneladmin.Controls.Add(this.lblposition);
            this.paneladmin.Controls.Add(this.lblname);
            this.paneladmin.Controls.Add(this.pictureBox4);
            this.paneladmin.Controls.Add(this.btnLogout);
            this.paneladmin.Controls.Add(this.shapeContainer1);
            this.paneladmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneladmin.Location = new System.Drawing.Point(0, 36);
            this.paneladmin.Name = "paneladmin";
            this.paneladmin.Size = new System.Drawing.Size(246, 565);
            this.paneladmin.TabIndex = 0;
            this.paneladmin.Paint += new System.Windows.Forms.PaintEventHandler(this.paneladmin_Paint);
            // 
            // btnPerfilUser
            // 
            this.btnPerfilUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnPerfilUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilUser.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfilUser.ForeColor = System.Drawing.Color.White;
            this.btnPerfilUser.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfilUser.Image")));
            this.btnPerfilUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilUser.Location = new System.Drawing.Point(0, 119);
            this.btnPerfilUser.Name = "btnPerfilUser";
            this.btnPerfilUser.Size = new System.Drawing.Size(243, 36);
            this.btnPerfilUser.TabIndex = 6;
            this.btnPerfilUser.Text = "Usuarios";
            this.btnPerfilUser.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(88, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.ForeColor = System.Drawing.Color.White;
            this.lblposition.Location = new System.Drawing.Point(88, 42);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(31, 16);
            this.lblposition.TabIndex = 3;
            this.lblposition.Text = "Rol:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(88, 20);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(59, 16);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nombre:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(180, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 46);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(246, 565);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 229;
            this.lineShape1.Y1 = 88;
            this.lineShape1.Y2 = 88;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(888, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(858, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2admin
            // 
            this.panel2admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.panel2admin.Controls.Add(this.pictureBox2);
            this.panel2admin.Controls.Add(this.pictureBox3);
            this.panel2admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2admin.Location = new System.Drawing.Point(0, 0);
            this.panel2admin.Name = "panel2admin";
            this.panel2admin.Size = new System.Drawing.Size(915, 36);
            this.panel2admin.TabIndex = 2;
            this.panel2admin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2admin_Paint);
            // 
            // MenuAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paneladmin);
            this.Controls.Add(this.panel2admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.paneladmin.ResumeLayout(false);
            this.paneladmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2admin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label lblEmail;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPerfilUser;
    }
}