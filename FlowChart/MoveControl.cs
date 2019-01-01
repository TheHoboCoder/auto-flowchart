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
    public partial class MoveControl : UserControl
    {
        private int  xPos;
        private int  yPos;

        public enum MoveDirection
        {
            BOTH,
            VERTICAL,
            HORIZONTAL
        }
        public MoveDirection CurrentMoveDirection { get; set; }

        public MoveControl()
        {
            InitializeComponent();
        }
        
        private void MoveControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                switch (CurrentMoveDirection)
                {
                    case MoveDirection.VERTICAL:
                        this.Top = this.Top + e.Y - yPos;
                        break;
                    case MoveDirection.HORIZONTAL:
                        this.Left = this.Left + e.X - xPos;
                        break;
                    case MoveDirection.BOTH:
                        this.Left = this.Left + e.X - xPos;
                        this.Top = this.Top + e.Y - yPos;
                        break;
                }
                
            }
        }

        private void MoveControl_MouseDown(object sender, MouseEventArgs e)
        {
            xPos = e.X;
            yPos = e.Y;
        }
    }
}
