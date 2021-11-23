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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Variant_19.WIndow;

namespace Variant_19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MWAssignment_Click(object sender, RoutedEventArgs e)
        {
            WindowAssignment assignment = new WindowAssignment();
            assignment.Show();
        }

        private void MWPermition_Click(object sender, RoutedEventArgs e)
        {
            WindowPermition perm = new WindowPermition();
            perm.Show();
        }

        private void MWRole_Click(object sender, RoutedEventArgs e)
        {
            WindowRole role = new WindowRole();
            role.Show();
        }

        private void MWUser_Click(object sender, RoutedEventArgs e)
        {
            WindowUser user = new WindowUser();
            user.Show();
        }
    }
}
