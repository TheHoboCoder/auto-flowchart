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
        private const int MOVE_CONTROL_HEIGHT = 30;

        public bool IsMoveable
        {
            set
            {
                moveControl.Enabled = value;
            }
            get
            {
                return moveControl.Enabled;
            }
        }

       


        public void ResizeControls()
        {
            moveControl.Location = new Point(0, 0);
            moveControl.Height = MOVE_CONTROL_HEIGHT;
            moveControl.Width = Width;
            upperLeftControl.Location = new Point(0, MOVE_CONTROL_HEIGHT);
            topControl.Location = new Point(BORDER_WIDTH, MOVE_CONTROL_HEIGHT);
            
            int hLength = Width - BORDER_WIDTH * 2;
            int hX = Width - BORDER_WIDTH;
            int vLenght = Height - BORDER_WIDTH * 2 ;
            int hY = Height - BORDER_WIDTH ;

            topControl.Width = hLength;
            upperRightControl.Location = new Point(hX, MOVE_CONTROL_HEIGHT);
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
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(0, Color.Transparent);
            topControl.Height = BORDER_WIDTH;
            bottomControl.Height = BORDER_WIDTH;
            leftControl.Width = BORDER_WIDTH;
            rightControl.Width = BORDER_WIDTH;
            upperLeftControl.Height = upperLeftControl.Width = BORDER_WIDTH;
            
            upperRightControl.Height = upperRightControl.Width = BORDER_WIDTH;
            bottomLeftControl.Height = bottomLeftControl.Width = BORDER_WIDTH;
            bottomRightControl.Height = bottomRightControl.Width = BORDER_WIDTH;
            ResizeControls();
        }

        

        private void upperRightControl_LocationChanged(object sender, EventArgs e)
        {
            topControl.Top = upperRightControl.Top;
            rightControl.Left = upperRightControl.Left;
        }

        private void rightControl_LocationChanged(object sender, EventArgs e)
        {
            if(rightControl.Left + BORDER_WIDTH!= Width)
            {
                Width += (rightControl.Left + BORDER_WIDTH) - Width;
                //topControl.Width = bottomControl.Width = Width;
                //upperRightControl.Left = bottomRightControl.Left= rightControl.Left;

            }
            //if(rightControl.Left + BORDER_WIDTH > Width)
            //{
                
            //}

            //if (rightControl.Left + BORDER_WIDTH < Width)
            //{
            //    Width += (rightControl.Left + BORDER_WIDTH) - Width;
            //}
        }

        private void controls_MouseUp(object sender, MouseEventArgs e)
        {
            ResizeControls();
        }
        private void leftControl_LocationChanged(object sender, EventArgs e)
        {
            if ( leftControl.Left != 0)
            {
                
                Width -= leftControl.Left;
                Left += leftControl.Left;
                
            }
        }

        private void bottomControl_LocationChanged(object sender, EventArgs e)
        {
            if ( bottomControl.Top + BORDER_WIDTH != Height)
            {
                Height += (bottomControl.Top + BORDER_WIDTH) - Height;
                //leftControl.Height = rightControl.Height = Height;
                //bottomRightControl.Top = bottomLeftControl.Top = bottomControl.Top;
            }
        }

        private void TransformControl_Resize(object sender, EventArgs e)
        {
            
        }

        private void moveControl_LocationChanged(object sender, EventArgs e)
        {
            Left += moveControl.Left;
            Top += moveControl.Top;
            ResizeControls();
        }

        private void TransformControl_Load(object sender, EventArgs e)
        {

        }
    }
}
