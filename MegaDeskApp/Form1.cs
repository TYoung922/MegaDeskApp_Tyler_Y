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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenNewQuote(object sender, EventArgs e)
        {
            AddQuote viewAdd = new AddQuote();
            viewAdd.Tag = this;
            viewAdd.Show(this);
            Hide();
        }

        private void OpenViewQ(object sender, EventArgs e)
        {
            ViewQuotes viewQuotes = new ViewQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }

        private void OpenSearch(object sender, EventArgs e)
        {
            SearchQuotes viewsearch = new SearchQuotes();
            viewsearch.Tag = this;
            viewsearch.Show(this);
            Hide();
        }
    }
}
