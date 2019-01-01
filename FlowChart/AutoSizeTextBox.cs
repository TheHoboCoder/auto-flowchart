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
    public partial class AutoSizeTextBox : TextBox
    {
        public AutoSizeTextBox()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.TextAlign = HorizontalAlignment.Center;
            this.Multiline = true;
            this.TextChanged += new EventHandler(onTextChanged);

        }

        public bool isAutoSize { get; set; }

        private void onTextChanged(object sender, EventArgs e)
        {
            if (isAutoSize)
            {
                Size size = TextRenderer.MeasureText(Text, Font);
                //if (size.Width > Width)
                //{
                //    for(int i = Text.Length-1; i > 0; --i)
                //    {

                //    }
                //}
                Height = size.Height;
            }
        }
    }
}
