using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskApp
{
    public partial class AddQuote : Form
    {
        bool activeErrors = true;
        public AddQuote()
        {
            InitializeComponent();
            currentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    currentDate.Text = DateTime.Now.ToString("mm/dd/yyyy");
        //}

        private void return_to_main()
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GoBack(object sender, EventArgs e)
        {
            return_to_main();
        }

        private void Check_Width(object sender, EventArgs e)
        {
            if (int.TryParse(dWidth.Text, out int widthNumb))
            {
                if (widthNumb >= 12 && widthNumb <= 96)
                {
                    widthError.SetError(dWidth, "");
                    activeErrors = false;
                }
                else 
                {
                    widthError.SetError(dWidth, "Width must be between 12 and 96 inches");
                    activeErrors = true;
                }
            }
            else
            {
                widthError.SetError(dWidth, "Please enter a valid number");
            }
        }

        private void Check_Depth(object sender, EventArgs e)
        {
            if (int.TryParse(dDepth.Text, out int depthNumb))
            {
                if (depthNumb >= 12 && depthNumb <= 96)
                {
                    widthError.SetError(dDepth, "");
                    activeErrors = false;
                }
                else
                {
                    widthError.SetError(dDepth, "Depth must be between 12 and 48 inches");
                    activeErrors = true;
                }
            }
            else
            {
                widthError.SetError(dDepth, "Please enter a valid number");
                activeErrors = true;
            }
        }

        private void Drawer_Check(object sender, EventArgs e)
        {
            if (numbDrawers.SelectedIndex == -1)
            {
                widthError.SetError(numbDrawers, "Please select the number of drawers you want");
                activeErrors = true;
            }
            else { widthError.SetError(numbDrawers, ""); activeErrors = false; }
        }

        private void Material_Check(object sender, EventArgs e)
        {
            if (material.SelectedIndex == -1)
            {
                widthError.SetError(material, "Please select a material");
                activeErrors = true;
            }
            else { widthError.SetError(material, ""); activeErrors = false; }
        }

        private void Ship_Check(object sender, EventArgs e)
        {
            if (shipping.SelectedIndex == -1)
            {
                widthError.SetError(shipping, "Please select a shipping option");
                activeErrors = true;
            }
            else { widthError.SetError(shipping, ""); activeErrors = false; }
        }

        private void Name_Check(object sender, EventArgs e)
        {
            if (cusName.Text.Length < 2)
            {
                widthError.SetError(cusName, "Please enter a name of at least 2 characters");
                activeErrors = true;
            }
            else { widthError.SetError(cusName, ""); activeErrors = false; }
        }

        private void Submit_Order(object sender, EventArgs e)
        {
            if (activeErrors)
            { MessageBox.Show("Please fill in all fields"); }
            else 
            {
                //This is where subit stuff will go

                cusName.Clear();
                dWidth.Clear();
                dDepth.Clear();
                numbDrawers.SelectedIndex = -1;
                material.SelectedIndex = -1;
                shipping.SelectedIndex = -1;
            }
        }
    }
}
