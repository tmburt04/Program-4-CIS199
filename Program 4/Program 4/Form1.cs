// Tim Burton
// 04 / 26 / 2015
// CIS 199-75
// This program simply updates the 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Program4 : Form
    {
        List<GroundPackage> packageList = new List<GroundPackage>();

        public Program4()
        {
            InitializeComponent();

        }

        private void addPackageButton_Click(object sender, EventArgs e)
        {
            string originText = originTextBox.Text;
            string destinationText = destinationTextBox.Text;
            string lengthText = lengthTextBox.Text;
            string widthText = widthTextBox.Text;
            string heightText = heightTextBox.Text;
            string weightText = weightTextBox.Text;

            GroundPackage package = new GroundPackage(1, 1, 1, 1, 1, 1, 1);

            if (originText.Length == 5)
            {
                int origin_ = Int32.Parse(originText);
                if (destinationText.Length == 5)
                {
                    int destination_ = Int32.Parse(destinationText);
                    if (lengthText.Length > 0)
                    {
                        double length_ = double.Parse(lengthText);
                        if (widthText.Length > 0)
                        {
                            double width_ = double.Parse(widthText);
                            if (heightText.Length > 0)
                            {
                                double height_ = double.Parse(heightText);
                                if (weightText.Length > 0)
                                {
                                    double weight_ = double.Parse(weightText); // confirms all criteria is met, and creates new object
                                    
                                    Random rand = new Random();
                                    int packageID_ = rand.Next(10000);

                                    package.Destination = destination_;
                                    package.Origin = origin_;
                                    package.Length = length_;
                                    package.Width = width_;
                                    package.Height = height_;
                                    package.Weight = weight_;
                                    package.PackageID = packageID_;
                                    packageList.Add(package);

                                    packageListBox.Items.Add("Package #" + packageID_);

                                }
                                else
                                {
                                    MessageBox.Show("Weight input not valid!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Height input not valid!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Width input not valid!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Length input not valid!");
                    }
                }
                else
                {
                    MessageBox.Show("Destination zip code input not valid!");
                }
            }
            else
            {
                MessageBox.Show("Origin zip code input not valid!");
            }
        }

        private void detailsButton_Click(object sender, EventArgs e) // locates list item and brings up details
        {
            int index = packageListBox.SelectedIndex;
            MessageBox.Show(packageList[index].ToString());
        }

        private void toButton_Click(object sender, EventArgs e) // updates destination to UofL Zip
        {
            int index = packageListBox.SelectedIndex;
            GroundPackage toSelection = packageList[index];
            toSelection.Destination = 40292;

            MessageBox.Show(packageList[index].ToString());
        }

        private void fromButton_Click(object sender, EventArgs e) // updates origin to UofL zip
        {
            int index = packageListBox.SelectedIndex;
            GroundPackage fromSelection = packageList[index];
            fromSelection.Origin = 40292;

            MessageBox.Show(packageList[index].ToString());
        }

        }
    }

