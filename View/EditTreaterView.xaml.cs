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
    /// Логика взаимодействия для EditTreaterView.xaml
    /// </summary>
    public partial class EditTreaterView : Page
    {
        private Treater _currentTreater = new Treater();

        public EditTreaterView(Treater SelectedTreater)
        {
            InitializeComponent();
            if (SelectedTreater != null) { _currentTreater = SelectedTreater; }
            DataContext = _currentTreater;
            SpecificationComboBox.ItemsSource = TraumaCenterEntities.Context().Specification.ToList();
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

        private void PictureWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PictureBox.Focus();
        }
        private void PictureBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PictureBox.Text) && PictureBox.Text.Length > 0) { PictureWatermark.Visibility = Visibility.Collapsed; }
            else { PictureWatermark.Visibility = Visibility.Visible; }
        }

        private void EducationWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EducationBox.Focus();
        }
        private void EducationBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(EducationBox.Text) && EducationBox.Text.Length > 0) { EducationWatermark.Visibility = Visibility.Collapsed; }
            else { EducationWatermark.Visibility = Visibility.Visible; }
        }
        private void EducationBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void CareerWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CareerBox.Focus();
        }
        private void CareerBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CareerBox.Text) && CareerBox.Text.Length > 0) { CareerWatermark.Visibility = Visibility.Collapsed; }
            else { CareerWatermark.Visibility = Visibility.Visible; }
        }
        private void CareerBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) { e.Handled = true; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (string.IsNullOrEmpty(_currentTreater.Name)) { validator.AppendLine("Treater's name can not be null value;"); }
            if (string.IsNullOrEmpty(_currentTreater.Surname)) { validator.AppendLine("Treater's surname can not be bull value;"); }
            if (string.IsNullOrEmpty(_currentTreater.Picture)) { validator.AppendLine("Treater's picture address can not be null value;"); }
            if (string.IsNullOrEmpty(_currentTreater.Phone)) { validator.AppendLine("Treater's phone number can not be null value;"); }
            if (string.IsNullOrEmpty(_currentTreater.Birth)) { validator.AppendLine("Treater's birth date can not be null value;"); }
            if (_currentTreater.Birth.Length < 10 || _currentTreater.Birth.Length > 10) { validator.AppendLine("Treater's birth date must follow format DD/MM/YYYY;"); }
            if (_currentTreater.Specification == null) { validator.AppendLine("Treater's specification can not be null value;"); }
            if (string.IsNullOrEmpty(_currentTreater.Education)) { validator.AppendLine("Treater's education can not be null value;"); }
            if (string.IsNullOrEmpty(_currentTreater.Career)) { validator.AppendLine("Treater's career can not be null value;"); }
            if (_currentTreater.Career.Length < 4 || _currentTreater.Career.Length > 4) { validator.AppendLine("Treater's career should not be less or more than 4;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentTreater.Id == 0)
            {
                TraumaCenterEntities.Context().Treater.Add(_currentTreater);
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
