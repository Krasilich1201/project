using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variant_19.model;

namespace Variant_19.ViewModel
{
    class AssignmentViewModel
    {
        public ObservableCollection<Assignment> ListAssignment { get; set; } = new ObservableCollection<Assignment>();
        public AssignmentViewModel()
        {
            //Заполнение полей( можно сколько угодно)
            this.ListAssignment.Add(new Assignment(1, 1, 1, new DateTime(2005,07,25)));
            this.ListAssignment.Add(new Assignment(2, 2, 2, new DateTime(1890, 03, 10)));
        }
        //Проверка ID для избежания ошибок
        public int MaxId()
        {
            int max = 0;
            foreach (var l in this.ListAssignment)
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
