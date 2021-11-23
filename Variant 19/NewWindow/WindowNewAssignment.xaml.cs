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

namespace Variant_19.NewWindow
{
    /// <summary>
    /// Логика взаимодействия для WindowNewAssignment.xaml
    /// </summary>
    public partial class WindowNewAssignment : Window
    {
        public WindowNewAssignment()
        {
            InitializeComponent();
        }

        private void Personsave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
