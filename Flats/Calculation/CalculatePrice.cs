using Flats.Calculation;
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
    public partial class CalculatePrice : Form
    {
        private Model model;
        public CalculatePrice(Model model, Flat template)
        {
            InitializeComponent();
            this.model = model;

            var prop = typeof(Flat).GetProperties();
            for (int i = 3; i < prop.Length; i++)
            {
                tableFactors.RowCount++;
                tableFactors.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
                tableFactors.Controls.Add(new Label() { Text = prop[i].Name, TextAlign = ContentAlignment.MiddleCenter }, 0, tableFactors.RowCount-1);
                Control control;
                if (prop[i].PropertyType == typeof(int))
                {
                    control = new CalcNumUpDown() { Param = prop[i].Name, Maximum = int.MaxValue, Value = (int)prop[i].GetValue(template) };
                }
                else
                {
                    CalcComboBox cBox = new CalcComboBox() { Param = prop[i].Name };
                    foreach (object element in prop[i].PropertyType.GetEnumValues())
                    {
                        cBox.Items.Add(element);
                    }
                    cBox.SelectedItem = prop[i].GetValue(template);
                    control = cBox;
                }
                tableFactors.Controls.Add(control, 1, tableFactors.RowCount - 1);
            }
            CalcPriceText();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
            => CalcPriceText();
        private void CalcPriceText()
        {
            double price = model.Constant;
            foreach (var control in tableFactors.Controls)
            {
                if (control is CalcNumUpDown)
                {
                    CalcNumUpDown field = control as CalcNumUpDown;
                    if (field.Value != 0)
                        price += (double)field.Value * GetParamByName(field.Param);
                }
                else if (control is CalcComboBox)
                {
                    CalcComboBox field = control as CalcComboBox;
                    if (field.SelectedIndex != -1)
                        price += (int)field.SelectedItem * GetParamByName(field.Param);
                }
            }
            labelPrice.Text = $"Price: {price:0}$";
        }
        private double GetParamByName(string name)
        {
            return (double)typeof(Model).GetProperty(name).GetValue(model);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            foreach (Control control in tableFactors.Controls)
            {
                if (control is CalcNumUpDown)
                {
                    (control as CalcNumUpDown).Value = 0;
                }
                else if(control is CalcComboBox)
                {
                    (control as CalcComboBox).SelectedItem = null;
                }
            }
        }
    }
}
