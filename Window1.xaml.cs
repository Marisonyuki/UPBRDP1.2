using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UPBRDP1._2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private BRDUPEntities BRDUP = new BRDUPEntities();
        public Window1()
        {
            InitializeComponent();
            BDG2.ItemsSource = BRDUP.Project.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window0 = new MainWindow();
            window0.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            Close();
        }
    }
}
