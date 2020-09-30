using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;

namespace SayısalAnaliz
{
    public partial class NewtonRaphson : Form
    {
        double[] XValuesArray;
        double[] EValuesArray;
        int xCounter = 0;
        int eCounter = 0;

        public NewtonRaphson()
        {
            InitializeComponent();
        }

        private void NewtonRaphson_Load(object sender, EventArgs e)
        {

        }

        public double function(double p0)
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
            return result;
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

        public double function2(double p0)
        {
            double result = 0.0;

            for (int i = 0; i < XValuesArray.Length; i += 2)
            {
                double result2 = XValuesArray[i] * XValuesArray[i + 1] * (XValuesArray[i + 1] - 1) * Math.Pow(p0, XValuesArray[i + 1] - 2);
                if (!Double.IsNaN(result2))
                    result += result2;
                else
                    break;
            }

            for (int i = 0; i < EValuesArray.Length; i += 2)
            {
                double result2 = EValuesArray[i] * EValuesArray[i + 1] * EValuesArray[i + 1] * Math.Exp(p0 * EValuesArray[i + 1]);
                if (!Double.IsNaN(result2))
                    result += result2;
                else
                    break;
            }

            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool durum = false;
            double nmax, p0, p;
            int i = 1;
            nmax = Convert.ToDouble(txtNMax.Text);
            p0 = Convert.ToDouble(txtPStart.Text);

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

            while (i <= nmax)
            {
                p = p0 - function1(p0) / function2(p0);
                p0 = p;
                listBox1.Items.Add(String.Format("X{0} değeri:{1}", i, Math.Round(p0, 4)));
                i = i + 1;
            }

            if (durum == false)
            {
                MessageBox.Show(String.Format("İşlem sonucu {0}.", Math.Round(p0, 3)));
                xCounter = 0;
                eCounter = 0;
                txtNMax.Text = "";
                txtE.Text = "";
                txtPStart.Text = "";
                txtX.Text = "";
            }
        }
    }
}
