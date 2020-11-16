using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.root = new TreeNode(new CircleNode(root.ToString()));
            this.GenerateTree(rootTree, null);
            
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

    }
}
