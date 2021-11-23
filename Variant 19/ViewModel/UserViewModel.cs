using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variant_19.model;

namespace Variant_19.ViewModel
{
    class UserViewModel
    {
        public ObservableCollection<User> ListUser { get; set; } = new ObservableCollection<User>();
        public UserViewModel()
        {
            //Заполнение полей( можно сколько угодно)
            this.ListUser.Add(new User
            {
                ID = 1,
                UserName = "Чемпион",
                Password = "1488",
                Status = "Онлайн",
                Email = "email@mail.ru"
            });

            this.ListUser.Add(new User
            {
                ID = 2,
                UserName = "Вампир",
                Password = "22233",
                Status = "Оффлайн",
                Email = "yandex@ya.ru"
            });
        }
        //Проверка ID для избежания ошибок
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListUser)
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
