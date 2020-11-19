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

        }

        public void InitializeTree(Node<Patient> rootTree)
        {

            Console.WriteLine(rootTree.GetTrueNode().ToString());
            Console.WriteLine("\t"+rootTree.GetTrueNode().GetFalseNode().ToString());
            Console.WriteLine("\t"+rootTree.GetTrueNode().GetTrueNode().ToString());
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

       

        private void pictureBox_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            root.DrawTree(e.Graphics);
        }
    }
}
