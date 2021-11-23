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
    /// Логика взаимодействия для WindowUser.xaml
    /// </summary>
    public partial class WindowUser : Window
    {
        UserViewModel vmuser = new UserViewModel();
        public WindowUser()
        {
            InitializeComponent();
            WNPUser.ItemsSource = vmuser.ListUser;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewUser wnuser = new WindowNewUser
            {
                Title = "Новый пользователь",
                Owner = this
            };
            int maxIduser = vmuser.MaxId() + 1;
            User user = new User
            {
                ID = maxIduser
            };
            wnuser.DataContext = user;
            if (wnuser.ShowDialog() == true)
            {
                vmuser.ListUser.Add(user);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewUser wnuser = new WindowNewUser
            {
                Title = "Редактирование",
                Owner = this
            };
            User user = WNPUser.SelectedItem as User;
            if (user != null)
            {
                User us = user.ShallowCopy();
                wnuser.DataContext = us;
                if (wnuser.ShowDialog() == true)
                {
                    user.Email = user.Email;
                    user.Password = user.Password;
                    user.UserName = user.UserName;
                    user.Status = user.Status;
                    


                    WNPUser.ItemsSource = null;
                    WNPUser.ItemsSource = vmuser.ListUser;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать поле для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            User user = (User)WNPUser.SelectedItem;
            if (user != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить " +
                user.UserName, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmuser.ListUser.Remove(user);
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
