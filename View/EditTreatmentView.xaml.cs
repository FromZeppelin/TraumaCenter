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
    /// Логика взаимодействия для EditTreatmentView.xaml
    /// </summary>
    public partial class EditTreatmentView : Page
    {
        private Treatment _currentTreatment = new Treatment();

        public EditTreatmentView(Treatment SelectedTreatment)
        {
            InitializeComponent();
            if (SelectedTreatment != null) { _currentTreatment = SelectedTreatment; }
            DataContext = _currentTreatment;
            CabinetComboBox.ItemsSource = TraumaCenterEntities.Context().Cabinet.ToList();
            MedcardComboBox.ItemsSource = TraumaCenterEntities.Context().Medcard.ToList();
        }

        private void DateWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DateBox.Focus();
        }
        private void DateBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(DateBox.Text) && DateBox.Text.Length > 0) { DateWatermark.Visibility = Visibility.Collapsed; }
            else { DateWatermark.Visibility = Visibility.Visible; }
        }

        private void TimeWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TimeBox.Focus();
        }
        private void TimeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TimeBox.Text) && TimeBox.Text.Length > 0) { TimeWatermark.Visibility = Visibility.Collapsed; }
            else { TimeWatermark.Visibility = Visibility.Visible; }
        }

        private void PriceWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PriceBox.Focus();
        }
        private void PriceBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PriceBox.Text) && PriceBox.Text.Length > 0) { PriceWatermark.Visibility = Visibility.Collapsed; }
            else { PriceWatermark.Visibility = Visibility.Visible; }
        }
        private void CommentWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CommentBox.Focus();
        }
        private void CommentBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CommentBox.Text) && CommentBox.Text.Length > 0) { CommentWatermark.Visibility = Visibility.Collapsed; }
            else { CommentWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (_currentTreatment.Cabinet == null) { validator.AppendLine("Treatment has not actual cabinet to refer;"); }
            if (_currentTreatment.Medcard == null) { validator.AppendLine("Treatment has not actual medcard to refer;"); }
            if (string.IsNullOrEmpty(_currentTreatment.Date)) { validator.AppendLine("Treatment's date can not be null value;"); }
            if (string.IsNullOrEmpty(_currentTreatment.Time)) { validator.AppendLine("Treatment's time can not be null value;"); }
            if (_currentTreatment.Price <= 0) { validator.AppendLine("Treatment's price can not be null value;"); }


            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentTreatment.Id == 0)
            {
                TraumaCenterEntities.Context().Treatment.Add(_currentTreatment);
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
