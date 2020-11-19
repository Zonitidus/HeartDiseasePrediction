using HeartDiseaseInvestigation.Model;
using HeartDiseaseInvestigation.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartDiseaseInvestigation
{

    public partial class PatientsFileWindow : Form
    {
        int w;
        int h;
        public PatientsFileWindow()
        {
            InitializeComponent();
            pictureBoxTree.Image = Image.FromFile("../../Data/img.png");
            w = pictureBoxTree.Width;
            h = pictureBoxTree.Height;
            zoomIn.BackgroundImage = Image.FromFile("../../Data/zoomIn.png");
            zoomOut.BackgroundImage = Image.FromFile("../../Data/zoomOut.png");
            zoomIn.BackgroundImageLayout = ImageLayout.Stretch;
            zoomOut.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = new Icon("../../Data/logo.ico");
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            pictureBoxTree.Width += 20;
            pictureBoxTree.Height += 20;
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            pictureBoxTree.Width -= 20;
            pictureBoxTree.Height -= 20;
        }

        private void buttonResetZoom_Click(object sender, EventArgs e)
        {
            pictureBoxTree.Width = w;
            pictureBoxTree.Height = h;
        }
    }
}
