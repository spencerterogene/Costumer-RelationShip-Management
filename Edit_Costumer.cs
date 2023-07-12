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
    public partial class Edit_Costumer : Form
    {
        public Edit_Costumer()
        {
            InitializeComponent();
        }

        private void Edit_Costumer_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Start_Page Data = new Start_Page();
            Data.Show();
            this.Hide();
        }
    }
}
