using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Salon.user
{
    public class User: IComparable<User>
    { 

        private int _id;
        private string _type;
        private string _username;
        private string _password;

        public User(int id, string type, string username, string password)
        {
            _id = id;
            _type = type;
            _username = username;
            _password = password;
        }

        public User()
        {

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public int CompareTo(User other)
        {
            if (_id > other._id)
            {
                return 1;
            }

            if (_id < other._id)
            {
                return -1;

            }

            return 0;

        }





        public virtual string ToString()
        {
            string t = " ";
            t += "type: " + Type + "\n";
            t += "Username: " + Username + "\n";
            t += "Password:" + Password + "\n";
            return t;

        }

        public virtual








    }
}
