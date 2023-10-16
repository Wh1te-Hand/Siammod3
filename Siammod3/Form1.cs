using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siammod3
{
    public partial class Form1 : Form
    {
        private long  number_tacts=0;
        private double p1=-1, p2=-1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            String line = "";
            if (!Char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox_p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            String line = "";
            if (!Char.IsDigit(number) && number != 8 && number !=46)
            {
                e.Handled = true;
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



        private void textBox_p2_KeyUp(object sender, KeyEventArgs e)
        {
            double N_number;
            String line = "";
            Regex reg1 = new Regex(@"0.(\d+)");
            Regex reg2 = new Regex(@"0");
            Regex reg3 = new Regex(@"1");
            line = this.textBox_p2.Text; //changed
            if (line != "" && (reg1.IsMatch(line)||reg2.IsMatch(line) || reg3.IsMatch(line)))
            {
                N_number = double.Parse(line, CultureInfo.InvariantCulture.NumberFormat);
                if (N_number != double.NaN)
                {
                    p2 = N_number;//
                  //  this.label_A.Text=N_number.ToString();
                }
            }
            else
            {
                p2 = -1; //
             //   this.label_A.Text = "-";
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

        private void textBox_p1_KeyUp(object sender, KeyEventArgs e)
        {
            double N_number;
            String line = "";
            Regex reg1 = new Regex(@"0.(\d+)");
            Regex reg2 = new Regex(@"0");
            Regex reg3 = new Regex(@"1");
            line = this.textBox_p1.Text; //changed
            if (line != ""&& (reg1.IsMatch(line) || reg2.IsMatch(line) || reg3.IsMatch(line)))
            {
                N_number = double.Parse(line, CultureInfo.InvariantCulture.NumberFormat);
                if ( N_number != double.NaN)
                {
                    p1 = N_number;//
                   // label_Q.Text=N_number.ToString();
                }
            }
            else
            {
               p1=-1; //
            }
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            if (p1 == -1 || p2 == -1|| (number_tacts==0))
            {
                MessageBox.Show(
                "Неверный формат ввода данных",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                Channel channel1 = new Channel(p1);
                Channel channel2 = new Channel(p2);
                Source source = new Source();
                Queue queue = new Queue();
                Boolean free_ch1, free_ch2;
                for (int i = 0; i < number_tacts; i++) {

                    free_ch1 = channel1.Solve();// отработка канала и его освобождение
                    free_ch2 = channel2.Solve();

                    if (queue.Tact_channel1(free_ch1)) { // начали смотреть состояние очереди до канала
                        channel1.Download();
                    }
                    if (queue.Tact_channel2(free_ch2)) {
                        channel2.Download();
                    }

                    if (source.Tact(queue.queueState)) { //источник
                    queue.Download();
                        if (queue.Tact_channel1(!channel1.Busy))
                        {
                           channel1.Download();
                        }
                        if (queue.Tact_channel2(!channel2.Busy))
                        {
                           channel2.Download();
                        }
                    }
                    source.Calculate_tacts();
                    queue.Calculate_tacts();
                    channel1.Calculate_tacts();
                    channel2.Calculate_tacts();                    
                }

                double k1=0,k2=0,A=0,Q=0,lambda=0,Preject=0,Plock=0,Lqueue=0,Lrequest=0,Wsystem=0,Wqueue=0;
                long number=0;
                k1=(double)channel1.tactsWork/(double)number_tacts;
                k2=(double)channel2.tactsWork/(double)number_tacts;
                A = ((double)channel1.numberProcessed + (double)channel2.numberProcessed) / (double)number_tacts;
                Q= ((double)channel1.numberProcessed + (double)channel2.numberProcessed) /(double)source.numberGenerated;
                Preject= (-(double)channel1.numberProcessed -(double)channel2.numberProcessed+(double)source.numberGenerated) / (double)source.numberGenerated;
                Plock = (double)source.tactsBlock / (double)number_tacts;
                number = queue.getCount();
                if (channel1.Busy)
                { number++; }
                if (channel2.Busy)
                { number++; }
                if (source.Block())
                { number++; }
                Lqueue = (double)(queue.tacts_state1 + queue.tactsBlock * 2) / (double)number_tacts;
                Lrequest = (double)(queue.tacts_state1 + queue.tactsBlock * 2+channel1.tactsWork+channel2.tactsWork+source.tactsBlock) /(double) number_tacts;
                lambda = (double)source.numberGenerated / (double)number_tacts;
                Wqueue= (double)(queue.tacts_state1 + queue.tactsBlock * 2) / (double)source.numberGenerated;
                Wsystem= (double)(queue.tacts_state1 + queue.tactsBlock * 2 + channel1.tactsWork + channel2.tactsWork+ source.tactsBlock) / (double)source.numberGenerated;
                this.label_k1.Text=k1.ToString();
                this.label_k2.Text=k2.ToString();
                this.label_A.Text=A.ToString();
                this.label_Q.Text = Q.ToString();
                this.label_Preject.Text = Preject.ToString();
                this.label_Plocks.Text = Plock.ToString();
                this.label_Number.Text=number.ToString();
                this.label_Lqueue.Text=Lqueue.ToString();
                this.label_Lrequest.Text = Lrequest.ToString();
                this.label_lambda.Text=lambda.ToString();
                this.label_Wqueue.Text=Wqueue.ToString();
                this.label_Wsystem.Text=Wsystem.ToString();
            }
        }
    }
}
