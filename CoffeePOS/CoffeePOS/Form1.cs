using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePOS
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //menu

            //hot drinks
            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("Original - Hot");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cappuccino - Hot");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 60;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("Caffè Mocha - Hot");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 70;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox3.Text = "";
            }


            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("Caramel Macchiato - Hot");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 90;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox4.Text = "";
            }

            //add-on hot
            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("Add-On - Milk - Hot");
                item.SubItems.Add(textBox11.Text);
                int qty = Convert.ToInt32(textBox11.Text);
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox11.Text = "";
            }

            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("Add-On - Sugar - Iced");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("Add-On - Sugar - Hot");
                item.SubItems.Add(textBox10.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox10.Text = "";
            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("Add-On - Double double - Hot");
                item.SubItems.Add(label44.Text);
                int qty = 1;
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("Add-On - Double double - Blended");
                item.SubItems.Add(label45.Text);
                int qty = 1;
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }


            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem("Add-On - Milk - Cold");
                item.SubItems.Add(textBox9.Text);
                int qty = 1;
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox9.Text = "";
            }


            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Original");
                item.SubItems.Add(textBox8.Text);
                int qty = 1;
                double cost = qty * 60;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox8.Text = "";
            }


            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Caffè Mocha");
                item.SubItems.Add(textBox6.Text);
                int qty = 1;
                double cost = qty * 85;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox6.Text = "";
            }


            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Cappuccino");
                item.SubItems.Add(textBox7.Text);
                int qty = 1;
                double cost = qty * 70;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox7.Text = "";
            }


            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Dark Mocha - Blended");
                item.SubItems.Add(textBox16.Text);
                int qty = 1;
                double cost = qty * 100;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox16.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Java Chip - Blended");
                item.SubItems.Add(textBox15.Text);
                int qty = 1;
                double cost = qty * 120;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox15.Text = "";
            }
            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coffee Jelly - Blended");
                item.SubItems.Add(textBox13.Text);
                int qty = 1;
                double cost = qty * 120;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox13.Text = "";
            }

            //food other items
            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Glazed Donut");
                item.SubItems.Add(textBox20.Text);
                int qty = 1;
                double cost = qty * 30;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox20.Text = "";
            }

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Plain Waffles");
                item.SubItems.Add(textBox19.Text);
                int qty = 1;
                double cost = qty * 40;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox19.Text = "";
            }
            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("French Toast");
                item.SubItems.Add(textBox18.Text);
                int qty = 1;
                double cost = qty * 45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox18.Text = "";
            }

            //other drinks

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Hot Chocolate");
                item.SubItems.Add(textBox17.Text);
                int qty = 1;
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox17.Text = "";
            }

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chocolate Chip - Blended");
                item.SubItems.Add(textBox14.Text);
                int qty = 1;
                double cost = qty * 70;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }
            else
            {
                textBox14.Text = "";
            }



            //next page
            tabControl1.SelectTab("tabPage2");

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ////paano palabasin ang inheritance
            var ingredients = new Original();
            string title = "Ingredients";
            string message = checkBox1.Text + "\nCoffee: " + ingredients.coffee + "%" + "\nMilk: " + ingredients.milk + "%" + "\nSugar: " + ingredients.sugar + "%";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tabControl1.SelectTab("tabPage1");

            }

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tabControl1.SelectTab("tabPage1");
        }

        private void Label44_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            var ingredients = new Cappuccino();
            string title = "Ingredients";
            string message = checkBox2.Text + "\nCoffee: " + ingredients.coffee + "%" + "\nMilk: " + ingredients.milk + "%" + "\nSugar: " + ingredients.sugar + "%";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tabControl1.SelectTab("tabPage1");

            }
        }

        public void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox12.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox25.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox12.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox25.Enabled = false;
            double total = 0;
            double vat = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            vat = total * 0.12;
            totaldue = vat + total;

            string vatDisplay = vat.ToString("");
            //string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("");

            textBox12.Text = amount;
            textBox21.Text = vatDisplay;
            //textBox10.Text = totalDisplay;

        }

        public void Button7_Click(object sender, EventArgs e)
        {
            

            double subtotal = Convert.ToDouble(textBox12.Text);
            double vat2 = Convert.ToDouble(textBox21.Text);

            double dipatotal = 0;
            dipatotal = subtotal + vat2;

            string discountreg;
            discountreg = "0";

            textBox22.Text = discountreg;

            double regtotal;
            regtotal = dipatotal;

            string totalamt = regtotal.ToString("");
            textBox23.Text = totalamt;


        }

        private void TextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        public void Button3_Click(object sender, EventArgs e)
        {

            string money = textBox23.Text;
            double paymentDue = Convert.ToDouble(money);
            double amountPaid = Convert.ToDouble(textBox24.Text);
            double change = 0;
            change = amountPaid - paymentDue;


            textBox25.Text = change.ToString("");

            if (change < 0)
            {
                MessageBox.Show("Error! Please pay your balance.");

            }

            else
            {
                button9.Enabled = true;
            }


        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox12.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox25.Enabled = false;

            double subtotal = Convert.ToDouble(textBox12.Text);
            double vat2 = Convert.ToDouble(textBox21.Text);

            double dipatotal = 0;
            dipatotal = subtotal + vat2;

            double discountsenpwd;
            discountsenpwd = 0.2;

            double discount;
            discount  = discountsenpwd * dipatotal;
            textBox22.Text = discount.ToString();

            double dtotal = dipatotal;
            dtotal = dipatotal - discount;


            textBox23.Text = dtotal.ToString("");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button9.Enabled = false;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            var ingredients = new Caffe_Mocha();
            string title = "Ingredients";
            string message = checkBox3.Text + "\nCoffee: " + ingredients.coffee + "%" + "\nMilk: " + ingredients.milk + "%" + "\nSugar: " + ingredients.sugar + "%" + "\nCocoa Powder: " + ingredients.cocoa_powder + "%" + "\nChocolate Syrup: " + ingredients.chocolate_syrup + "%";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tabControl1.SelectTab("tabPage1");

            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            // simula dito lagyan ng inheritance hehe yun lang meron tayo sis ayusin pa pati graphics maygash so stressfull.
            //anyway, hope you're okay :)
        }
    }
}
