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
using Variant_19.ViewModel;

namespace Variant_19.WIndow
{
    /// <summary>
    /// Логика взаимодействия для WindowPermition.xaml
    /// </summary>
    public partial class WindowPermition : Window
    {
        PermitionViewModel vmPermition = new PermitionViewModel();
        public WindowPermition()
        {
            InitializeComponent();
            WNPPermition.ItemsSource = vmPermition.ListPermition;
        }
    }
}
