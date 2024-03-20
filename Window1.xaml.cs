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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Project g = new Project();
            g.ProjectName = Texter1.Text;
            g.Deadline = Convert.ToDateTime(Texter2.Text);
            BRDUP.Project.Add(g);
            BRDUP.SaveChanges();
            BDG2.ItemsSource = BRDUP.Project.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (BDG2.SelectedItem != null)
            {
                var selected = BDG2.SelectedItem as Project;
                selected.ProjectName = Texter1.Text;
                selected.Deadline = Convert.ToDateTime(Texter2.Text);
                BRDUP.SaveChanges();
                BDG2.ItemsSource = BRDUP.Project.ToList();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (BDG2.SelectedItem != null)
            {
                BRDUP.Project.Remove(BDG2.SelectedItem as Project);
                BRDUP.SaveChanges();
                BDG2.ItemsSource = BRDUP.Project.ToList();
            }
        }
    }
}
