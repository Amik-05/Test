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
using Test.Models;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 m = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            Output();
        }
        private void Output()
        {
            var r = m.Requests.ToList();
            rList.ItemsSource = r;
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int id = Convert.ToInt32(b.Tag);
            EditRequest x = new EditRequest(id);
            this.Close();
            x.Show();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
           Button b = (Button)sender;
            int id = Convert.ToInt32(b.Tag);
            var r = m.Requests.FirstOrDefault(x => x.Id == id);
            m.Requests.Remove(r);
            m.SaveChanges();
            MessageBox.Show("Заявка удалена");
            if (rList.ItemsSource != null)
            {
                rList.ItemsSource = null;
            }
            Output();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddRequest x = new AddRequest();
            x.ShowDialog();
             if (rList.ItemsSource != null)
            {
                rList.ItemsSource = null;
            }
            Output();
        }
    }
}
