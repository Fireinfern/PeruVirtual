﻿namespace PresentationLayer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanelTask = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.Paracas = new System.Windows.Forms.PictureBox();
            this.Nazca = new System.Windows.Forms.PictureBox();
            this.Sacsayhuaman = new System.Windows.Forms.PictureBox();
            this.Caral = new System.Windows.Forms.PictureBox();
            this.MachuPicchu = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Separacion = new System.Windows.Forms.Panel();
            this.PanelVideo = new System.Windows.Forms.Panel();
            this.Button_Explorar = new System.Windows.Forms.Button();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.PanelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paracas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nazca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacsayhuaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachuPicchu)).BeginInit();
            this.PanelVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTask
            // 
            this.PanelTask.BackColor = System.Drawing.Color.Black;
            this.PanelTask.Controls.Add(this.Restaurar);
            this.PanelTask.Controls.Add(this.Minimizar);
            this.PanelTask.Controls.Add(this.Maximizar);
            this.PanelTask.Controls.Add(this.Salir);
            this.PanelTask.Controls.Add(this.label1);
            this.PanelTask.Controls.Add(this.pictureBox1);
            this.PanelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTask.ForeColor = System.Drawing.Color.Transparent;
            this.PanelTask.Location = new System.Drawing.Point(0, 0);
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.Size = new System.Drawing.Size(1280, 60);
            this.PanelTask.TabIndex = 0;
            this.PanelTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseDown);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1202, 16);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1166, 16);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1202, 16);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1238, 16);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hoodson Script Free Demo", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(63, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "PerúVirtual";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Controls.Add(this.Paracas);
            this.PanelOpciones.Controls.Add(this.Nazca);
            this.PanelOpciones.Controls.Add(this.Sacsayhuaman);
            this.PanelOpciones.Controls.Add(this.Caral);
            this.PanelOpciones.Controls.Add(this.MachuPicchu);
            this.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelOpciones.Location = new System.Drawing.Point(0, 600);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(1280, 120);
            this.PanelOpciones.TabIndex = 1;
            // 
            // Paracas
            // 
            this.Paracas.Image = global::PresentationLayer.Properties.Resources.Paracas;
            this.Paracas.Location = new System.Drawing.Point(640, 0);
            this.Paracas.Name = "Paracas";
            this.Paracas.Size = new System.Drawing.Size(160, 100);
            this.Paracas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paracas.TabIndex = 6;
            this.Paracas.TabStop = false;
            this.Paracas.Click += new System.EventHandler(this.Paracas_Click);
            this.Paracas.MouseEnter += new System.EventHandler(this.Paracas_MouseEnter);
            this.Paracas.MouseLeave += new System.EventHandler(this.Paracas_MouseLeave);
            // 
            // Nazca
            // 
            this.Nazca.Image = ((System.Drawing.Image)(resources.GetObject("Nazca.Image")));
            this.Nazca.Location = new System.Drawing.Point(480, 0);
            this.Nazca.Name = "Nazca";
            this.Nazca.Size = new System.Drawing.Size(160, 100);
            this.Nazca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nazca.TabIndex = 5;
            this.Nazca.TabStop = false;
            this.Nazca.Click += new System.EventHandler(this.Nazca_Click);
            this.Nazca.MouseEnter += new System.EventHandler(this.Nazca_MouseEnter);
            this.Nazca.MouseLeave += new System.EventHandler(this.Nazca_MouseLeave);
            // 
            // Sacsayhuaman
            // 
            this.Sacsayhuaman.Image = ((System.Drawing.Image)(resources.GetObject("Sacsayhuaman.Image")));
            this.Sacsayhuaman.Location = new System.Drawing.Point(320, 0);
            this.Sacsayhuaman.Name = "Sacsayhuaman";
            this.Sacsayhuaman.Size = new System.Drawing.Size(160, 100);
            this.Sacsayhuaman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sacsayhuaman.TabIndex = 4;
            this.Sacsayhuaman.TabStop = false;
            this.Sacsayhuaman.Click += new System.EventHandler(this.Sacsayhuaman_Click);
            this.Sacsayhuaman.MouseEnter += new System.EventHandler(this.Sacsayhuaman_MouseEnter);
            this.Sacsayhuaman.MouseLeave += new System.EventHandler(this.Sacsayhuaman_MouseLeave);
            // 
            // Caral
            // 
            this.Caral.Image = ((System.Drawing.Image)(resources.GetObject("Caral.Image")));
            this.Caral.Location = new System.Drawing.Point(160, 0);
            this.Caral.Name = "Caral";
            this.Caral.Size = new System.Drawing.Size(160, 100);
            this.Caral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Caral.TabIndex = 3;
            this.Caral.TabStop = false;
            this.Caral.Click += new System.EventHandler(this.Caral_Click);
            this.Caral.MouseEnter += new System.EventHandler(this.Caral_MouseEnter);
            this.Caral.MouseLeave += new System.EventHandler(this.Caral_MouseLeave);
            // 
            // MachuPicchu
            // 
            this.MachuPicchu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MachuPicchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MachuPicchu.Image = ((System.Drawing.Image)(resources.GetObject("MachuPicchu.Image")));
            this.MachuPicchu.Location = new System.Drawing.Point(0, 0);
            this.MachuPicchu.Name = "MachuPicchu";
            this.MachuPicchu.Padding = new System.Windows.Forms.Padding(1);
            this.MachuPicchu.Size = new System.Drawing.Size(160, 100);
            this.MachuPicchu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MachuPicchu.TabIndex = 2;
            this.MachuPicchu.TabStop = false;
            this.MachuPicchu.Click += new System.EventHandler(this.MachuPicchu_Click);
            this.MachuPicchu.MouseEnter += new System.EventHandler(this.MachuPicchu_MouseEnter);
            this.MachuPicchu.MouseLeave += new System.EventHandler(this.MachuPicchu_MouseLeave);
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Hoodson Script Free Demo", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 60);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1280, 60);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Machu Picchu";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Separacion
            // 
            this.Separacion.BackColor = System.Drawing.Color.Black;
            this.Separacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separacion.Location = new System.Drawing.Point(0, 595);
            this.Separacion.Name = "Separacion";
            this.Separacion.Size = new System.Drawing.Size(1280, 5);
            this.Separacion.TabIndex = 3;
            // 
            // PanelVideo
            // 
            this.PanelVideo.Controls.Add(this.Button_Explorar);
            this.PanelVideo.Controls.Add(this.VideoPlayer);
            this.PanelVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelVideo.Location = new System.Drawing.Point(0, 120);
            this.PanelVideo.Margin = new System.Windows.Forms.Padding(50);
            this.PanelVideo.Name = "PanelVideo";
            this.PanelVideo.Size = new System.Drawing.Size(1280, 475);
            this.PanelVideo.TabIndex = 7;
            // 
            // Button_Explorar
            // 
            this.Button_Explorar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Explorar.BackColor = System.Drawing.Color.White;
            this.Button_Explorar.BackgroundImage = global::PresentationLayer.Properties.Resources.btn_explorar;
            this.Button_Explorar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Explorar.FlatAppearance.BorderSize = 0;
            this.Button_Explorar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Explorar.Font = new System.Drawing.Font("Hoodson Script Free Demo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Explorar.Location = new System.Drawing.Point(546, 369);
            this.Button_Explorar.Name = "Button_Explorar";
            this.Button_Explorar.Size = new System.Drawing.Size(250, 50);
            this.Button_Explorar.TabIndex = 8;
            this.Button_Explorar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Explorar.UseVisualStyleBackColor = false;
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(0, 0);
            this.VideoPlayer.Margin = new System.Windows.Forms.Padding(15);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(1280, 475);
            this.VideoPlayer.TabIndex = 2;
            this.VideoPlayer.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.VideoPlayer_MouseDownEvent);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PanelVideo);
            this.Controls.Add(this.Separacion);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PanelOpciones);
            this.Controls.Add(this.PanelTask);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peru";
            this.PanelTask.ResumeLayout(false);
            this.PanelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Paracas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nazca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacsayhuaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachuPicchu)).EndInit();
            this.PanelVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.PictureBox MachuPicchu;
        private System.Windows.Forms.PictureBox Paracas;
        private System.Windows.Forms.PictureBox Nazca;
        private System.Windows.Forms.PictureBox Sacsayhuaman;
        private System.Windows.Forms.PictureBox Caral;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Panel Separacion;
        private System.Windows.Forms.Panel PanelVideo;
        private System.Windows.Forms.Button Button_Explorar;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
    }
}