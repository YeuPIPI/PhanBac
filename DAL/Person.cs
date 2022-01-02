using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Person
    {
        private string email;
        private string password;
        private int id;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public Person(string email, string password, int id)
        {
            this.email = email;
            this.password = password;
            this.id = id;
        }
        public Person() { }
        
    }
}
