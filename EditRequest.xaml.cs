using System;
using System.Collections;
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
using Test.Models;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для EditRequest.xaml
    /// </summary>
    public partial class EditRequest : Window
    {
        int _id = 0;
        Model1 m = new Model1();
        public EditRequest(int id)
        {
            InitializeComponent();
            _id = id;
            Output();
        }
        private void Output()
        {
            var r = m.Requests.FirstOrDefault(x=> x.Id == _id);
            equipTXB.Text = r.Equipment;
            typeTXB.Text = r.Type;
            descripTXB.Text = r.Descrip;
            clientTXB.Text = r.Client;
            statusTXB.Text = r.Status;

        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (equipTXB.Text != "" && typeTXB.Text != "" && descripTXB.Text != "" && clientTXB.Text != "" && statusTXB.Text != "")
            {
                var r = m.Requests.FirstOrDefault(x => x.Id == _id);
                r.Equipment = equipTXB.Text;
                r.Type = typeTXB.Text;
                r.Descrip = descripTXB.Text;
                r.Client = clientTXB.Text;
                r.Status = statusTXB.Text;
                m.SaveChanges();
                MessageBox.Show("Изменения сохранены");
                MainWindow ma = new MainWindow();
                ma.Show();
                this.Close();
                
            }
                
        }
    }
}
