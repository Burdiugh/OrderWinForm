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
         int sum;
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
            
            foreach (var btn in mainCourses.Controls.OfType<RadioButton>())
            {
                if (btn.Checked)
                {
                    sum += Convert.ToInt32(btn.Tag.ToString());
                    str.Append(btn.Text+" "+" Date: "+ DateTime.Now+"  Number: "+number+Environment.NewLine + Environment.NewLine);
                    return true;
                
                }
            }
            return false;
        }
        private bool isOrderCourses()
        {
            foreach (var btn in drinks.Controls.OfType<RadioButton>())
            {
                if (btn.Checked)
                {
                    sum += Convert.ToInt32(btn.Tag.ToString());

                    str.Append(btn.Text + " " + " Date: " + DateTime.Now + "  Number: " + number + Environment.NewLine + Environment.NewLine);
                   return true;
                   
                }
            }
            return false;
        }
        private bool isOrderDeserts()
        {


            foreach (var btn in desert.Controls.OfType<RadioButton>())
            {
                if (btn.Checked)
                {
                    sum += Convert.ToInt32(btn.Tag.ToString());
                    str.Append(btn.Text + " " +" Date: " + DateTime.Now + "  Number: " + number + Environment.NewLine+Environment.NewLine);
                    return true;
                    
                }
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
