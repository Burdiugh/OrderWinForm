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
        StringBuilder str = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            sum = 0;
            number = new Random().Next(1,100000);
           
        }
        private bool isOrderDrinks()
        {
            if (cocacolaRB.Checked || pepsiRB.Checked || juiceRB.Checked || teaRB.Checked || beerRB.Checked)
            {
                if (cocacolaRB.Checked)
                {
                    sum += 0.50;
                    str.Append($"{Environment.NewLine}Coca Cola  {0.50}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}") ;
                }
                if (pepsiRB.Checked)
                {
                    sum += 0.50;
                    str.Append($"{Environment.NewLine}Pepsi  {0.50}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (juiceRB.Checked)
                {
                    sum += 1;
                    str.Append($"{Environment.NewLine}Fruit Juice  {1}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (teaRB.Checked)
                {
                    sum += 1.5;
                    str.Append($"{Environment.NewLine}Tea  {1.5}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (beerRB.Checked)
                {
                    sum += 3;
                    str.Append($"{Environment.NewLine}Beer  {3}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                return true;
            }
            return false;
        }
        private bool isOrderCourses()
        {
            if (FriedEggsRB.Checked || PorridgeRB.Checked || MeatRB.Checked || PotatoRB.Checked || vegetablesRB.Checked)
            {
                if (FriedEggsRB.Checked)
                {
                    sum += 2;
                    str.Append($"{Environment.NewLine}Fried eggs  {2}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (PorridgeRB.Checked)
                {
                    sum += 3;
                    str.Append($"{Environment.NewLine}Porridge  {3}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (MeatRB.Checked)
                {
                    sum += 8;
                    str.Append($"{Environment.NewLine}Meat with sendwiches  {8}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (PotatoRB.Checked)
                {
                    sum += 2;
                    str.Append($"{Environment.NewLine}Fried Potato  {2}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (vegetablesRB.Checked)
                {
                    sum += 6;
                    str.Append($"{Environment.NewLine}Fried vegetables  {6}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                return true;
            }
            return false;
        }
        private bool isOrderDeserts()
        {

            if (chocCakeRB.Checked || iceCream.Checked || donatRB.Checked || cheeseRB.Checked || zefirRB.Checked)
            {
                if (chocCakeRB.Checked)
                {
                    sum += 3;
                    str.Append($"{Environment.NewLine}Chocolate Cake  {3}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (iceCream.Checked)
                {
                    sum += 2;
                    str.Append($"{Environment.NewLine}Ice Cream  {2}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (donatRB.Checked)
                {
                    sum += 2;
                    str.Append($"{Environment.NewLine}Donat  {2}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (cheeseRB.Checked)
                {
                    sum += 4;
                    str.Append($"{Environment.NewLine}Cheese Cake  {4}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                if (zefirRB.Checked)
                {
                    sum += 1;
                    str.Append($"{Environment.NewLine}Zefir {1}$,  Date: {DateTime.Now},  Number: {number}{Environment.NewLine}");
                }
                return true;
            }
            return false;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            if (isOrderDrinks()&& isOrderDeserts()&& isOrderCourses())
            { 
                showBox.Text = str.ToString();
                MessageBox.Show("Sum: " + sum.ToString()+"$", "Date: " + DateTime.Now + "   Number: " + number, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
