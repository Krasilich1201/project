using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Variant_19.model;
using Variant_19.NewWindow;
using Variant_19.ViewModel;

namespace Variant_19.WIndow
{
    /// <summary>
    /// Логика взаимодействия для WindowAssignment.xaml
    /// </summary>
    public partial class WindowAssignment : Window
    {
        AssignmentViewModel assi = new AssignmentViewModel();

        public WindowAssignment()
        {
            InitializeComponent();
            Assignment.ItemsSource = assi.ListAssignment;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAssignment wnas = new WindowNewAssignment
            {
                Title = "Новые права",
                Owner = this
            };
            int maxIdas = assi.MaxId() + 1;
            Assignment assig = new Assignment
            {
                ID = maxIdas

            };
            wnas.DataContext = assig;
            if (wnas.ShowDialog() == true)
            {
                assig.SetEmail();
                assig.SetNameRole();

                assi.ListAssignment.Add(assig);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Assignment assig = (Assignment)Assignment.SelectedItem;
            if (assig != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить " +
                assig.NameRole, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    assi.ListAssignment.Remove(assig);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
