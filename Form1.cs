using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TotalTxtBx_Click(object sender, EventArgs e)
        {
            string search;
            string game;
            string company;
            string presale;
            double sales;
            double total = 0;
            bool found = false;
            bool companyfound = false;

            try
            {

                search = searchTxtBx.Text.Trim();
                totalGrpBx.Text = "Total Sales for " + search;
                StreamWriter outLog;
                outLog = File.AppendText("searchLogFile.dat");
                StreamReader outGame;
                outGame = File.OpenText("game.dat");
                StreamReader outSales;
                outSales = File.OpenText("SalesNumbers.dat");
                StreamReader outCompany;
                outCompany = File.OpenText("company.dat");

                while (!outGame.EndOfStream)
                {

                    game = outGame.ReadLine().Trim();
                    company = outCompany.ReadLine().Trim();

                    presale = outSales.ReadLine().Trim();
                    double.TryParse(presale, out sales);


                    if (string.Compare(game, search, true) == 0)
                    {
                        found = true;
                        if (errorChkBx.Checked)
                        {


                            if (sales == 0)
                            {
                                itemLstBx.Items.Add("Sales Figure corrupted - " + presale);
                                outLog.WriteLine(game + " === Sales Figure corrupted - " + presale);
                            }
                            else
                            {
                                itemLstBx.Items.Add(sales);
                                outLog.WriteLine(game + " === " + sales);
                            }
                        }
                        else
                        {
                            if (sales == 0)
                            {
                                itemLstBx.Items.Add("Sales Figure corrupted");
                                outLog.WriteLine(game + " === Sales Figure corrupted");
                            }
                            else
                            {
                                itemLstBx.Items.Add(sales);
                                outLog.WriteLine(game + " === " + sales);
                            }
                        }//display error

                        total += sales;

                        if (!companyfound) {
                        if (string.Compare(company, "ms", true) == 0)
                        {
                            microsoftRdBtn.Checked = true;
                        }
                        else if (string.Compare(company, "ea", true) == 0)
                        {


                            eaRdBtn.Checked = true;
                        }
                        else
                        {
                            blizzardRdBtn.Checked = true;
                        }//company checker
                        }




                    }//game = search

                }//while

                totalLblBx.Text = "$" + total.ToString("n2");

                if (!found)
                {
                    if (search == "")
                    {
                        totalGrpBx.Text = "Total Sales";
                        itemLstBx.Items.Clear();
                        totalLblBx.Text = "";
                        blizzardRdBtn.Checked = false;
                        eaRdBtn.Checked = false;
                        microsoftRdBtn.Checked = false;
                        MessageBox.Show("Nothing entered \nPlease re-enter game title");
                    }
                    else
                    {
                        totalGrpBx.Text = "Total Sales";
                        itemLstBx.Items.Clear();
                        totalLblBx.Text = "";
                        blizzardRdBtn.Checked = false;
                        eaRdBtn.Checked = false;
                        microsoftRdBtn.Checked = false;
                        MessageBox.Show("Game title NOT found");
                    }
                }

                

                outGame.Close();
                outLog.Close();
                outCompany.Close();
                outSales.Close();

            }
            catch
            {
               
            }


        }

        private void ErrorChkBx_CheckedChanged(object sender, EventArgs e)
        {
            totalGrpBx.Text = "Total Sales";
            itemLstBx.Items.Clear();
            totalLblBx.Text = "";
            blizzardRdBtn.Checked = false;
            eaRdBtn.Checked = false;
            microsoftRdBtn.Checked = false;

        }

        private void ClearTxtBx_Click(object sender, EventArgs e)
        {
            totalGrpBx.Text = "Total Sales";
            searchTxtBx.Text = "";
            itemLstBx.Items.Clear();
            totalLblBx.Text = "";
            blizzardRdBtn.Checked = false;
            eaRdBtn.Checked = false;
            microsoftRdBtn.Checked = false;
        }
    }
}
