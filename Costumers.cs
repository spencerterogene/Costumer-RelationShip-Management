using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costumer_RelationShip_Management
{
    public class Costumers
    {
        public class User
        {
            string first_name;
            string last_name;
            string username;
            string password;
            string phoneNumber;
            string email;

            ~User() { }
            public User()
            {
                this.first_name = "";
                this.last_name = "";
                this.username = "";
                this.password = "";
                this.phoneNumber = "";
                this.email = "";
            }

            public void setfirst_name(string X)
            {
                this.first_name = X;
            }

            public string getfirst_name()
            {
                return this.first_name;
            }

            public void setlast_name(string X)
            {
                this.last_name = X;
            }

            public string getlast_name()
            {
                return this.last_name;
            }

            public void setusername(string X)
            {
                this.username = X;
            }

            public string getusername()
            {
                return this.username;
            }

            public void setpassword(string X)
            {
                this.password = X;
            }

            public string getpassword()
            {
                return this.password;
            }

            public void setphoneNumber(string X)
            {
                this.phoneNumber = X;
            }

            public string getphoneNumber()
            {
                return this.phoneNumber;
            }

            public void setemail(string X)
            {
                this.email = X;
            }

            public string getemail()
            {
                return this.email;
            }

            


        }
    }
}
