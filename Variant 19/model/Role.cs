using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variant_19.ViewModel;

namespace Variant_19.model
{
    class Role
    {
        public int ID { get; set; }
        public int PermitionID { get; set; }
        public string NameRole { get; set; }
        public string Discription { get; set; }

        public Permition permition;
        private PermitionViewModel permitionviewmodel;

        public string NamePerm { get; set; }

        public Role() { }

        public Role(int id, int permitionID, string nameRole, string discription)
        {
            this.ID = id;
            this.PermitionID = permitionID;
            this.NameRole = nameRole;
            this.Discription = discription;

            permitionviewmodel = new PermitionViewModel();
            var query = from ps in permitionviewmodel.ListPermition where ps.ID == PermitionID select ps;
            foreach (var item in query)
            {
                this.permition = item;
            }

            NamePerm = permition.NamePermition;
        }

        public Role ShallowCopy()
        {
            return (Role)this.MemberwiseClone();
        }

        public void SetNamePermition()
        {
            permitionviewmodel = new PermitionViewModel();
            var query = from ps in permitionviewmodel.ListPermition where ps.ID == PermitionID select ps;
            foreach (var item in query)
            {
                this.permition = item;
            }

            NamePerm = permition.NamePermition;
        }
    }
}
