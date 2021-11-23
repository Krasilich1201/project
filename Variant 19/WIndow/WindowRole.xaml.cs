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
    /// Логика взаимодействия для WindowRole.xaml
    /// </summary>
    public partial class WindowRole : Window
    {
        RoleViewModel role = new RoleViewModel();
        public WindowRole()
        {
            InitializeComponent();
            WNPRole.ItemsSource = role.ListRole;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewRole wnrole = new WindowNewRole
            {
                Title = "Новая роль",
                Owner = this
            };
            int maxIdrole = role.MaxId() + 1;
            Role rol = new Role
            {
                ID = maxIdrole

            };
            wnrole.DataContext = rol;
            if (wnrole.ShowDialog() == true)
            {
                rol.SetNamePermition();

                role.ListRole.Add(rol);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Role roll = (Role)WNPRole.SelectedItem;
            if (role != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить " +
                roll.NameRole, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    role.ListRole.Remove(roll);
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
