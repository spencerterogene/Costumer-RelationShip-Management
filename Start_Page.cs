using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costumer_RelationShip_Management
{
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            InitializeComponent();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            Setting_Page Data = new Setting_Page();
            Data.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login_Page Data = new Login_Page();
            Data.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Costumer Page = new Add_Costumer();
            Page.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Edit_Costumer Data = new Edit_Costumer();
            Data.Show();
            this.Hide();
        }

        private void btnSearchExit_Click(object sender, EventArgs e)
        {
            Search_Costumer Data = new Search_Costumer();
            Data.Show();
            this.Hide();
        }
    }
}
