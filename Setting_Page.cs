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
    public partial class Setting_Page : Form
    {
        public Setting_Page()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Start_Page Page = new Start_Page();
            Page.Show();
            this.Hide();
        }
    }
}
