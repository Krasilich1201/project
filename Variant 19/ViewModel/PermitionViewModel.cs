using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variant_19.model;

namespace Variant_19.ViewModel
{
    class PermitionViewModel
    {
        public ObservableCollection<Permition> ListPermition { get; set; } = new ObservableCollection<Permition>();
        public PermitionViewModel()
        {
            //Заполнение полей( можно сколько угодно)
            this.ListPermition.Add(new Permition
            {
                ID = 1,
                NamePermition = "Запись",
                Discription = "Возможность добавления записи",
                DateCreate = new DateTime(2000,01,20)
            });

            this.ListPermition.Add(new Permition
            {
                ID = 2,
                NamePermition="Удаление",
                Discription="Возможность удаления записи",
                DateCreate = new DateTime(1999,03,15)
            });
        }
        //Проверка ID для избежания ошибок
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListPermition)
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
