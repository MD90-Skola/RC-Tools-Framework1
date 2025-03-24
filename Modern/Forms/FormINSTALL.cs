using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern.Forms
{
    public partial class formInstall: Form
    {
        public formInstall()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormINSTALL_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notion://");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte öppna Notion: " + ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Öppnar PowerToys i Microsoft Store
                System.Diagnostics.Process.Start("ms-windows-store://pdp/?productid=XP89DCGQ3K6VLD");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte öppna Microsoft Store: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Öppnar ChatGPT i Microsoft Store
                System.Diagnostics.Process.Start("ms-windows-store://pdp/?productid=9NH7FJ33R6MG");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte öppna Microsoft Store: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Öppnar Spotify i Microsoft Store
                System.Diagnostics.Process.Start("ms-windows-store://pdp/?productid=9NCBCSZSJRSB");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte öppna Microsoft Store: " + ex.Message);
            }
        }
    }
}
