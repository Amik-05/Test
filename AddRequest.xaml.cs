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
using Test.Models;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для AddRequest.xaml
    /// </summary>
    public partial class AddRequest : Window
    {
        Model1 m = new Model1();
        public AddRequest()
        {
            InitializeComponent();
        }

        private void apply_Click(object sender, RoutedEventArgs e)
        {
            if(equipTXB.Text != "" && typeTXB.Text != "" && descripTXB.Text != "" && clientTXB.Text != "" && statusTXB.Text != "" )
            {
                Random random = new Random();
                Requests newItem = new Requests
                {
                    Number = random.Next(100000,999999).ToString(),
                    Date = DateTime.Now,
                    Equipment = equipTXB.Text,
                    Type = typeTXB.Text,
                    Descrip = descripTXB.Text,
                    Client = clientTXB.Text,
                    Status = statusTXB.Text
                };
                m.Requests.Add(newItem);
                m.SaveChanges();
                MessageBox.Show("Заявка добавлена");
                this.Close();
            }
        }
    }
}
