using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace OrderWinForm
{
    
    public partial class Form1 : Form
    {
        double sum;
        int number;
        DateTime dt;
        StringBuilder str = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            sum = 0;
            number = new Random().Next(1,100000);
            dt = DateTime.Now;
        }
        private bool isDrinks()
        {
            if (cocacolaRB.Checked || pepsiRB.Checked || juiceRB.Checked || teaRB.Checked || beerRB.Checked)
            {
                if (cocacolaRB.Checked)
                {
                    sum += 0.50;
                    str.Append($"\nCoca Cola  {0.50}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (pepsiRB.Checked)
                {
                    sum += 0.50;
                    str.Append($"\nPepsi  {0.50}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (juiceRB.Checked)
                {
                    sum += 1;
                    str.Append($"\nFruit Juice  {1}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (teaRB.Checked)
                {
                    sum += 1.5;
                    str.Append($"\nTea  {1.5}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (beerRB.Checked)
                {
                    sum += 3;
                    str.Append($"\nBeer  {3}$,  Date: {dt},  Number: {number}\n\n");
                }
                return true;
            }
            return false;
        }
        private bool isCourses()
        {
            if (FriedEggsRB.Checked || PorridgeRB.Checked || MeatRB.Checked || PotatoRB.Checked || vegetablesRB.Checked)
            {
                if (FriedEggsRB.Checked)
                {
                    sum += 2;
                    str.Append($"\nFried eggs  {2}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (PorridgeRB.Checked)
                {
                    sum += 3;
                    str.Append($"\nPorridge  {3}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (MeatRB.Checked)
                {
                    sum += 8;
                    str.Append($"\nMeat with sendwiches  {8}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (PotatoRB.Checked)
                {
                    sum += 2;
                    str.Append($"\nFried Potato  {2}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (vegetablesRB.Checked)
                {
                    sum += 6;
                    str.Append($"\nFried vegetables  {6}$,  Date: {dt},  Number: {number}\n\n");
                }
                return true;
            }
            return false;
        }
        private bool isDeserts()
        {

            if (chocCakeRB.Checked || iceCream.Checked || donatRB.Checked || cheeseRB.Checked || zefirRB.Checked)
            {
                if (chocCakeRB.Checked)
                {
                    sum += 3;
                    str.Append($"\nChocolate Cake  {3}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (iceCream.Checked)
                {
                    sum += 2;
                    str.Append($"\nIce Cream  {2}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (donatRB.Checked)
                {
                    sum += 2;
                    str.Append($"\nDonat  {2}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (cheeseRB.Checked)
                {
                    sum += 4;
                    str.Append($"\nCheese Cake  {4}$,  Date: {dt},  Number: {number}\n\n");
                }
                if (zefirRB.Checked)
                {
                    sum += 1;
                    str.Append($"\nZefir {1}$,  Date: {dt},  Number: {number}\n\n");
                }
                return true;
            }
            return false;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            if (isDrinks()&&isDeserts()&&isCourses())
            {
                showBox.Text = str.ToString() ;
                MessageBox.Show("Sum: " + sum.ToString(), "Date: " + dt + "   Number: " + number, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
