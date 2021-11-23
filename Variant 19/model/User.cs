using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_19.model
{
    class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public User() { }

        public User(int id, string userName, string password, string email, string status)
        {
            this.ID = id;
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
            this.Status = status;
        }
        public User ShallowCopy()
        {
            return (User)this.MemberwiseClone();
        }
    }
}
