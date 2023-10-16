namespace Siammod3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_p1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_p2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.textBox_numberTacts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Wqueue = new System.Windows.Forms.Label();
            this.label_Lrequest = new System.Windows.Forms.Label();
            this.label_Wsystem = new System.Windows.Forms.Label();
            this.label_Plocks = new System.Windows.Forms.Label();
            this.label_Lqueue = new System.Windows.Forms.Label();
            this.label_k1 = new System.Windows.Forms.Label();
            this.label_lambda = new System.Windows.Forms.Label();
            this.label_Preject = new System.Windows.Forms.Label();
            this.label_k2 = new System.Windows.Forms.Label();
            this.label_Q = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_p1
            // 
            this.textBox_p1.Location = new System.Drawing.Point(88, 21);
            this.textBox_p1.Name = "textBox_p1";
            this.textBox_p1.Size = new System.Drawing.Size(100, 22);
            this.textBox_p1.TabIndex = 0;
            this.textBox_p1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p1_KeyPress);
            this.textBox_p1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_p1_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_p2
            // 
            this.textBox_p2.Location = new System.Drawing.Point(88, 63);
            this.textBox_p2.Name = "textBox_p2";
            this.textBox_p2.Size = new System.Drawing.Size(100, 22);
            this.textBox_p2.TabIndex = 3;
            this.textBox_p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_p2_KeyPress);
            this.textBox_p2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_p2_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "p1=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "p2=";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_calculate);
            this.groupBox1.Controls.Add(this.textBox_numberTacts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_p1);
            this.groupBox1.Controls.Add(this.textBox_p2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(827, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probability";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(154, 156);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 8;
            this.button_calculate.Text = "calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // textBox_numberTacts
            // 
            this.textBox_numberTacts.Location = new System.Drawing.Point(88, 103);
            this.textBox_numberTacts.Name = "textBox_numberTacts";
            this.textBox_numberTacts.Size = new System.Drawing.Size(100, 22);
            this.textBox_numberTacts.TabIndex = 6;
            this.textBox_numberTacts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numberTacts_KeyPress);
            this.textBox_numberTacts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_numberTacts_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Num of tact=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Number);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label_Wqueue);
            this.groupBox2.Controls.Add(this.label_Lrequest);
            this.groupBox2.Controls.Add(this.label_Wsystem);
            this.groupBox2.Controls.Add(this.label_Plocks);
            this.groupBox2.Controls.Add(this.label_Lqueue);
            this.groupBox2.Controls.Add(this.label_k1);
            this.groupBox2.Controls.Add(this.label_lambda);
            this.groupBox2.Controls.Add(this.label_Preject);
            this.groupBox2.Controls.Add(this.label_k2);
            this.groupBox2.Controls.Add(this.label_Q);
            this.groupBox2.Controls.Add(this.label_A);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analytical variables";
            // 
            // label_Wqueue
            // 
            this.label_Wqueue.AutoSize = true;
            this.label_Wqueue.Location = new System.Drawing.Point(181, 365);
            this.label_Wqueue.Name = "label_Wqueue";
            this.label_Wqueue.Size = new System.Drawing.Size(11, 16);
            this.label_Wqueue.TabIndex = 27;
            this.label_Wqueue.Text = "-";
            // 
            // label_Lrequest
            // 
            this.label_Lrequest.AutoSize = true;
            this.label_Lrequest.Location = new System.Drawing.Point(180, 286);
            this.label_Lrequest.Name = "label_Lrequest";
            this.label_Lrequest.Size = new System.Drawing.Size(11, 16);
            this.label_Lrequest.TabIndex = 26;
            this.label_Lrequest.Text = "-";
            // 
            // label_Wsystem
            // 
            this.label_Wsystem.AutoSize = true;
            this.label_Wsystem.Location = new System.Drawing.Point(180, 327);
            this.label_Wsystem.Name = "label_Wsystem";
            this.label_Wsystem.Size = new System.Drawing.Size(11, 16);
            this.label_Wsystem.TabIndex = 25;
            this.label_Wsystem.Text = "-";
            // 
            // label_Plocks
            // 
            this.label_Plocks.AutoSize = true;
            this.label_Plocks.Location = new System.Drawing.Point(181, 214);
            this.label_Plocks.Name = "label_Plocks";
            this.label_Plocks.Size = new System.Drawing.Size(11, 16);
            this.label_Plocks.TabIndex = 24;
            this.label_Plocks.Text = "-";
            // 
            // label_Lqueue
            // 
            this.label_Lqueue.AutoSize = true;
            this.label_Lqueue.Location = new System.Drawing.Point(181, 248);
            this.label_Lqueue.Name = "label_Lqueue";
            this.label_Lqueue.Size = new System.Drawing.Size(11, 16);
            this.label_Lqueue.TabIndex = 23;
            this.label_Lqueue.Text = "-";
            // 
            // label_k1
            // 
            this.label_k1.AutoSize = true;
            this.label_k1.Location = new System.Drawing.Point(181, 129);
            this.label_k1.Name = "label_k1";
            this.label_k1.Size = new System.Drawing.Size(11, 16);
            this.label_k1.TabIndex = 22;
            this.label_k1.Text = "-";
            // 
            // label_lambda
            // 
            this.label_lambda.AutoSize = true;
            this.label_lambda.Location = new System.Drawing.Point(180, 103);
            this.label_lambda.Name = "label_lambda";
            this.label_lambda.Size = new System.Drawing.Size(11, 16);
            this.label_lambda.TabIndex = 21;
            this.label_lambda.Text = "-";
            // 
            // label_Preject
            // 
            this.label_Preject.AutoSize = true;
            this.label_Preject.Location = new System.Drawing.Point(180, 183);
            this.label_Preject.Name = "label_Preject";
            this.label_Preject.Size = new System.Drawing.Size(11, 16);
            this.label_Preject.TabIndex = 20;
            this.label_Preject.Text = "-";
            // 
            // label_k2
            // 
            this.label_k2.AutoSize = true;
            this.label_k2.Location = new System.Drawing.Point(181, 156);
            this.label_k2.Name = "label_k2";
            this.label_k2.Size = new System.Drawing.Size(11, 16);
            this.label_k2.TabIndex = 19;
            this.label_k2.Text = "-";
            // 
            // label_Q
            // 
            this.label_Q.AutoSize = true;
            this.label_Q.Location = new System.Drawing.Point(181, 74);
            this.label_Q.Name = "label_Q";
            this.label_Q.Size = new System.Drawing.Size(14, 16);
            this.label_Q.TabIndex = 18;
            this.label_Q.Text = "- ";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(181, 47);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(14, 16);
            this.label_A.TabIndex = 17;
            this.label_A.Text = "- ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "W_queue=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "L_request=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "W_system=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "P_lockS=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "L_queue=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "K1=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Lambda=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "P_reject=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "K2=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Q=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "A=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Number_in_QS=";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Location = new System.Drawing.Point(180, 398);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(11, 16);
            this.label_Number.TabIndex = 29;
            this.label_Number.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_p1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_numberTacts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Wqueue;
        private System.Windows.Forms.Label label_Lrequest;
        private System.Windows.Forms.Label label_Wsystem;
        private System.Windows.Forms.Label label_Plocks;
        private System.Windows.Forms.Label label_Lqueue;
        private System.Windows.Forms.Label label_k1;
        private System.Windows.Forms.Label label_lambda;
        private System.Windows.Forms.Label label_Preject;
        private System.Windows.Forms.Label label_k2;
        private System.Windows.Forms.Label label_Q;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label15;
    }
}

