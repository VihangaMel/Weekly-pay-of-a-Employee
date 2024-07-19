using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekly_pay_of_a_Employee
{
    public partial class Form1 : Form
    {
        //double hour, hourPayRate;
        private int checkInt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hourPayRate = double.Parse(textBox2.Text);
            double hour = double.Parse(textBox1.Text);

            try
            {
                if (int.TryParse(textBox1.Text, out checkInt))
                {
                    if(hour > 20 & 50 > hour)
                    {
                        if (hour < 40)
                        {
                            int weeklyPay;
                            weeklyPay = (int)(hour * hourPayRate);
                            MessageBox.Show("Weekly Pay: " + weeklyPay, "Payment");
                        }
                        else
                        {
                            int basicPayment;
                            basicPayment = (int)(40 * hourPayRate);

                            int overHours;
                            overHours = (int)(hour - 40);

                            if (overHours <= 5)
                            {
                                int forOverHour, weeklyPay;

                                hourPayRate *= 1.5;
                                forOverHour = (int)(hourPayRate * overHours);
                                weeklyPay = forOverHour + basicPayment;
                                MessageBox.Show("Weekly Pay: " + weeklyPay);

                            }
                            else
                            {
                                double otherOverHours, forOtherOverHourPayment, weeklyPay, forOverHoursPayment;

                                hourPayRate *= 1.5;
                                forOverHoursPayment = (int)(hourPayRate * 5);
                                otherOverHours = overHours - 5;
                                hourPayRate *= 2;
                                forOtherOverHourPayment = hourPayRate * otherOverHours;
                                weeklyPay = basicPayment + forOverHoursPayment + forOtherOverHourPayment;
                                MessageBox.Show("Weekly Pay: " + weeklyPay);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Your weekly worked hour should not be less than 20 or exceeds 50!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid value entered.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
