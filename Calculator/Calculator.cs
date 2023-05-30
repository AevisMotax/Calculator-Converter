using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //Declare some variables
        private double total = 0;
        private String calculation_Text = "";
        private Transfer t1 = new Transfer();


        public Calculator()
        {
            InitializeComponent();
        }

        //Crerate a class for button click
        private void button_click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Times New Roman", 12);
            //Access many event handlers of the same type
            //  Button btn = sender as  Button;
            calculation_Text += (sender as Button).Text.ToString();
           // total = Double.TryParse(calculation_Text, out total); 
            calculation_Text = calculation_Text.Replace("X", "*");

            richTextBox1.Text = calculation_Text;

        }

  

        //class to calculate things.
        private void button_calculation(object sender, EventArgs e) 
        {
            String sCalculation = calculation_Text;
            richTextBox1.Text = "";
        }

        //Loading the form, along with other aspects
        private void Calculator_Load(object sender, EventArgs e)
        {
           
            //Do it on the calculator form, it changes better>>>>> Modifying specs for the textBox
            richTextBox1.BackColor = Color.Cyan;
            richTextBox1.Text = "0";
            richTextBox1.ReadOnly = true;

            //For the Currency Converter
            string[] installs = { "Canadian", "US", "Japanese Yen", "South Korean Won" };
            comboBox1.SelectedItem = "Options:";
            comboBox1.BackColor = Color.Orange; comboBox2.BackColor = Color.Magenta;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < installs.Length; i++)
            {
                comboBox1.Items.Add(installs[i]); comboBox2.Items.Add(installs[i]);
            }

            //For the date
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 50);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
        }

        //Fun addition, the time
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            //No need for this right now
            // RichTextBox rBox = new RichTextBox();
          //  richTextBox1.Font = new Font("Times New Roman", 12);
          //  richTextBox1.Text = text;
            //Avoids user to edit
            richTextBox1.ReadOnly = true;

        }


        private void panel1_Paint(object sender , EventArgs e)
        {

        }


        //Assign values 
        private void One_Click(object sender, EventArgs e)
        {
            //One_Click.CLick -= One_Click;
            One.Click -= One_Click;
            One.Click += new EventHandler(button_click);

        }

        private void Two_Click(object sender, EventArgs e)
        {
            Two.Click -= Two_Click;
            Two.Click += new EventHandler(button_click);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Three.Click -= Three_Click;
            Three.Click += new EventHandler(button_click);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Four.Click -= Four_Click;
            Four.Click += new EventHandler(button_click);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Five.Click -= Five_Click;
            Five.Click += new EventHandler(button_click);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Six.Click -= Six_Click;
            Six.Click += new EventHandler(button_click);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            seven.Click -= seven_Click;
            seven.Click += new EventHandler(button_click);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Eight.Click -= Eight_Click;
            Eight.Click += new EventHandler(button_click);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Nine.Click -= Nine_Click;
            Nine.Click += new EventHandler(button_click);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Zero.Click -= Zero_Click;
            Zero.Click += new EventHandler(button_click);
        }

        //Multiply class
        private void Multiply_Click(object sender, EventArgs e)
        {
            Multiply.Click += new EventHandler(button_click);
        }

        private void Exponent_Click(object sender, EventArgs e)
        {
            //Must change
            String s = "";
            MessageBox.Show("", "Enter a number");

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Divide.Click += new EventHandler(button_click);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Plus.Click += new EventHandler(button_click);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Minus.Click += new EventHandler(button_click);
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            Decimal.Click += new EventHandler(button_click);
        } 

        


        //Reference used to remove everything
        private void Clear_Click(object sender, EventArgs e)
        {
            calculation_Text = "";
            richTextBox1.Text = "0";
            total = 0;
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            if (calculation_Text.Length > 0)
            {
                calculation_Text = calculation_Text.Remove(calculation_Text.Length -1, 1);
                richTextBox1.Text = calculation_Text.Trim();
            }
            else
            {
                String message = "There is nothing on the screen";
                String Title = "Oups?";
                MessageBox.Show(message , Title);
            }
        }

        //Display results
        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = new DataTable().Compute(calculation_Text, null).ToString();
                calculation_Text = richTextBox1.Text;
            }
            catch (Exception e1)
            {
                richTextBox1.Text = "0";
                calculation_Text = "";
                MessageBox.Show("There is an error, please retry");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = "";
            double temp2 = 0;
            if (comboBox1.SelectedIndex > -1 && Double.TryParse(richTextBox1.Text, out temp2))
            {
                temp = comboBox1.SelectedItem.ToString();
            }
            else
            {
                Environment.Exit(0);
            }
            //Invoke method
            Convert(temp, temp2);

        }

        public void Convert(String X1, Double X2)
        {
            if (X1.ToLower().Equals("us"))
            {
                t1.setAmerica(X2);
                t1.fromAmerica();
            }
            else if (X1.ToLower().Equals("canadian"))
            {
                t1.setCanada(X2);
                t1.fromCanada();
            }
            else if (X1.ToLower().Equals("japanese yen"))
            {
                t1.setYen(X2);
                t1.fromJapan();
            }
            else if (X1.ToLower().Equals("south korean won"))
            {
                t1.setWon(X2);
                t1.fromKorea();
            }
            else
            {
                MessageBox.Show("ERROR NON AVAILABLE ");
                Environment.Exit(0);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String X1 = "";
            if (comboBox2.SelectedIndex > -1)
            {
                X1 = comboBox2.SelectedItem.ToString();
            }
            else
            {
                Environment.Exit(0);
            }

            if (X1.ToLower().Equals("us"))
            {
                richTextBox2.Text = t1.getAmerica() + " US";
            }
            else if (X1.ToLower().Equals("canadian"))
            {
                richTextBox2.Text = t1.getCanada() + " CAD";
            }
            else if (X1.ToLower().Equals("japanese yen"))
            {
                richTextBox2.Text = t1.getYen() + " Yen";
            }
            else if (X1.ToLower().Equals("south korean won"))
            {
                richTextBox2.Text = t1.getWon() + " Won";
            }
            else
            {
                MessageBox.Show("ERROR NON AVAILABLE ");
                Environment.Exit(0);
            }
        }
    }
}
