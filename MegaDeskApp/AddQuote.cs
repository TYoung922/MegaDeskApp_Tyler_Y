using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDeskApp;

namespace MegaDeskApp
{
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote = new DeskQuote();
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

        private void Submit_Order(object sender, EventArgs e)
        {
            if (WidthBox.Text.Length == 0 || DepthBox.Text.Length == 0 || DrawerInput.Text.Length == 0) return;
            int surfaceArea = deskQuote.desk.getSurfaceArea();
            string orderDate = DateTime.Now.ToShortDateString();
            deskQuote.orderDate = orderDate;
            int shipping = deskQuote.desk.ShippingDays;
            DisplayQuote frm = new DisplayQuote(deskQuote);
            frm.Show();
            Close();
        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newWidth;
                bool isNum = Int32.TryParse(input.Text, out newWidth);
                if (isNum)
                {
                    deskQuote.desk.Width = newWidth;
                    widthError.SetError(this.WidthBox, "");
                }
                else
                {
                    widthError.SetError(this.WidthBox, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                widthError.SetError(this.WidthBox, "Input must be between 24 and 96 inches.");
            }
        }

        private void NameBox_Validation(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                string newName = input.Text;
                bool isString = String.IsNullOrEmpty(input.Text);
                if (!isString && newName.Length > 1)
                {
                    deskQuote.customerName = newName;
                    widthError.SetError(this.NameBox, "");
                }
                else
                {
                    widthError.SetError(this.NameBox, "Name must be more than 1 character");
                }
                
            }
            catch (Exception ex)
            {
                widthError.SetError(this.NameBox, "Please enter your name");
            }
        }

        private void Depth_validation(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newDepth;
                bool isNum = Int32.TryParse(input.Text, out newDepth);
                if (isNum)
                {
                    deskQuote.desk.Depth = newDepth;
                    widthError.SetError(this.DepthBox, "");
                }
                else
                {
                    widthError.SetError(this.DepthBox, "Enter a number.");
                }
            }
            catch (Exception ex)
            {
                widthError.SetError(this.DepthBox, "Input must be between 12 and 48 inches.");
            }
        }

        private void Drawer_Validation(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            
            try
            {
                int newDrawer;
                if (input.SelectedIndex == -1)
                {
                    widthError.SetError(this.DrawerInput, "Please select the number of drawers");
                }
                else
                {
                    widthError.SetError(this.DrawerInput, "");
                    string selection = input.SelectedItem.ToString();
                    newDrawer = int.Parse(selection);
                    deskQuote.desk.DrawerNumber = newDrawer;
                }
            }
            catch (Exception ex)
            {
                widthError.SetError(this.DrawerInput, "Please make a selection");
            }
        }

        private void Material_Validation(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            try
            {
                string newMaterial;
                if (input.SelectedIndex == -1)
                {
                    widthError.SetError(this.MaterialComboBox, "Please select a material");
                }
                else
                {
                    widthError.SetError(this.MaterialComboBox, "");
                    newMaterial = input.SelectedItem.ToString();
                    deskQuote.desk.Material = newMaterial;
                }
            }
            catch (Exception ex)
            {
                widthError.SetError(this.MaterialComboBox, "Please make a selection");
            }
        }

        private void Shipping_validation(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            try
            {
                int newShipping;
                if (input.SelectedIndex == -1)
                {
                    widthError.SetError(this.ShippingComboBox, "Please make a shipping selection");
                }
                else
                {
                    widthError.SetError(this.ShippingComboBox, "");
                    string selection = input.SelectedItem.ToString();
                    newShipping = int.Parse(selection);
                    deskQuote.desk.ShippingDays = newShipping;
                }
            }
            catch (Exception ex)
            {
                widthError.SetError(this.ShippingComboBox, "Please make a selection");
            }
        }
    }
}
