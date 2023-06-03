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
    /// Логика взаимодействия для EditMedcardView.xaml
    /// </summary>
    public partial class EditMedcardView : Page
    {
        private Medcard _currentMedcard = new Medcard();

        public EditMedcardView(Medcard SelectedMedcard)
        {
            InitializeComponent();
            if (SelectedMedcard != null) { _currentMedcard = SelectedMedcard; }
            DataContext = _currentMedcard;
            CustomerComboBox.ItemsSource = TraumaCenterEntities.Context().Customer.ToList();
        }

        private void MedcardWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MedcardBox.Focus();
        }
        private void MedcarBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(MedcardBox.Text) && MedcardBox.Text.Length > 0) { MedcardWatermark.Visibility = Visibility.Collapsed; }
            else { MedcardWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (_currentMedcard.Customer == null) { validator.AppendLine("Medcard has not actual owner to refer;"); }
            if (string.IsNullOrEmpty(_currentMedcard.Number)) { validator.AppendLine("Medcard's number can not be null value;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentMedcard.Id == 0)
            {
                TraumaCenterEntities.Context().Medcard.Add(_currentMedcard);
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
