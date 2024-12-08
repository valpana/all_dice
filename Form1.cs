using System;

using System.Windows.Forms;

namespace AllDice
{
    public partial class AllDice : Form
    {
        Random rand = new Random();
        public AllDice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            total4.Text = "";
            total6.Text = "";
            total8.Text = "";
            total10.Text = "";
            total12.Text = "";
            total20.Text = "";
            totalAll.Text = "";
            txtTotal.Text = "";
            totalD100.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void roll_Click(object sender, EventArgs e)
        {
            total4.Text = "";
            total6.Text = "";
            total8.Text = "";
            total10.Text = "";
            total12.Text = "";
            total20.Text = "";
            totalAll.Text = "";
            txtTotal.Text = "";
            bool error = false;
            int i;  //i ir for cikla mainigais
            int totalD4 = 0, totalD6 = 0, totalD8 = 0, totalD10 = 0, totalD12 = 0, totalD20 = 0; //uzmesto vertibu sumas
            int nrD4, nrD6, nrD8, nrD10, nrD12, nrD20; //katra veida kaulinu daudzums. ievad lietotajs
            int D4roll, D6roll, D8roll, D10roll, D12roll, D20roll; //nejaushs skaitlis prieksh katra kaulina
            int allDiceTotal = 0;
            error = int.TryParse(num4.Text, out nrD4);
            error = int.TryParse(num6.Text, out nrD6);
            error = int.TryParse(num8.Text, out nrD8);
            error = int.TryParse(num10.Text, out nrD10);
            error = int.TryParse(num12.Text, out nrD12);
            error = int.TryParse(num20.Text, out nrD20);
            if (nrD4 > 0)
            {
                for (i = 0; i < nrD4; i++)
                {
                    D4roll= rand.Next(4) + 1;
                    totalD4=totalD4 + D4roll;
                }
                total4.Text = "" + totalD4;
            }
            if (nrD6 > 0)
            {
                for (i = 0; i < nrD6; i++)
                {
                    D6roll = rand.Next(6) + 1;
                    totalD6 = totalD6 + D6roll;
                }
                total6.Text = "" + totalD6;
            }
            if (nrD8 > 0)
            {
                for (i = 0; i < nrD8; i++)
                {
                    D8roll = rand.Next(8) + 1;
                    totalD8 = totalD8 + D8roll;
                }
                total8.Text = "" + totalD8;
            }
            if (nrD10 > 0)
            {
                for (i = 0; i < nrD10; i++)
                {
                    D10roll = rand.Next(10) + 1;
                    totalD10 = totalD10 + D10roll;
                }
                total10.Text = "" + totalD10;
            }
            if (nrD12 > 0)
            {
                for (i = 0; i < nrD12; i++)
                {
                    D12roll = rand.Next(12) + 1;
                    totalD12 = totalD12 + D12roll;
                }
                total12.Text = "" + totalD12;
            }
            if (nrD20 > 0)
            {
                for (i = 0; i < nrD20; i++)
                {
                    D20roll = rand.Next(20) + 1;
                    totalD20 = totalD20 + D20roll;
                }
                total20.Text = "" + totalD20;
            }
            if (nrD4 != 0 || nrD6 != 0 || nrD8 != 0 || nrD10 != 0 || nrD12 != 0 || nrD20 != 0) { 
                allDiceTotal = totalD4 + totalD6 + totalD8 + totalD10 + totalD12 + totalD20;
                totalAll.Text = "" + allDiceTotal;
                txtTotal.Text = "TOTAL:";
            }
            
        }

        private void total6_Click(object sender, EventArgs e)
        {

        }

        private void total4_Click(object sender, EventArgs e)
        {

        }

        private void total8_Click(object sender, EventArgs e)
        {

        }

        private void total20_Click(object sender, EventArgs e)
        {

        }

        private void total12_Click(object sender, EventArgs e)
        {

        }

        private void total10_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            total4.Text = "";
            total6.Text = "";
            total8.Text = "";
            total10.Text = "";
            total12.Text = "";
            total20.Text = "";
            totalAll.Text = "";
            txtTotal.Text = "";
            totalD100.Text = "";
            num4.Value = 0;
            num6.Value = 0;
            num8.Value = 0;
            num10.Value = 0;
            num12.Value = 0;
            num20.Value = 0;
        }

        private void info_Click(object sender, EventArgs e)
        {
            info instructions = new info();
            instructions.Show();
        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void totalAll_Click(object sender, EventArgs e)
        {

        }

        private void num20_ValueChanged(object sender, EventArgs e)
        {

        }

        private void num12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void num10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void num8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void num6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void num4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void D20_Click(object sender, EventArgs e)
        {

        }

        private void D12_Click(object sender, EventArgs e)
        {

        }

        private void D8_Click(object sender, EventArgs e)
        {

        }

        private void D6_Click(object sender, EventArgs e)
        {

        }

        private void D4_Click(object sender, EventArgs e)
        {

        }

        private void D100roll_Click(object sender, EventArgs e)
        {
            totalD100.Text = "";
            int d100;
            d100 = rand.Next(100) + 1;
            totalD100.Text = d100 + "%";
                }
    }
}
