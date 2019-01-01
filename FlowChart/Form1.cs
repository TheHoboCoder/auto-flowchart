using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FlowChartStyle.FCFont = new Font("Comic Sans MS", 14);
            FlowChartStyle.FCBorderWidth = FlowChartStyle.ChartBorderWidth.TINY_WIDTH;
            FlowChartStyle.FCBorderWidth = FlowChartStyle.ChartBorderWidth.NORMALL_WIDTH;

            FlowChartStyle.FCBorderWidth = FlowChartStyle.ChartBorderWidth.LARGE_WIDTH;
            FlowChartStyle.FCBorderWidth = FlowChartStyle.ChartBorderWidth.XLARGE_WIDTH;
            FlowBlock f = new FlowBlock();
            f.canOverflow = false;
            f.Size = new Size(200, 100);
            f.Location = new Point(100, 200);
            f.ChartText = "Ну почему опять все не работает!!!!";
            this.Controls.Add(f);

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YEEES!");
        }
    }
}
