﻿namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegistroLnk = new System.Windows.Forms.LinkLabel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.WindowNameLbl = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.RegistroPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NombreRegLbl = new System.Windows.Forms.Label();
            this.RegNombreTxt = new System.Windows.Forms.TextBox();
            this.ConfContrRegLbl = new System.Windows.Forms.Label();
            this.RegConfTxt = new System.Windows.Forms.TextBox();
            this.ContraseñaRegLbl = new System.Windows.Forms.Label();
            this.RegContraseniaTxt = new System.Windows.Forms.TextBox();
            this.EmailRegLbl = new System.Windows.Forms.Label();
            this.RegEmailTxt = new System.Windows.Forms.TextBox();
            this.usernameRegLbl = new System.Windows.Forms.Label();
            this.RegUsernameTxt = new System.Windows.Forms.TextBox();
            this.TitleRegistroLbl = new System.Windows.Forms.Label();
            this.CancelRegBtn = new System.Windows.Forms.Button();
            this.ErrorRegLbl = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.RegistroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(285, 117);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(226, 31);
            this.UsernameTxt.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CloseBtn.Location = new System.Drawing.Point(770, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(15, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "×";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinimizeBtn.Location = new System.Drawing.Point(740, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(24, 23);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.Text = "--";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(285, 163);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '●';
            this.PasswordTxt.Size = new System.Drawing.Size(226, 31);
            this.PasswordTxt.TabIndex = 3;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(283, 33);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(228, 46);
            this.TitleLbl.TabIndex = 4;
            this.TitleLbl.Text = "Peru Virtual";
            this.TitleLbl.Click += new System.EventHandler(this.TitleLbl_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkRed;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(285, 213);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(226, 31);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegistroLnk
            // 
            this.RegistroLnk.AutoSize = true;
            this.RegistroLnk.Location = new System.Drawing.Point(288, 197);
            this.RegistroLnk.Name = "RegistroLnk";
            this.RegistroLnk.Size = new System.Drawing.Size(79, 13);
            this.RegistroLnk.TabIndex = 6;
            this.RegistroLnk.TabStop = true;
            this.RegistroLnk.Text = "Registrate Aqui";
            this.RegistroLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistroLnk_LinkClicked);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Maroon;
            this.TopPanel.Controls.Add(this.WindowNameLbl);
            this.TopPanel.Controls.Add(this.MinimizeBtn);
            this.TopPanel.Controls.Add(this.CloseBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 28);
            this.TopPanel.TabIndex = 7;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // WindowNameLbl
            // 
            this.WindowNameLbl.AutoSize = true;
            this.WindowNameLbl.Location = new System.Drawing.Point(12, 8);
            this.WindowNameLbl.Name = "WindowNameLbl";
            this.WindowNameLbl.Size = new System.Drawing.Size(93, 13);
            this.WindowNameLbl.TabIndex = 3;
            this.WindowNameLbl.Text = "PeruVirtual - Login";
            this.WindowNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.TitleLbl);
            this.LoginPanel.Controls.Add(this.UsernameTxt);
            this.LoginPanel.Controls.Add(this.LoginBtn);
            this.LoginPanel.Controls.Add(this.RegistroLnk);
            this.LoginPanel.Controls.Add(this.PasswordTxt);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 28);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(800, 422);
            this.LoginPanel.TabIndex = 8;
            // 
            // RegistroPanel
            // 
            this.RegistroPanel.Controls.Add(this.ErrorRegLbl);
            this.RegistroPanel.Controls.Add(this.CancelRegBtn);
            this.RegistroPanel.Controls.Add(this.button1);
            this.RegistroPanel.Controls.Add(this.NombreRegLbl);
            this.RegistroPanel.Controls.Add(this.RegNombreTxt);
            this.RegistroPanel.Controls.Add(this.ConfContrRegLbl);
            this.RegistroPanel.Controls.Add(this.RegConfTxt);
            this.RegistroPanel.Controls.Add(this.ContraseñaRegLbl);
            this.RegistroPanel.Controls.Add(this.RegContraseniaTxt);
            this.RegistroPanel.Controls.Add(this.EmailRegLbl);
            this.RegistroPanel.Controls.Add(this.RegEmailTxt);
            this.RegistroPanel.Controls.Add(this.usernameRegLbl);
            this.RegistroPanel.Controls.Add(this.RegUsernameTxt);
            this.RegistroPanel.Controls.Add(this.TitleRegistroLbl);
            this.RegistroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistroPanel.Location = new System.Drawing.Point(0, 28);
            this.RegistroPanel.Name = "RegistroPanel";
            this.RegistroPanel.Size = new System.Drawing.Size(800, 422);
            this.RegistroPanel.TabIndex = 7;
            this.RegistroPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(406, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NombreRegLbl
            // 
            this.NombreRegLbl.AutoSize = true;
            this.NombreRegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRegLbl.Location = new System.Drawing.Point(176, 92);
            this.NombreRegLbl.Name = "NombreRegLbl";
            this.NombreRegLbl.Size = new System.Drawing.Size(170, 25);
            this.NombreRegLbl.TabIndex = 10;
            this.NombreRegLbl.Text = "Nombre Completo";
            // 
            // RegNombreTxt
            // 
            this.RegNombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNombreTxt.Location = new System.Drawing.Point(382, 92);
            this.RegNombreTxt.Name = "RegNombreTxt";
            this.RegNombreTxt.Size = new System.Drawing.Size(251, 30);
            this.RegNombreTxt.TabIndex = 2;
            // 
            // ConfContrRegLbl
            // 
            this.ConfContrRegLbl.AutoSize = true;
            this.ConfContrRegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfContrRegLbl.Location = new System.Drawing.Point(176, 200);
            this.ConfContrRegLbl.Name = "ConfContrRegLbl";
            this.ConfContrRegLbl.Size = new System.Drawing.Size(204, 25);
            this.ConfContrRegLbl.TabIndex = 8;
            this.ConfContrRegLbl.Text = "Confirmar Contraseña";
            // 
            // RegConfTxt
            // 
            this.RegConfTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegConfTxt.Location = new System.Drawing.Point(382, 200);
            this.RegConfTxt.Name = "RegConfTxt";
            this.RegConfTxt.PasswordChar = '●';
            this.RegConfTxt.Size = new System.Drawing.Size(251, 30);
            this.RegConfTxt.TabIndex = 5;
            // 
            // ContraseñaRegLbl
            // 
            this.ContraseñaRegLbl.AutoSize = true;
            this.ContraseñaRegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaRegLbl.Location = new System.Drawing.Point(176, 164);
            this.ContraseñaRegLbl.Name = "ContraseñaRegLbl";
            this.ContraseñaRegLbl.Size = new System.Drawing.Size(114, 25);
            this.ContraseñaRegLbl.TabIndex = 6;
            this.ContraseñaRegLbl.Text = "Contraseña";
            // 
            // RegContraseniaTxt
            // 
            this.RegContraseniaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegContraseniaTxt.Location = new System.Drawing.Point(382, 164);
            this.RegContraseniaTxt.Name = "RegContraseniaTxt";
            this.RegContraseniaTxt.PasswordChar = '●';
            this.RegContraseniaTxt.Size = new System.Drawing.Size(251, 30);
            this.RegContraseniaTxt.TabIndex = 4;
            // 
            // EmailRegLbl
            // 
            this.EmailRegLbl.AutoSize = true;
            this.EmailRegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailRegLbl.Location = new System.Drawing.Point(176, 128);
            this.EmailRegLbl.Name = "EmailRegLbl";
            this.EmailRegLbl.Size = new System.Drawing.Size(60, 25);
            this.EmailRegLbl.TabIndex = 4;
            this.EmailRegLbl.Text = "Email";
            this.EmailRegLbl.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // RegEmailTxt
            // 
            this.RegEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEmailTxt.Location = new System.Drawing.Point(382, 128);
            this.RegEmailTxt.Name = "RegEmailTxt";
            this.RegEmailTxt.Size = new System.Drawing.Size(251, 30);
            this.RegEmailTxt.TabIndex = 3;
            // 
            // usernameRegLbl
            // 
            this.usernameRegLbl.AutoSize = true;
            this.usernameRegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegLbl.Location = new System.Drawing.Point(176, 56);
            this.usernameRegLbl.Name = "usernameRegLbl";
            this.usernameRegLbl.Size = new System.Drawing.Size(180, 25);
            this.usernameRegLbl.TabIndex = 2;
            this.usernameRegLbl.Text = "Nombre de Usuario";
            // 
            // RegUsernameTxt
            // 
            this.RegUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUsernameTxt.Location = new System.Drawing.Point(382, 56);
            this.RegUsernameTxt.Name = "RegUsernameTxt";
            this.RegUsernameTxt.Size = new System.Drawing.Size(251, 30);
            this.RegUsernameTxt.TabIndex = 1;
            // 
            // TitleRegistroLbl
            // 
            this.TitleRegistroLbl.AutoSize = true;
            this.TitleRegistroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRegistroLbl.Location = new System.Drawing.Point(324, 15);
            this.TitleRegistroLbl.Name = "TitleRegistroLbl";
            this.TitleRegistroLbl.Size = new System.Drawing.Size(116, 31);
            this.TitleRegistroLbl.TabIndex = 0;
            this.TitleRegistroLbl.Text = "Registro";
            this.TitleRegistroLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CancelRegBtn
            // 
            this.CancelRegBtn.FlatAppearance.BorderSize = 0;
            this.CancelRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelRegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelRegBtn.Location = new System.Drawing.Point(181, 250);
            this.CancelRegBtn.Name = "CancelRegBtn";
            this.CancelRegBtn.Size = new System.Drawing.Size(227, 49);
            this.CancelRegBtn.TabIndex = 7;
            this.CancelRegBtn.Text = "Cancelar";
            this.CancelRegBtn.UseVisualStyleBackColor = true;
            this.CancelRegBtn.Click += new System.EventHandler(this.CancelRegBtn_Click);
            // 
            // ErrorRegLbl
            // 
            this.ErrorRegLbl.AutoSize = true;
            this.ErrorRegLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ErrorRegLbl.Location = new System.Drawing.Point(346, 234);
            this.ErrorRegLbl.Name = "ErrorRegLbl";
            this.ErrorRegLbl.Size = new System.Drawing.Size(0, 13);
            this.ErrorRegLbl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistroPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "PeruVirtual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegistroPanel.ResumeLayout(false);
            this.RegistroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.LinkLabel RegistroLnk;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label WindowNameLbl;
        private System.Windows.Forms.Panel RegistroPanel;
        private System.Windows.Forms.Label TitleRegistroLbl;
        private System.Windows.Forms.Label EmailRegLbl;
        private System.Windows.Forms.TextBox RegEmailTxt;
        private System.Windows.Forms.Label usernameRegLbl;
        private System.Windows.Forms.TextBox RegUsernameTxt;
        private System.Windows.Forms.Label ContraseñaRegLbl;
        private System.Windows.Forms.TextBox RegContraseniaTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NombreRegLbl;
        private System.Windows.Forms.TextBox RegNombreTxt;
        private System.Windows.Forms.Label ConfContrRegLbl;
        private System.Windows.Forms.TextBox RegConfTxt;
        private System.Windows.Forms.Button CancelRegBtn;
        private System.Windows.Forms.Label ErrorRegLbl;
    }
}

