using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_19.model
{
    class Permition
    {
        public int ID { get; set; }
        public string NamePermition { get; set; }
        public string Discription { get; set; }
        public DateTime DateCreate { get; set; }

        public Permition() { }

        public Permition(int id, string namePermition, string discription, DateTime dateCreate)
        {
            this.ID = id;
            this.NamePermition = namePermition;
            this.Discription = discription;
            this.DateCreate = dateCreate;
        }

        public Permition ShallowCopy()
        {
            return (Permition)this.MemberwiseClone();
        }
    }
}

