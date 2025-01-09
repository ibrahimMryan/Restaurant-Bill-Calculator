using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double GetPrice(string item)
        {
            
            switch (item)
            {
                
                case "Soda": return 1.95;
                case "Tea": return 1.50;
                case "Coffee": return 1.25;
                case "Mineral Water": return 2.95;
                case "Juice": return 2.50;
                case "Milk": return 1.50;

              
                case "Buffalo Wings": return 5.95;
                case "Buffalo Fingers": return 6.95;
                case "Potato Skins": return 8.95;
                case "Nachos": return 8.95;
                case "Mushroom Caps": return 10.95;
                case "Shrimp Cocktail": return 12.95;
                case "Chips and Salsa": return 6.95;

                
                case "Chicken Alfredo": return 13.95;
                case "Chicken Picatta": return 13.95;
                case "Turkey Club": return 11.95;
                case "Lobster Pie": return 19.95;
                case "Prime Rib": return 20.95;
                case "Shrimp Scampi": return 18.95;
                case "Turkey Dinner": return 13.95;
                case "Stuffed Chicken": return 14.95;

                
                case "Apple Pie": return 5.95;
                case "Sundae": return 3.95;
                case "Carrot Cake": return 5.95;
                case "Mud Pie": return 4.95;
                case "Apple Crisp": return 5.95;

                default: return 0.0; 
            }
        }


        private void UpdateBill()
        {
            double subtotal = 0;

           
            if (comboBox_Beverage.SelectedItem != null)
                subtotal += GetPrice(comboBox_Beverage.SelectedItem.ToString());
            if (comboBox_Appetizer.SelectedItem != null)
                subtotal += GetPrice(comboBox_Appetizer.SelectedItem.ToString());
            if (comboBox_MainCourse.SelectedItem != null)
                subtotal += GetPrice(comboBox_MainCourse.SelectedItem.ToString());
            if (comboBox_Dessert.SelectedItem != null)
                subtotal += GetPrice(comboBox_Dessert.SelectedItem.ToString());


            double tax = subtotal * 0.16;
            double total = subtotal + tax;

           
            textBox_Subtotal.Text = subtotal.ToString("F2");
            textBox_Tax.Text = tax.ToString("F2");
            textBox_Total.Text = total.ToString("F2");
        }


        private void ClearBill()
        {
           
            comboBox_Beverage.SelectedItem = null;
            comboBox_Appetizer.SelectedItem = null;
            comboBox_MainCourse.SelectedItem = null;
            comboBox_Dessert.SelectedItem = null;

            textBox_Subtotal.Text = "0.00";
            textBox_Tax.Text = "0.00";
            textBox_Total.Text = "0.00";
        }

        private void comboBox_Beverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void comboBox_Appetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void comboBox_MainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void comboBox_Dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void btn_ClearBill_Click(object sender, EventArgs e)
        {
            ClearBill();
        }
    }
}
