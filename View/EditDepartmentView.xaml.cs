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
using TraumaSoftware.Model;
using TraumaSoftware.ViewModel;

namespace TraumaSoftware.View
{
    /// <summary>
    /// Логика взаимодействия для EditDepartmentView.xaml
    /// </summary>
    public partial class EditDepartmentView : Page
    {
        private Department _currentDepartment = new Department();

        public EditDepartmentView(Department SelectedDepartment)
        {
            InitializeComponent();
            if (SelectedDepartment != null) { _currentDepartment = SelectedDepartment; }
            DataContext = _currentDepartment;
        }

        private void DepartmentWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DepartmentBox.Focus();
        }
        private void DepartmentBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(DepartmentBox.Text) && DepartmentBox.Text.Length > 0) { DepartmentWatermark.Visibility = Visibility.Collapsed; }
            else { DepartmentWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (string.IsNullOrEmpty(_currentDepartment.Type)) { validator.AppendLine("Department's name can not be null value;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentDepartment.Id == 0)
            {
                TraumaCenterEntities.Context().Department.Add(_currentDepartment);
            }
            try
            {
                TraumaCenterEntities.Context().SaveChanges();
                MessageBox.Show("Successful save changes!");
                FrameController.Container.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
