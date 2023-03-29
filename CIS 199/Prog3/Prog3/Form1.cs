// Program 3
// CIS 199-01
// Due: 11/05/2020
// By: R2158

// This program prompts the user for their Sate, Product, and Quantity,
// It returns the initial cost, discounted cost, tax, and total price

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Form1 : Form
    {
        // Variables defined
        double CostPerUnit;
        double DiscountPrice;
        double Tax;

        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //String arrays with dropdown
            StateCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            StateCombo.Items.AddRange(new string[] { "KY", "OH", "IN", "IL" });
            ProductCombo.DataSource = new List<int>() { 1001, 1002, 1003, 1004, 1005, 1006, 1007 };

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string Product = ProductCombo.Text;
            string StateTax = StateCombo.Text;




            //Declaring Cost per Unit
            if ( Product == "1001")
            {
                CostPerUnit = 7.87;
            }
            else
            {
                if (Product == "1002")
                {
                    CostPerUnit = 9.51;
                }
                else
                {
                    if (Product == "1003")
                    {
                        CostPerUnit = 10.73;
                    }
                    else
                    {
                        if (Product == "1004")
                        {
                            CostPerUnit = 9.99;
                        }
                        else
                        {
                            if (Product == "1005")
                            {
                                CostPerUnit = 11.99;
                            }
                            else
                            {
                                if (Product == "1006")
                                {
                                    CostPerUnit = 5.00;
                                }
                                else
                                {
                                    if (Product == "1007")
                                    {
                                        CostPerUnit = 4.58;
                                    }
                                    else
                                    {
                                        CostPerUnit = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Declaring Discount
            if (Convert.ToInt32(QuanTXT.Text) <= 4)
            {
                DiscountPrice = 0;
            }
            else
            {
                if (Convert.ToInt32(QuanTXT.Text) <= 9 && Convert.ToInt32(QuanTXT.Text) >=5)
                {
                    DiscountPrice = .05;
                }
                else
                {
                    if (Convert.ToInt32(QuanTXT.Text) <= 19 && Convert.ToInt32(QuanTXT.Text) >= 10)
                {
                        DiscountPrice = .10;
                }
                    else
                    {
                        if (Convert.ToInt32(QuanTXT.Text) < 20)
                {
                            DiscountPrice = .15;
                }
                        else
                        {

                        }
                    }
                }
            }


            //StateTax
            if (StateTax == "KY")
            {
                Tax = .06;
            }
            else
            {
                if (StateTax == "OH")
                {
                    Tax = .0717;
                }
                else
                {
                    if (StateTax == "IN")
                    {
                        Tax = .07;
                    }
                    else
                    {
                        if (StateTax == "IL")
                        {
                            Tax = .0874;
                        }
                        else
                        {
                            Tax = 0;
                        }
                    }
                }
            }

            //Outputs

            if (ProductCombo.SelectedIndex > -1)
                {
                    InitialTXT.Text = $"${Convert.ToInt32(QuanTXT.Text) * CostPerUnit}";
                }

            if (ProductCombo.SelectedIndex > -1)
            {
                DisCstTXT.Text = $"${(Convert.ToInt32(QuanTXT.Text) * CostPerUnit) - (Convert.ToInt32(QuanTXT.Text) * CostPerUnit * DiscountPrice)}";
            }

            if (ProductCombo.SelectedIndex > -1)
            {
                TaxTXT.Text = $"${Tax * ((Convert.ToInt32(QuanTXT.Text) * CostPerUnit) - (Convert.ToInt32(QuanTXT.Text) * CostPerUnit * DiscountPrice))}";
            }

            if (ProductCombo.SelectedIndex > -1)
            {
                TotalTXT.Text = $"${(Convert.ToInt32(QuanTXT.Text) * CostPerUnit) - (Convert.ToInt32(QuanTXT.Text) * CostPerUnit * DiscountPrice) + Tax * ((Convert.ToInt32(QuanTXT.Text) * CostPerUnit) - (Convert.ToInt32(QuanTXT.Text) * CostPerUnit * DiscountPrice))}";
            }

        }
    }
}
