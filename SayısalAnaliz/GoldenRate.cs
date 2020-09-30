using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalAnaliz
{
    public partial class GoldenRate : Form
    {
        public GoldenRate()
        {
            InitializeComponent();
        }

        const double r = 0.618;
        double[] XValuesArray;
        double[] EValuesArray;
        int xCounter = 0;
        int eCounter = 0;
        double sabit;
        double function(double p0)
        {
            double result = 0.0;

            for (int i = 0; i < XValuesArray.Length; i += 2)
            {
                double result2 = XValuesArray[i] * Math.Pow(p0, XValuesArray[i + 1]);
                if (!Double.IsNaN(result2))
                    result += result2;
                else
                    break;
            }

            for (int i = 0; i < EValuesArray.Length; i += 2)
            {
                double result2 = EValuesArray[i] * Math.Exp(p0 * EValuesArray[i + 1]);
                if (!Double.IsNaN(result2))
                    result += result2;
                else
                    break;
            }
            return result + sabit;
        }

        double calculateIteration(double tolerance, double a, double b)
        {
            double result = Math.Log10(tolerance / (b + a * -1)) / Math.Log10(r);
            return Math.Ceiling(result);
        }

        double calculateNewPointX1(double a, double b)
        {
            double x1 = b - r * (b - a);
            return x1;
        }
        double calculateNewPointX2(double a, double b)
        {
            double x2 = a + r * (b - a);
            return x2;
        }
        private void GoldenRate_Load(object sender, EventArgs e)
        {
            txtX.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b, tolerace, x1, x2;
            if (!String.IsNullOrEmpty(txtSabit.Text))
            {
                sabit = Convert.ToDouble(txtSabit.Text);
            }
            else
                sabit = 0;
            a = Convert.ToDouble(txtAPoint.Text);
            b = Convert.ToDouble(txtBPoint.Text);
            tolerace = Convert.ToDouble(txtTolerance.Text);
            string XValues = txtX.Text;
            string[] XParts = XValues.Split(';');
            string EValues = txtE.Text;
            string[] EParts = EValues.Split(';');
            Array.Resize(ref XValuesArray, XParts.Length * 2);
            Array.Resize(ref EValuesArray, EParts.Length * 2);

            if (EValues.Length > 0)
            {
                foreach (var item in EParts)
                {
                    string[] XPartValues = item.Split('_');
                    EValuesArray[eCounter++] = Convert.ToDouble(XPartValues[0]);
                    EValuesArray[eCounter++] = Convert.ToDouble(XPartValues[1]);
                }
            }
            if (XValues.Length > 0)
            {
                foreach (var item in XParts)
                {
                    string[] XPartValues = item.Split('_');
                    XValuesArray[xCounter++] = Convert.ToDouble(XPartValues[0]);
                    XValuesArray[xCounter++] = Convert.ToDouble(XPartValues[1]);
                }
            }

            double iteration = calculateIteration(tolerace, a, b);
            for (int i = 0; i <= iteration; i++)
            {
                listBox1.Items.Add(String.Format("{0}. İterasyon: [{1},{2}] aralığı", i, Math.Round(a, 4), Math.Round(b, 4)));
                x1 = calculateNewPointX1(a, b);
                x2 = calculateNewPointX2(a, b);
                if (rdb1.Checked)
                {
                    if (function(x1) > function(x2))
                        b = x2;
                    else
                        a = x1;
                }
                else
                {
                    if (function(x1) > function(x2))
                        a = x1;
                    else
                        b = x2;
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSabit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
