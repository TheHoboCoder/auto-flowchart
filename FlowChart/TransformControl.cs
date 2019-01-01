using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChart
{
    public partial class TransformControl : UserControl
    {

        private const int BORDER_WIDTH = 10;


        public void ResizeControls()
        {
            upperLeftControl.Location = new Point(0, 0);
            topControl.Location = new Point(BORDER_WIDTH, 0);
            
            int hLength = Width - BORDER_WIDTH * 2;
            int hX = Width - BORDER_WIDTH;
            int vLenght = Height - BORDER_WIDTH * 2;
            int hY = Height - BORDER_WIDTH;

            topControl.Width = hLength;
            upperRightControl.Location = new Point(hX, 0);
            rightControl.Location = new Point(hX, BORDER_WIDTH);
            rightControl.Height = vLenght;
            bottomRightControl.Location = new Point(hX, hY);
            bottomControl.Location = new Point(BORDER_WIDTH, hY);
            bottomControl.Width = hLength;
            bottomLeftControl.Location = new Point(0, hY);
            leftControl.Location = new Point(0, BORDER_WIDTH);
            leftControl.Height = vLenght;

        }
        public TransformControl()
        {
            InitializeComponent();

            topControl.Height = BORDER_WIDTH;
            bottomControl.Height = BORDER_WIDTH;
            leftControl.Width = BORDER_WIDTH;
            rightControl.Width = BORDER_WIDTH;
            upperLeftControl.Height = upperLeftControl.Width = BORDER_WIDTH;
            
            upperRightControl.Height = upperRightControl.Width = BORDER_WIDTH;
            bottomLeftControl.Height = bottomLeftControl.Width = BORDER_WIDTH;
            bottomRightControl.Height = bottomRightControl.Width = BORDER_WIDTH;
        }

        private void bottomRightControl_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void upperRightControl_LocationChanged(object sender, EventArgs e)
        {
            topControl.Top = upperRightControl.Top;
            rightControl.Left = upperRightControl.Left;
        }
    }
}
