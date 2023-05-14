using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_DZ_3
{
    public partial class Form1 : Form
    {
        public double[] fuelPrices = {50.0, 53.0, 55.0, 58.0, 30.0};
        public double totalMoneyPerDay;
        public Form1()
        {
            InitializeComponent();
            toolStripMenuItem2.Text = DateTime.Now.DayOfWeek.ToString();
            label_TotalToPayMarket.Text = CalcMarketPay().ToString();
            label_TotalPayForFuel.Text = CalcFuelPay().ToString("N2");
        }



        private void button_TotalPaymentClalc_Click(object sender, EventArgs e)
        {
            
            label_TotalMoney.Text = (double.Parse(label_TotalPayForFuel.Text) + double.Parse(label_TotalToPayMarket.Text)).ToString();
        }

        private void comboBox_FuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox_FuelType.SelectedIndex) 
            {
                case 0:
                    textBox_FuelPrice.Text = fuelPrices[0].ToString();
                    break;
                case 1:
                    textBox_FuelPrice.Text = fuelPrices[1].ToString();
                    break;
                case 2:
                    textBox_FuelPrice.Text = fuelPrices[2].ToString();
                    break;
                case 3:
                    textBox_FuelPrice.Text = fuelPrices[3].ToString();
                    break;
                case 4:
                    textBox_FuelPrice.Text = fuelPrices[4].ToString();
                    break;
            }
            label_TotalPayForFuel.Text = CalcFuelPay().ToString("N2");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_FuelAmount.Checked)
            {
                textBox_FuelAmount.Enabled = true;
                textBox_FuelSum.Enabled = false;
                textBox_FuelAmount.Text = 10.ToString("N2");
                textBox_FuelSum.Text = string.Empty;
            }
            else if (radioButton_FuelSum.Checked)
            {
                textBox_FuelAmount.Enabled = false;
                textBox_FuelSum.Enabled = true;
                textBox_FuelSum.Text = 100.ToString("N2");
                textBox_FuelAmount.Text = string.Empty;
            }
        }
        private double CalcFuelPay()
        {
            double fuelPay = 0;
            if (radioButton_FuelAmount.Checked)
                fuelPay = double.Parse(textBox_FuelAmount.Text) * double.Parse(textBox_FuelPrice.Text);
            else if (radioButton_FuelSum.Checked)
            {
                fuelPay = double.Parse(textBox_FuelSum.Text);
                textBox_FuelAmount.Text = (fuelPay/double.Parse(textBox_FuelPrice.Text)).ToString();
            }
            return fuelPay;
        }

        private void label_TotalPayForFuel_TextChanged(object sender, EventArgs e) => label_TotalPayForFuel.Text = CalcFuelPay().ToString("N2");
        

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_FuelType.SelectedIndex = 0;
            radioButton_FuelAmount.Checked = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HotDog.Checked)
                textBox_HotDogAmount.Enabled = true;         
            else
                textBox_HotDogAmount.Enabled = false;
                
            if (checkBox_Hamburger.Checked)
                textBox_HamburgerAmount.Enabled = true;
            else
                textBox_HamburgerAmount.Enabled = false;

            if (checkBox_Frees.Checked)
                textBox_FreesAmount.Enabled = true;
            else
                textBox_FreesAmount.Enabled = false;

            if (checkBox_Cola.Checked)
                textBox_ColaAmount.Enabled = true;
            else
                textBox_ColaAmount.Enabled = false;

            label_TotalToPayMarket.Text = CalcMarketPay().ToString();
        }

        private void label_TotalToPayMarket_TextChanged(object sender, EventArgs e) => label_TotalToPayMarket.Text = CalcMarketPay().ToString();
        
        private int CalcMarketPay()
        {
           return int.Parse(textBox_ColaAmount.Text)      * int.Parse(textBox_ColaPrice.Text) +
                  int.Parse(textBox_FreesAmount.Text)     * int.Parse(textBox_FreesPrice.Text) +
                  int.Parse(textBox_HamburgerAmount.Text) * int.Parse(textBox_HamburgerPrice.Text) +
                  int.Parse(textBox_HotDogAmount.Text)    * int.Parse(textBox_HotDogPrice.Text);
        }
        bool status = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (status)
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString();
                status = false;
            }
            else
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
                status = true;
            }
            if (double.Parse(label_TotalMoney.Text) > 0)
            {
                DialogResult result = MessageBox.Show("Очитити форму?", "Запит", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    totalMoneyPerDay += double.Parse(label_TotalMoney.Text);
                    comboBox_FuelType.SelectedIndex = 0;
                    label_TotalPayForFuel.Text = "0,00";
                    label_TotalToPayMarket.Text = "0,00";
                    label_TotalMoney.Text = "0,00";
                    radioButton_FuelAmount.Checked = true;
                    checkBox_Cola.Checked = false;
                    checkBox_Frees.Checked = false;
                    checkBox_Hamburger.Checked = false;
                    checkBox_HotDog.Checked = false;
                    
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Виторг за день склав: {totalMoneyPerDay}", "Виторг");
        }
    }
}
