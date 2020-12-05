using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats.Calculation
{
    public class CalcComboBox : System.Windows.Forms.ComboBox, ICalcViews
    {
        public string Param { get; set; }
    }
}
