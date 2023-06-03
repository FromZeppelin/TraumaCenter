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
    /// Логика взаимодействия для EditSpecificationView.xaml
    /// </summary>
    public partial class EditSpecificationView : Page
    {
        private Specification _currentSpecification = new Specification();

        public EditSpecificationView(Specification SelectedSpecification)
        {
            InitializeComponent();
            if (SelectedSpecification != null) { _currentSpecification = SelectedSpecification; }
            DataContext = _currentSpecification;
        }

        private void SpecificationnWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpecificationBox.Focus();
        }
        private void SpecificationBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SpecificationBox.Text) && SpecificationBox.Text.Length > 0) { SpecificationWatermark.Visibility = Visibility.Collapsed; }
            else { SpecificationWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (string.IsNullOrEmpty(_currentSpecification.Type)) { validator.AppendLine("Specificationn's name can not be null value;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentSpecification.Id == 0)
            {
                TraumaCenterEntities.Context().Specification.Add(_currentSpecification);
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
