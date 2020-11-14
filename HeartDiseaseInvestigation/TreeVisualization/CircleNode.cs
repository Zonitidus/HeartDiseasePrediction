using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDiseaseInvestigation.TreeVisualization
{
    class CircleNode
    {
        private String data;

        public CircleNode(String data)
        {
            this.data = data;
        }

        public SizeF GetSize(Graphics graph, Font font)
        {
            return graph.MeasureString(this.data, font) + new SizeF(10, 10);
        }

        public void Draw(float x, float y, Graphics graph, Pen pen, Brush background, Brush textBrush, Font font)
        {

            SizeF size = this.GetSize(graph, font);

            RectangleF rect = new RectangleF(x - size.Width / 2, y - size.Height / 2, size.Width, size.Height);

            graph.FillEllipse(background, rect);
            graph.DrawEllipse(pen, rect);

            using (StringFormat string_format = new StringFormat())
            {
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;
                graph.DrawString(this.data, font, textBrush, x, y, string_format);
            }
        }
    }
}
