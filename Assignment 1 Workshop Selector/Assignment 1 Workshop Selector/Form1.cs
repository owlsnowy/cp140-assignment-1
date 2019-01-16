using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_Workshop_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Days = 0;
            int FeesDays = 0;
            int RegistrationFee = 0;
            int TotalDays;
            int Total;
            string Workshop = lbWorkshop.SelectedItem.ToString();

            if (Workshop == "Handling Stress")
            {
                Days = 3;
                RegistrationFee = 1000;
            }
            else
            {
                if (Workshop == "Time Managment")
                {

                    Days = 3;
                    RegistrationFee = 800;
                }
                else
                {
                    if (Workshop == "Supervision Skills")
                    {
                        Days = 3;
                        RegistrationFee = 1500;

                    }
                    else
                    {
                        if (Workshop == "Negotiation")
                        {

                            Days = 5;
                            RegistrationFee = 1300;
                        }
                        else
                        {
                            if (Workshop == "How to Interview")
                            {
                                Days = 1;
                                RegistrationFee = 500;

                            }

                            else
                            {
                                MessageBox.Show("You have Not selected a workshop");
                            }

                        }

                    }

                }
            }
            if (lbLocation.SelectedItem == "Austin")
            {
                FeesDays = 150;
            }
            else
            {
                if (lbLocation.SelectedItem == "Chicago")
                {
                    FeesDays = 225;
                }
                else
                {
                    if (lbLocation.SelectedItem == "Dallas")
                    {
                        FeesDays = 175;
                    }
                    else
                    {
                        if (lbLocation.SelectedItem == "Orlando")
                        {
                            FeesDays = 300;
                        }
                        else
                        {
                            if (lbLocation.SelectedItem == "Phoenix")
                            {
                                FeesDays = 175;
                            }
                            else
                            {
                                if (lbLocation.SelectedItem.ToString() == "Raleigh")
                                {
                                    FeesDays = 150;
                                }
                                else
                                {
                                    MessageBox.Show("You have Not selected a Location");
                                }
                            }
                        }

                    }

                }
            }
            TotalDays = FeesDays * Days;
            txtLodge.Text = TotalDays.ToString();
            txtReg.Text = RegistrationFee.ToString();
            Total = TotalDays + RegistrationFee;
            txtTotal.Text = Total.ToString();


        }

    }
}
