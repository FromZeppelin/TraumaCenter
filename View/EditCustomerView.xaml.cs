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
    /// Логика взаимодействия для EditCustomerView.xaml
    /// </summary>
    public partial class EditCustomerView : Page
    {
        private Customer _currentCustomer = new Customer();

        public EditCustomerView(Customer SelectedCustomer)
        {
            InitializeComponent();
            if (SelectedCustomer != null) { _currentCustomer = SelectedCustomer; }
            DataContext = _currentCustomer;
        }

        private void NameWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NameBox.Focus();
        }
        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameBox.Text) && NameBox.Text.Length > 0) { NameWatermark.Visibility = Visibility.Collapsed; }
            else { NameWatermark.Visibility = Visibility.Visible; }
        }
        private void NameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void MidnameWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MidnameBox.Focus();
        }
        private void MidnameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(MidnameBox.Text) && MidnameBox.Text.Length > 0) { MidnameWatermark.Visibility = Visibility.Collapsed; }
            else { MidnameWatermark.Visibility = Visibility.Visible; }
        }
        private void MidnameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void SurnameWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SurnameBox.Focus();
        }
        private void SurnameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SurnameBox.Text) && SurnameBox.Text.Length > 0) { SurnameWatermark.Visibility = Visibility.Collapsed; }
            else { SurnameWatermark.Visibility = Visibility.Visible; }
        }
        private void SurnameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void BirthWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BirthBox.Focus();
        }
        private void BirthBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(BirthBox.Text) && BirthBox.Text.Length > 0) { BirthWatermark.Visibility = Visibility.Collapsed; }
            else { BirthWatermark.Visibility = Visibility.Visible; }
        }

        private void PhoneWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PhoneBox.Focus();
        }
        private void PhoneBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PhoneBox.Text) && PhoneBox.Text.Length > 0) { PhoneWatermark.Visibility = Visibility.Collapsed; }
            else { PhoneWatermark.Visibility = Visibility.Visible; }
        }
        private void PhoneBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void InsuranceWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InsuranceBox.Focus();
        }
        private void InsuranceBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(InsuranceBox.Text) && InsuranceBox.Text.Length > 0) { InsuranceWatermark.Visibility = Visibility.Collapsed; }
            else { InsuranceWatermark.Visibility = Visibility.Visible; }
        }
        private void InsuranceBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void ServicemanWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ServicemanBox.Focus();
        }
        private void ServicemanBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ServicemanBox.Text) && ServicemanBox.Text.Length > 0) { ServicemanWatermark.Visibility = Visibility.Collapsed; }
            else { ServicemanWatermark.Visibility = Visibility.Visible; }
        }
        private void ServicemanBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void DistrictWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DistrictBox.Focus();
        }
        private void DistrictBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(DistrictBox.Text) && DistrictBox.Text.Length > 0) { DistrictWatermark.Visibility = Visibility.Collapsed; }
            else { DistrictWatermark.Visibility = Visibility.Visible; }
        }
        private void DistrictBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void LocationWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LocationBox.Focus();
        }
        private void LocationBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(LocationBox.Text) && LocationBox.Text.Length > 0) { LocationWatermark.Visibility = Visibility.Collapsed; }
            else { LocationWatermark.Visibility = Visibility.Visible; }
        }
        private void LocationBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void StreetWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StreetBox.Focus();
        }
        private void StreetBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(StreetBox.Text) && StreetBox.Text.Length > 0) { StreetWatermark.Visibility = Visibility.Collapsed; }
            else { StreetWatermark.Visibility = Visibility.Visible; }
        }

        private void ApartmentWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ApartmentBox.Focus();
        }
        private void ApartmentBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ApartmentBox.Text) && ApartmentBox.Text.Length > 0) { ApartmentWatermark.Visibility = Visibility.Collapsed; }
            else { ApartmentWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (string.IsNullOrEmpty(_currentCustomer.Name)) { validator.AppendLine("Customer's name can not be null value;"); }
            if (string.IsNullOrEmpty(_currentCustomer.Surname)) { validator.AppendLine("Customer's surname can not be bull value;"); }
            if (string.IsNullOrEmpty(_currentCustomer.Phone)) { validator.AppendLine("Customer's phone number can not be null value;"); }
            if (string.IsNullOrEmpty(_currentCustomer.Birth)) { validator.AppendLine("Customer's birth date can not be null value;"); }
            if (_currentCustomer.Birth.Length < 10 || _currentCustomer.Birth.Length > 10) { validator.AppendLine("Customer's birth date must follow format DD/MM/YYYY;"); }
            if (string.IsNullOrEmpty(_currentCustomer.Insurance)) { validator.AppendLine("Customer's insurance can not be null value;"); }
            if (_currentCustomer.Insurance.Length < 20 || _currentCustomer.Insurance.Length > 20) { validator.AppendLine("Customer's insurance should not be less or more than 20;"); }
            if (string.IsNullOrEmpty(_currentCustomer.District)) { validator.AppendLine("Customer's District information can not be null value;"); }
            if (string.IsNullOrEmpty(_currentCustomer.Location)) { validator.AppendLine("Customer's Location information can not be null value;"); }
            if (string.IsNullOrEmpty(_currentCustomer.Street)) { validator.AppendLine("Customer's Street information can not be null value;"); }
            if (string.IsNullOrEmpty(_currentCustomer.Apartment)) { validator.AppendLine("Customer's Apartment information can not be null value;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentCustomer.Id == 0)
            {
                TraumaCenterEntities.Context().Customer.Add(_currentCustomer);
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
