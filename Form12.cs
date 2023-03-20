using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void C_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "";
        }

        private void result_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string calculation = label1.Text;
                DataTable dt = new DataTable();
                double result = Convert.ToDouble(dt.Compute(calculation, ""));
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel: " + ex.Message);
            }
        }

        private void minus_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            label1.Text += button.Text;
        }
    }
}
 