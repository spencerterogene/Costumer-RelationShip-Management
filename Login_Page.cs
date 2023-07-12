using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costumer_RelationShip_Management
{
    public partial class Login_Page : Form
    {
        static string connection = @"Data Source = costumers.db";
        public static string Username;
        public static string Password;
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main_Page Data = new Main_Page();
            Data.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            checkUserInDatabase( Username,  Password);
        }
        public void checkUserInDatabase(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Costumer WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            Start_Page Page = new Start_Page();
                            Page.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
