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

namespace Flats
{
    public partial class ChartForm : Form
    {
        public ChartForm(Model model)
        {
            InitializeComponent();
            chart1.Titles.Add(model.Name);
            var prop = typeof(Model).GetProperties();//.Where(o => o.GetType().Name == "double").Select(q => q.).ToArray();
            for (int i = 3; i < prop.Length; i++)
            {
                chart1.Series.Add(prop[i].Name);
                chart1.Series.Last().Points.AddXY(i, typeof(Model).GetProperty(prop[i].Name).GetValue(model));
            }
        }
    }
}
