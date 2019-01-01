using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChart
{
   public static class FlowChartStyle
    {
        public  delegate void StyleChanged();
        public static event StyleChanged OnStyleChanged;


        private static Font _font = new Font("Century Gothic", 12.0F);
        public static Font FCFont
        {
            get
            {
                return _font;
            }
            set
            {
                _font = value;
                OnStyleChanged?.Invoke();
            }
        }

        public static Color FCBackColor
        {
            get
            {
                return Color.White;
            }
        }

        public static Color FCBorderColor
        {
            get
            {
                return Color.Black;
            }
        }

        public static float MINIMUM_WIDTH = 1.2F;
        public static float STEP_WIDTH = 0.6F;

        public static float BorderWidth
        {
            get
            {
                return MINIMUM_WIDTH + (int)(FCBorderWidth) * STEP_WIDTH;
            }
        }
       
        public  enum ChartBorderWidth 
        {
            TINY_WIDTH,
            SMALL_WIDTH,
            MEDIUM_WIDTH,
            NORMALL_WIDTH,
            LARGE_WIDTH,
            XLARGE_WIDTH,
        }
        public static ChartBorderWidth _chartWidth = ChartBorderWidth.NORMALL_WIDTH;
        public static ChartBorderWidth FCBorderWidth
        {
            get
            {
                return _chartWidth;
            }
            set
            {
                _chartWidth = value;
                OnStyleChanged?.Invoke();
            }
        }

    }
}
