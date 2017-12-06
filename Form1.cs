using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }




        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;



            }//end switch
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
        }

        public delegate void KeyEventHandler(
    object sender,
    KeyEventArgs e
);
        private bool nonNumberEntered = true;

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {


                
                            // Determine whether the keystroke is a backspace.
                            if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;

                        equation.Text = "";
                        switch (operation)
                        {
                            case "+":
                                result.Text = (value + double.Parse(result.Text)).ToString();
                                break;
                            case "-":
                                result.Text = (value - double.Parse(result.Text)).ToString();
                                break;
                            case "*":
                                result.Text = (value * double.Parse(result.Text)).ToString();
                                break;
                            case "/":
                                result.Text = (value / double.Parse(result.Text)).ToString();
                                break;
                            default:
                                break;

                    }



                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                if (Control.ModifierKeys == Keys.Add)
                    result.Text = (value + double.Parse(result.Text)).ToString();
                if (Control.ModifierKeys == Keys.Subtract)
                    result.Text = (value - double.Parse(result.Text)).ToString();
                if (Control.ModifierKeys == Keys.Multiply)
                    result.Text = (value * double.Parse(result.Text)).ToString();
                if (Control.ModifierKeys == Keys.Divide)
                    result.Text = (value / double.Parse(result.Text)).ToString();


                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            equation.Text = "";
            switch (operation)

            {

                case "+":
                                result.Text = (value + Single.Parse(result.Text)).ToString();
                                break;
                            case "-":
                                result.Text = (value - double.Parse(result.Text)).ToString();
                                break;
                            case "*":
                                result.Text = (value * double.Parse(result.Text)).ToString();
                                break;
                            case "/":
                                result.Text = (value / double.Parse(result.Text)).ToString();
                                break;
                            default:
                                break;

            }
            }

        private void button9_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
