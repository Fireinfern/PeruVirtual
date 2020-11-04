namespace PresentationLayer
{
    partial class Aplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplication));
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.InformacionBtn = new System.Windows.Forms.Button();
            this.IniciarTourBtn = new System.Windows.Forms.Button();
            this.CaralPicture = new System.Windows.Forms.PictureBox();
            this.NameTitleLbl = new System.Windows.Forms.Label();
            this.MachuPicchuImage = new System.Windows.Forms.PictureBox();
            this.TourPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CaralPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachuPicchuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ForwardButton, "ForwardButton");
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BackButton, "BackButton");
            this.BackButton.Name = "BackButton";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InformacionBtn
            // 
            this.InformacionBtn.BackColor = System.Drawing.Color.Transparent;
            this.InformacionBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.InformacionBtn, "InformacionBtn");
            this.InformacionBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.InformacionBtn.Name = "InformacionBtn";
            this.InformacionBtn.UseVisualStyleBackColor = false;
            this.InformacionBtn.Click += new System.EventHandler(this.InformacionBtn_Click);
            // 
            // IniciarTourBtn
            // 
            this.IniciarTourBtn.BackColor = System.Drawing.Color.Transparent;
            this.IniciarTourBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.IniciarTourBtn, "IniciarTourBtn");
            this.IniciarTourBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.IniciarTourBtn.Name = "IniciarTourBtn";
            this.IniciarTourBtn.UseVisualStyleBackColor = false;
            this.IniciarTourBtn.Click += new System.EventHandler(this.IniciarTourBtn_Click);
            // 
            // CaralPicture
            // 
            this.CaralPicture.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CaralPicture, "CaralPicture");
            this.CaralPicture.Name = "CaralPicture";
            this.CaralPicture.TabStop = false;
            // 
            // NameTitleLbl
            // 
            resources.ApplyResources(this.NameTitleLbl, "NameTitleLbl");
            this.NameTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameTitleLbl.ForeColor = System.Drawing.Color.Snow;
            this.NameTitleLbl.Name = "NameTitleLbl";
            // 
            // MachuPicchuImage
            // 
            this.MachuPicchuImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MachuPicchuImage, "MachuPicchuImage");
            this.MachuPicchuImage.Name = "MachuPicchuImage";
            this.MachuPicchuImage.TabStop = false;
            // 
            // TourPanel
            // 
            resources.ApplyResources(this.TourPanel, "TourPanel");
            this.TourPanel.Name = "TourPanel";
            // 
            // Aplication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ControlBox = false;
            this.Controls.Add(this.InformacionBtn);
            this.Controls.Add(this.TourPanel);
            this.Controls.Add(this.IniciarTourBtn);
            this.Controls.Add(this.MachuPicchuImage);
            this.Controls.Add(this.NameTitleLbl);
            this.Controls.Add(this.CaralPicture);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ForwardButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aplication";
            this.Load += new System.EventHandler(this.Aplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaralPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachuPicchuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button IniciarTourBtn;
        private System.Windows.Forms.PictureBox CaralPicture;
        private System.Windows.Forms.Label NameTitleLbl;
        private System.Windows.Forms.Button InformacionBtn;
        private System.Windows.Forms.PictureBox MachuPicchuImage;
        private System.Windows.Forms.Panel TourPanel;
    }
}