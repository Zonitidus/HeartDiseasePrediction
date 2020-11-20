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
using HeartDiseaseInvestigation.DecisionTreeClassifier;
using HeartDiseaseInvestigation.TreeVisualization;
using TreeNode = HeartDiseaseInvestigation.TreeVisualization.TreeNode;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace HeartDiseaseInvestigation
{

    public partial class PatientsFileWindow : Form
    {
        int w;
        int h;
        Connection cn = new Connection();
        private TreeNode root;

        public PatientsFileWindow(Node<Patient> rootTree)
        {
            InitializeComponent();
            pictureBoxLogo.Image = Image.FromFile("../../Data/logo.ico");
            //this.InitializeTree(rootTree);
            pictureBoxTree.Image = cn.ImageFromAnURI("https://pi-final-app.herokuapp.com/draw-tree");
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


        //Decision tree manual
        /*
        public void InitializeTree(Node<Patient> rootTree)
        {

            Console.WriteLine(rootTree.GetTrueNode().ToString());
            Console.WriteLine("\t" + rootTree.GetTrueNode().GetFalseNode().ToString());
            Console.WriteLine("\t" + rootTree.GetTrueNode().GetTrueNode().ToString());
            Console.WriteLine(rootTree.GetFalseNode().ToString());
            Console.WriteLine("\t" + rootTree.GetFalseNode().GetFalseNode().ToString());
            Console.WriteLine("\t" + rootTree.GetFalseNode().GetTrueNode().ToString());

            this.root = new TreeNode(new CircleNode(rootTree.ToString()));
            this.GenerateTree(rootTree);
            this.Arrange();
        }

        public void GenerateTree(Node<Patient> rootTree)
        {
            this.root = new TreeNode(new CircleNode(rootTree.ToString()));

            if (rootTree.GetTrueNode() != null)
            {
                AddNode(rootTree.GetTrueNode(), this.root);
            }

            if (rootTree.GetFalseNode() != null)
            {
                AddNode(rootTree.GetFalseNode(), this.root);
            }
        }

        public void AddNode(Node<Patient> t, TreeNode parent)
        {

            TreeNode newNode = new TreeNode(new CircleNode(t.ToString()));


            if (parent.GetTrueNode() == null)
            {
                parent.AddTrueNode(newNode);
            }
            else
            {
                parent.AddFalseNode(newNode);
            }


            if (t.GetTrueNode() != null)
            {
                AddNode(t.GetTrueNode(), newNode);
            }
            if (t.GetFalseNode() != null)
            {
                AddNode(t.GetFalseNode(), newNode);
            }
        }

        public void Arrange()
        {
            using (Graphics gr = pictureBoxTreeManual.CreateGraphics())
            {
                float xmin = 0, ymin = 0;
                root.Arrange(gr, ref xmin, ref ymin);

                xmin = (pictureBoxTreeManual.ClientSize.Width - xmin) / 2;
                ymin = 10;
                this.root.Arrange(gr, ref xmin, ref ymin);

            }

            pictureBoxTreeManual.Refresh();
        }
        */
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            root.DrawTree(e.Graphics);
        }
        
        private void buttonTrainTreeAuto_Click(object sender, EventArgs e)
        {
            labelTrainTreeAuto.Text = cn.Train("https://pi-final-app.herokuapp.com/train");
        }
    }
}
