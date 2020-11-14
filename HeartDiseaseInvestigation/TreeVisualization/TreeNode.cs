using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.TreeVisualization
{
    class TreeNode
    {

        private CircleNode data;

        private TreeNode TrueNode;
        private TreeNode FalseNode;

        private float HOffset = 5;
        public float VOffset = 10;


        public float Indent = 20;
        public float SpotRadius = 5;

        private PointF DataCenter;

        private PointF SpotCenter;


        public Font font = new Font("Times New Roman", 12);
        public Pen pen = Pens.Black;
        public Brush fontBrush = Brushes.Black;
        public Brush backgroundBrush = Brushes.White;

        public void SetTreeDrawingParameters(float h_offset, float v_offset, float indent, float node_radius)
        {
            HOffset = h_offset;
            VOffset = v_offset;
            Indent = indent;
            SpotRadius = node_radius;

            this.TrueNode.SetTreeDrawingParameters(h_offset, v_offset, indent, node_radius);
            this.FalseNode.SetTreeDrawingParameters(h_offset, v_offset, indent, node_radius);
        }

        public TreeNode(CircleNode new_data)
        {
            this.data = new_data;
        }
        public TreeNode(CircleNode new_data, Font font)
        {
            this.data = new_data;
            this.font = font;
        }

        
    }
}
