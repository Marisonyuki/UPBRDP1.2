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

namespace UPBRDP1._2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private BRDUPEntities BRDUP = new BRDUPEntities();
        public Window2()
        {
            InitializeComponent();
            BDG3.ItemsSource = BRDUP.GameIndustry.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GameIndustry h = new GameIndustry();
            h.Worker_ID = Convert.ToInt32(Texter1.Text);
            h.Project_ID = Convert.ToInt32(Texter2.Text);
            BRDUP.GameIndustry.Add(h);
            BRDUP.SaveChanges();
            BDG3.ItemsSource = BRDUP.GameIndustry.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (BDG3.SelectedItem != null)
            {
                var selected = BDG3.SelectedItem as GameIndustry;
                selected.Worker_ID = Convert.ToInt32(Texter1.Text);
                selected.Project_ID = Convert.ToInt32(Texter2.Text);
                BRDUP.SaveChanges();
                BDG3.ItemsSource = BRDUP.GameIndustry.ToList();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (BDG3.SelectedItem != null)
            {
                BRDUP.GameIndustry.Remove(BDG3.SelectedItem as GameIndustry);
                BRDUP.SaveChanges();
                BDG3.ItemsSource = BRDUP.GameIndustry.ToList();
            }
        }
    }
}
