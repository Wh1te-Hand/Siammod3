using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siammod3
{
    public partial class Form1 : Form
    {
        private long p1, p2, number_tacts;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            String line = "";
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            String line = "";
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_p2_KeyUp(object sender, KeyEventArgs e)
        {
            long N_number;
            String line = "";
            line = this.textBox_p2.Text; //changed
            if (line != "")
            {
                N_number = long.Parse(line);
                if (N_number > 0 && N_number != double.NaN)
                {
                    p2 = N_number;//
                }
            }
            else
            {
                p2 = 0; //
            }
        }

        private void textBox_numberTacts_KeyUp(object sender, KeyEventArgs e)
        {
            long N_number;
            String line = "";
            line = this.textBox_numberTacts.Text; //changed
            if (line != "")
            {
                N_number = long.Parse(line);
                if (N_number > 0 && N_number != double.NaN)
                {
                    number_tacts = N_number;//
                }
            }
            else
            {
                number_tacts = 0; //
            }
        }


        private void textBox_numberTacts_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            String line = "";
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_p1_KeyUp(object sender, KeyEventArgs e)
        {
            long N_number;
            String line = "";
            line = this.textBox_p1.Text; //changed
            if (line != "")
            {
                N_number = long.Parse(line);
                if (N_number > 0 && N_number != double.NaN)
                {
                    p1 = N_number;//
                }
            }
            else
            {
               p1=0; //
            }
        }
    }
}
