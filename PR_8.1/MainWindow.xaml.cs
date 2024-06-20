using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using static System.Net.Mime.MediaTypeNames;

namespace PR_8._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Authorization authorization = new Authorization();
        public MainWindow()
        {
            InitializeComponent();
            tb_Formula.Text = authorization.Formula();
            double res = authorization.Result();
            string line = res.ToString();
            tb_Res.Text = line;
        }
        //AdministrationPanel administrationPanel = new AdministrationPanel();
        //administrationPanel.Show();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double res = authorization.Result();
            if (!String.IsNullOrEmpty(tb_Password.Text))
            {
                double text = double.Parse(tb_Password.Text);
                if (text == res)
                {
                    BookingTickets bookingTickets = new BookingTickets();
                    bookingTickets.Show();
                }
                else { MessageBox.Show("Вы ввели неверно формулу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning); }
            }
            else { MessageBox.Show("Вы не ввели формулу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
        
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}
