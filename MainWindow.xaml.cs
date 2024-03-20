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

namespace UPBRDP1._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BRDUPEntities BRDUP = new BRDUPEntities();
        public MainWindow()
        {
            InitializeComponent();
            BDG.ItemsSource = BRDUP.Worker.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Worker c = new Worker();
            c.FirstName = Texter1.Text;
            c.MiddleName = Texter2.Text;
            c.LastName = Texter3.Text;
            BRDUP.Worker.Add(c);
            BRDUP.SaveChanges();
            BDG.ItemsSource = BRDUP.Worker.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (BDG.SelectedItem != null)
            {
                var selected = BDG.SelectedItem as Worker;
                selected.FirstName = Texter1.Text;
                selected.MiddleName = Texter2.Text;
                selected.LastName = Texter3.Text;
                BRDUP.SaveChanges();
                BDG.ItemsSource = BRDUP.Worker.ToList();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (BDG.SelectedItem != null)
            {
                BRDUP.Worker.Remove(BDG.SelectedItem as Worker);
                BRDUP.SaveChanges();
                BDG.ItemsSource = BRDUP.Worker.ToList();
            }
        }
    }
}
