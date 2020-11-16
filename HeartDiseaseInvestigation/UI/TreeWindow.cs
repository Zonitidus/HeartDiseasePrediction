using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartDiseaseInvestigation.DecisionTreeClassifier;
using HeartDiseaseInvestigation.Model;
using HeartDiseaseInvestigation.TreeVisualization;
using TreeNode = HeartDiseaseInvestigation.TreeVisualization.TreeNode;

namespace HeartDiseaseInvestigation.UI
{
    public partial class TreeWindow : Form
    {

        private TreeNode root;

        public TreeWindow(Node<Patient> rootTree)
        {
            InitializeComponent();
            this.InitializeTree(rootTree);

            Console.WriteLine(rootTree.ToString());
        }

        public void InitializeTree(Node<Patient> rootTree)
        {

            this.root = new TreeNode(new CircleNode(rootTree.ToString()));
            this.GenerateTree(rootTree, null);

            this.Arrange();
        }

        public void GenerateTree(Node<Patient> t, TreeNode parent)
        {

            TreeNode newNode = new TreeNode(new CircleNode(t.ToString()));

            if(parent != null)
            {
                if (t.GetTrueNode() != null)
                {
                    parent.AddTrueNode(new TreeNode(new CircleNode(t.GetTrueNode().ToString())));
                    GenerateTree(t.GetTrueNode(), newNode);
                }

                if (t.GetFalseNode() != null)
                {
                    parent.AddFalseNode(new TreeNode(new CircleNode(t.GetFalseNode().ToString())));
                    GenerateTree(t.GetFalseNode(), newNode);
                }
            }
            else
            {
                if (t.GetTrueNode() != null)
                {
                    this.root.AddTrueNode(new TreeNode(new CircleNode(t.GetTrueNode().ToString())));
                    GenerateTree(t.GetTrueNode(), newNode);
                }

                if (t.GetFalseNode() != null)
                {
                    this.root.AddFalseNode(new TreeNode(new CircleNode(t.GetFalseNode().ToString())));
                    GenerateTree(t.GetFalseNode(), newNode);
                }
            }
        }

        public void Arrange()
        {
            using (Graphics gr = pictureBox.CreateGraphics())
            {
                float xmin = 0, ymin = 0;
                root.Arrange(gr, ref xmin, ref ymin);

                xmin = (pictureBox.ClientSize.Width - xmin) / 2;
                ymin = 10;
                this.root.Arrange(gr, ref xmin, ref ymin);

            }

            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            root.DrawTree(e.Graphics);
        }

        private void pictureBox_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            root.DrawTree(e.Graphics);
        }
    }
}
