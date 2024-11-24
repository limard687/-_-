using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
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
using static WpfApp1.EmployeeListPage;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();

            clsEmployeeManager clsEmployeeManager = new clsEmployeeManager();

            Employees_Collection.ItemsSource = clsEmployeeManager.lstemployees;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeeListPage_Frame.Content = (new EmployeeEditPage());
        }
    }
}
