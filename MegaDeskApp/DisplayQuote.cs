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
    public partial class DisplayQuote : Form
    {
        DeskQuote deskQuote = new DeskQuote();
        public DisplayQuote(DeskQuote cusQuote)
        {
            deskQuote = cusQuote;
            InitializeComponent();
        }

        private void return_to_main()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            return_to_main();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            cusName.Text = deskQuote.customerName;
            currentDate.Text = deskQuote.orderDate;
            string width = Convert.ToString(deskQuote.desk.Width);
            string depth = Convert.ToString(deskQuote.desk.Depth);
            string drawers = Convert.ToString(deskQuote.desk.DrawerNumber);
            string shipping = Convert.ToString(deskQuote.desk.ShippingDays);
            string material = deskQuote.desk.Material;
            int surfaceTotal = deskQuote.desk.Width * deskQuote.desk.Depth;

            string total = Convert.ToString(surfaceTotal);

            cusWidth.Text = width;
            cusDepth.Text = depth;
            cusDrawers.Text = drawers + " drawers";
            cusMaterial.Text = material;
            cusShip.Text = shipping + " days";
            cusTotal.Text = total + " in^2";
        }
    }
}
