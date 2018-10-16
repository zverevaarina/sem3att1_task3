using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace att1_task3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        FarmsList f;
        List<IFarm> fList=new List<IFarm>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string n = textBoxName.Text;
                int a = Convert.ToInt32(textBoxAnimalCount.Text);
                int b = Convert.ToInt32(textBoxBalance.Text);
                string c = textBoxCity.Text;
                int s = Convert.ToInt32(textBoxSquare.Text);
                int r = Convert.ToInt32(textBoxReserve.Text);
                fList.Add(new MilkFarm(n, a, b, c, s, r));
                //string name, int animalcount, int balance, string city, int square, int reserve, int k
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!");
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxn.Text) - 1;
                MessageBox.Show(Convert.ToString(fList[n].Sell()));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!");
            }
        }



        private void buttonPayTax_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxPayTax.Text) - 1;
                MessageBox.Show(Convert.ToString(fList[n].PayTax()));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!");
            }
        }

        private void buttonBuyAnimal_Click(object sender, EventArgs e)
        {

        }

        private void buttonSellAll_Click(object sender, EventArgs e)
        {
            
        }
    }
}