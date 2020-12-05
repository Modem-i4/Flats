using Flats.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Flats
{
    public partial class ChartForm : Form
    {
        public ChartForm(Model model)
        {
            InitializeComponent();
            chart1.Titles.Add(model.Name);
            var prop = typeof(Model).GetProperties();
            for (int i = 3; i < 24; i++)
            {
                var ser = new Series(prop[i].Name);
                ser.Points.AddXY(i, typeof(Model).GetProperty(prop[i].Name).GetValue(model));
                ser.Label = prop[i].Name;
                ser.SmartLabelStyle.MovingDirection = (LabelAlignmentStyles.Bottom|LabelAlignmentStyles.Top);
                chart1.Series.Add(ser);
            }
        }
    }
}
