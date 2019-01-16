using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_Colour_Changer
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

        private void btnMix_Click(object sender, EventArgs e)
        {
            if ((rbRed1.Checked == true) && (rbRed2.Checked == true))
            {
                this.BackColor = System.Drawing.Color.Crimson;
            }
            else
            {
                if ((rbBlue1.Checked == true) && (rbBlue2.Checked == true))
                {
                    this.BackColor = System.Drawing.Color.DarkBlue;
                }
                else
                {
                    if ((rbYellow1.Checked == true) && (rbYellow2.Checked == true))
                    {
                        this.BackColor = System.Drawing.Color.Yellow;
                    }
                    else
                    {
                        if (((rbBlue1.Checked == true) && (rbRed2.Checked == true)) || ((rbRed1.Checked == true) && (rbBlue2.Checked == true)))
                        {
                            this.BackColor = System.Drawing.Color.Purple;
                        }
                        else
                        {
                            if (((rbYellow1.Checked == true) && (rbRed2.Checked == true)) || ((rbRed1.Checked == true) && (rbYellow2.Checked == true)))
                            {
                                this.BackColor = System.Drawing.Color.Orange;
                            }
                            else
                            {
                                if (((rbYellow1.Checked == true) && (rbBlue2.Checked == true)) || ((rbBlue1.Checked == true) && (rbYellow2.Checked == true)))
                                {
                                    this.BackColor = System.Drawing.Color.Green;
                                }
                                else
                                {
                                    MessageBox.Show("You have Not selected a Color");
                                }
                            }
                        }

                    }

                }
            }
        }
    }
}
