using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FlowChart
{
    public partial class FlowBlock : UserControl
    {
        private GraphicsPath figure;

        protected int textAreaLeftMargin { get; set; }
        protected int textAreaRightMargin { get; set; }
        protected int textMargin { get; set; }

        public bool canOverflow { get; set; }

        public string ChartText {
            get
            {
                return textArea.Text;
            }
            set
            {
                textArea.Text = value;
            }
        }


        protected virtual GraphicsPath initFigure(RectangleF bounds)
        {
            GraphicsPath figure = new GraphicsPath();
            figure.StartFigure();
            figure.AddRectangle(bounds);
            figure.CloseFigure();
            return figure;
        }



        public FlowBlock()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(resizeChart);
            this.Paint += paintChart;
            textAreaLeftMargin = textAreaRightMargin = 0;
            textArea.Font = FlowChartStyle.FCFont;
            textMargin = (int)Math.Round(FlowChartStyle.BorderWidth);
            relocateText();
            textArea.BackColor = FlowChartStyle.FCBackColor;
            textArea.TextChanged += (sender, args) =>
            {
                relocateText();
            };
        }

        private void paintChart(object sender, PaintEventArgs e)
        {
            

            //Rectangle rect = new Rectangle(0, 0, Width, Height);
            //rect.X = textAreaLeftMargin;
            //rect.Y = 0;
            //rect.Width = Width - textAreaLeftMargin - textAreaRightMargin;
            //rect.Height = Height;
            //e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), rect);

            e.Graphics.FillPath(new SolidBrush(FlowChartStyle.FCBackColor), figure);
            Pen p = new Pen(FlowChartStyle.FCBorderColor, (float)Math.Round(FlowChartStyle.BorderWidth));
            p.Alignment = PenAlignment.Inset;
            e.Graphics.DrawPath(p, figure);
            //e.Graphics.DrawPath(new Pen(FlowChartStyle.FCBorderColor, (float)Math.Round(FlowChartStyle.BorderWidth)), drawFigure);
            //e.Graphics.DrawPath(new Pen(FlowChartStyle.FCBorderColor, 7), figure);
            //e.Graphics.DrawPath(new Pen(Color.Red, 1), drawFigure);

        }
        private void relocateText()
        {
            int heightArea = Height - textMargin * 2;
            if (textArea.Height<heightArea)
            {
                int pos = (int)(heightArea - textArea.Height) / 2;
                if (pos <= textMargin)
                {
                    textArea.Top = textMargin;
                }
                else
                {
                    textArea.Top = pos;
                } 
            }
            else
            {
                if(canOverflow)
                {
                    this.Height += textArea.Height - heightArea+textMargin*2;
                }
                else
                {
                    textArea.Height = heightArea;
                }

            }
        }

        private void resizeChart(object sender, EventArgs e)
        {
            //this.Width += (int)FlowChartStyle.BorderWidth / 2;
            //this.Height += (int)FlowChartStyle.BorderWidth / 2;
            textArea.Left = textAreaLeftMargin + textMargin;
            relocateText();
            //textArea.Top = textMargin;
            textArea.Width = Width - textAreaRightMargin - textAreaLeftMargin -textMargin*2;
            if (Math.Round(FlowChartStyle.BorderWidth) == 1)
            {
                figure = initFigure(new RectangleF(0, 0, Width-1, Height-1));
            }
            else
            {
                figure = initFigure(new RectangleF(0, 0, Width, Height));
            }
            
            //float halfStroke = (float)Math.Round((FlowChartStyle.BorderWidth / 2.0), 1)-1;
            //int quoterStroke = (int)FlowChartStyle.BorderWidth / 4;
            //drawFigure = initFigure(new RectangleF(halfStroke, halfStroke, Width-FlowChartStyle.BorderWidth- quoterStroke, Height- FlowChartStyle.BorderWidth- quoterStroke));
        }

        //public void initTextArea(int x, int y,int width)
        //{
        //    textArea.X = x;
        //    textArea.Y = y;
        //    textArea.Width = width;
        //    textArea.Height = this.Height;
        //}

        
    }
}
