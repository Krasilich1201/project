using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variant_19.model;

namespace Variant_19.ViewModel
{
    class RoleViewModel
    {
        public ObservableCollection<Role> ListRole { get; set; } = new ObservableCollection<Role>();
        public RoleViewModel()
        {
            //Заполнение полей( можно сколько угодно)
            this.ListRole.Add(new Role(1, 1, "Админ", "Обладает всеми правами"));
            this.ListRole.Add(new Role(2, 2, "Обычный", "Рядовой пользователь"));
        }
        //Проверка ID для избежания ошибок
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListRole)
            {
                if (max < l.ID)
                {
                    max = l.ID;
                };
            }
            return max;
        }
    }
}
