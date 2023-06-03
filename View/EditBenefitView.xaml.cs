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
    /// Логика взаимодействия для EditBenefitView.xaml
    /// </summary>
    public partial class EditBenefitView : Page
    {
        private Benefit _currentBenefit = new Benefit();

        public EditBenefitView(Benefit SelectedBenefit)
        {
            InitializeComponent();
            if (SelectedBenefit != null) { _currentBenefit = SelectedBenefit; }
            DataContext = _currentBenefit;
        }

        private void BenefitWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BenefitBox.Focus();
        }
        private void BenefitBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(BenefitBox.Text) && BenefitBox.Text.Length > 0) { BenefitWatermark.Visibility = Visibility.Collapsed; }
            else { BenefitWatermark.Visibility = Visibility.Visible; }
        }

        private void DiscountWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DiscountBox.Focus();
        }
        private void DiscountBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(DiscountBox.Text) && DiscountBox.Text.Length > 0) { DiscountWatermark.Visibility = Visibility.Collapsed; }
            else { DiscountWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (string.IsNullOrEmpty(_currentBenefit.Type)) { validator.AppendLine("Benefit's name type can not be null value;"); }
            if (_currentBenefit.Discount <= 0) { validator.AppendLine("Benefit's discount can not be null value;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentBenefit.Id == 0)
            {
                TraumaCenterEntities.Context().Benefit.Add(_currentBenefit);
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
