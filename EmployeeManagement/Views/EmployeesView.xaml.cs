using EmployeeManagement.Models;
using EmployeeManagement.Services;
using EmployeeManagement.ViewModels;
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

namespace EmployeeManagement.Views
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        private ILogger logger;
        public EmployeesView(IEmployeesViewModel model, ILogger logger)
        {
            InitializeComponent();
            DataContext = model;
           this.logger = logger;

        }

        private void ListView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(sender is ListView listView)
            {
                var employee = (Employee)listView.SelectedItem;
                MessageBox.Show($"Имя: {employee.FirstName}\nФамилия: {employee.LastName}\nВозраст: {employee.Age}" +
                    $"\nДолжность: {employee.Position}\nМесто работы: {employee.CompanyName}\nМесто проживания: {employee.CityName}");
                logger.WriteEvent($"Имя: {employee.FirstName}\nФамилия: {employee.LastName}\nВозраст: {employee.Age}" +
                    $"\nДолжность: {employee.Position}\nМесто работы: {employee.CompanyName}\nМесто проживания: {employee.CityName}");
            }


        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
