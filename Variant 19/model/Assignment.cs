using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variant_19.ViewModel;

namespace Variant_19.model
{
    class Assignment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public DateTime DateCreate { get; set; }

        public User user;
        public Role role;
        private UserViewModel userviewmodel;
        private RoleViewModel roleviewmodel;

        public string Email { get; set; }
        public string NameRole { get; set; }

        public Assignment() { }

        public Assignment(int id, int userID, int roleID, DateTime dateCreate)
        {
            this.ID = id;
            this.UserID = userID;
            this.RoleID = roleID;
            this.DateCreate = dateCreate;


            userviewmodel = new UserViewModel();
            var qquueerry = from ps in userviewmodel.ListUser where ps.ID == UserID select ps;
            foreach (var item in qquueerry)
            {
                this.user = item;
            }

            Email = user.Email;

            roleviewmodel = new RoleViewModel();
            var qq = from ps in roleviewmodel.ListRole where ps.ID == RoleID select ps;
            foreach (var items in qq)
            {
                this.role = items;
            }

            NameRole = role.NameRole;
        }

        public Assignment ShallowCopy()
        {
            return (Assignment)this.MemberwiseClone();
        }
        // Данные запросы необходимы, чтобы ловить PersonID(благодаря этому мы из PersonID берем необходимое поле для вывода

        public void SetEmail()
        {
            userviewmodel = new UserViewModel();
            var ochered = from zxc in userviewmodel.ListUser
                          where zxc.ID == UserID
                          select zxc;
            foreach (var item in ochered)
            {
                this.user = item;
            }

            Email = user.Email;
        }
        public void SetNameRole()
        {
            roleviewmodel = new RoleViewModel();
            var query = from ps in roleviewmodel.ListRole
                        where ps.ID == RoleID
                        select ps;
            foreach (var item in query)
            {
                this.role = item;
            }

            NameRole = role.NameRole;
        }
    }
}
