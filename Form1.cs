using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintJobEstimator
{
    public partial class Form1 : Form
    {/* for every 115 sqft  1 gallon and 8 hours of labor is required  charges 20 dollors an hour*/
        public static Decimal decGallOut;
        public static Decimal decLabOut;
        public static Decimal decCostOut;
        public static Decimal decPaintOut;
        public static Decimal decTotalOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String strOutput;
            Gallons();
            LabHours();
            CostofPaint();
            Charges();
            Total();
            lblOutput.Text = "Number of gallons:" + decGallOut.ToString("n2") + Environment.NewLine +
                "Hours of Labor:" + decLabOut.ToString("n2") + Environment.NewLine +
                "Cost of Paint:" + decPaintOut.ToString("C") + Environment.NewLine +
                "Labor Charges:" + decCostOut.ToString("C") + Environment.NewLine +
                "Total Cost:" + decTotalOut.ToString("C");
            
             

        }
        public Decimal Gallons()
        {
            Decimal decSqft;
            decSqft = Convert.ToDecimal(txtSqFt.Text);
            decGallOut = decSqft / 115;
            return decGallOut;
        }
        public Decimal LabHours()
        {
            Decimal decSqFt;
            decSqFt = Convert.ToDecimal(txtSqFt.Text);
            decLabOut = (decSqFt / 115) * 8;
            return decLabOut;
        }
        public Decimal CostofPaint()
        {
            Decimal decSqft, decCost;
            decCost = Convert.ToDecimal(txtGallon.Text);
            decSqft = Convert.ToDecimal(txtSqFt.Text);
            decPaintOut = (decSqft / 115) * decCost;
            return decPaintOut;
        }
        public Decimal Charges()
        {
            Decimal decSqFt;
            decSqFt = Convert.ToDecimal(txtSqFt.Text);
            decCostOut = ((decSqFt / 115) * 8) * 20;
            return decCostOut;
        }
        public Decimal Total()
        {
            
            decTotalOut = decPaintOut + decCostOut;
            return decTotalOut;
        }
    }
}
