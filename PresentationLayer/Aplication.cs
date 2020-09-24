using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Aplication : Form
    {
        private string[] destinos = { "Caral", "Machu Picchu"};
        private int currentDestination;
        public Aplication()
        {
            InitializeComponent();
        }

        private void selectImage() {
            switch (this.destinos[this.currentDestination])
            {
                case "Caral":
                    this.CaralPicture.Visible = true;
                    this.MachuPicchuImage.Visible = false;
                    break;
                case "Machu Picchu":
                    this.MachuPicchuImage.Visible = true;
                    this.CaralPicture.Visible = false;
                    break;
            }
        }

        private void IniciarTourBtn_Click(object sender, EventArgs e)
        {

        }

        private void Aplication_Load(object sender, EventArgs e)
        {
            this.currentDestination = 0;
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            int n = this.destinos.Length;
            this.currentDestination = this.currentDestination + 1;
            if (this.currentDestination >= n)
            {
                this.currentDestination = 0;
            }
            NameTitleLbl.Text = this.destinos[this.currentDestination];
            selectImage();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //int n = this.destinos.Length;
            this.currentDestination = this.currentDestination - 1;
            if (this.currentDestination < 0)
            {
                this.currentDestination = 1;
            }
            NameTitleLbl.Text = this.destinos[this.currentDestination];
            selectImage();
        }
    }
}
