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
    /// Логика взаимодействия для EditPaymentView.xaml
    /// </summary>
    public partial class EditPaymentView : Page
    {
        private Payment _currentPayment = new Payment();

        public EditPaymentView(Payment SelectedPayment)
        {
            InitializeComponent();
            if (SelectedPayment != null) { _currentPayment = SelectedPayment; }
            DataContext = _currentPayment;
            TreatmentComboBox.ItemsSource = TraumaCenterEntities.Context().Treatment.ToList();
            BenefitComboBox.ItemsSource = TraumaCenterEntities.Context().Benefit.ToList();
        }

        private void SumWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SumBox.Focus();
        }
        private void SumBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SumBox.Text) && SumBox.Text.Length > 0) { SumWatermark.Visibility = Visibility.Collapsed; }
            else { SumWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (_currentPayment.Treatment == null) { validator.AppendLine("Payment has not actual treatment to refer;"); }
            if (_currentPayment.Sum <= 0) { validator.AppendLine("Payment's sum can not be null value;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentPayment.Id == 0)
            {
                TraumaCenterEntities.Context().Payment.Add(_currentPayment);
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
