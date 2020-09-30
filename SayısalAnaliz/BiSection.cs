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
    public partial class BiSection : Form
    {
        public BiSection()
        {
            InitializeComponent();
        }
        public double function1(double p0)
        {
            double result = 0.0;

            for (int i = 0; i < XValuesArray.Length; i += 2)
            {
                double result2 = XValuesArray[i] * XValuesArray[i + 1] * Math.Pow(p0, XValuesArray[i + 1] - 1);
                if (!Double.IsNaN(result2))
                    result += result2;
                else
                    break;
            }

            for (int i = 0; i < EValuesArray.Length; i += 2)
            {
                double result2 = EValuesArray[i] * EValuesArray[i + 1] * Math.Exp(p0 * EValuesArray[i + 1]);
                if (!Double.IsNaN(result2))
                    result += result2;
                else
                    break;
            }


            return result;
        }

        private void BiSection_Load(object sender, EventArgs e)
        {

        }

        double[] XValuesArray;
        double[] EValuesArray;
        int xCounter = 0;
        int eCounter = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b, x1, x2, x0f, x0, toleransVal,tolerans;
            a = Convert.ToDouble(txtRootStart.Text);
            b = Convert.ToDouble(txtRootFinish.Text);
            tolerans = Convert.ToDouble(txtTolerance.Text);

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

            do
            {
                toleransVal = b - a;
                if (toleransVal > tolerans)
                {
                    listBox1.Items.Add(String.Format("[{0},{1}] aralığı {2} birim uzaklık", Math.Round(a,4),Math.Round(b,4), Math.Round( toleransVal,4)));

                    x1 = function1(a);
                    x2 = function1(b);

                    x0 = (a + b) / 2;
                    x0f = function1(x0);
                    if (x1 * x0f < 0)
                    {
                        b = x0;
                    }
                    else
                    {
                        a = x0;
                    }
                }
                else
                    break;
            } while (toleransVal > tolerans);

            xCounter = 0;
            eCounter = 0;
            txtRootFinish.Text = "";
            txtE.Text = "";
            txtRootStart.Text = "";
            txtTolerance.Text = "";
            txtX.Text = "";
        }
    }
}
