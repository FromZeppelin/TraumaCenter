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
    /// Логика взаимодействия для EditCabinetView.xaml
    /// </summary>
    public partial class EditCabinetView : Page
    {
        private Cabinet _currentCabinet = new Cabinet();

        public EditCabinetView(Cabinet SelectedCabinet)
        {
            InitializeComponent();
            if (SelectedCabinet != null) { _currentCabinet = SelectedCabinet; }
            DataContext = _currentCabinet;
            TreaterComboBox.ItemsSource = TraumaCenterEntities.Context().Treater.ToList();
        }

        private void CabinetWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CabinetBox.Focus();
        }
        private void CabinetBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CabinetBox.Text) && CabinetBox.Text.Length > 0) { CabinetWatermark.Visibility = Visibility.Collapsed; }
            else { CabinetWatermark.Visibility = Visibility.Visible; }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder validator = new StringBuilder();

            if (_currentCabinet.Treater == null) { validator.AppendLine("Cabinet has not actual owner to refer;"); }
            if (string.IsNullOrEmpty(_currentCabinet.Number)) { validator.AppendLine("Cabinet's name can not be null value;"); }

            if (validator.Length > 0)
            {
                MessageBox.Show(validator.ToString());
                return;
            }
            if (_currentCabinet.Id == 0)
            {
                TraumaCenterEntities.Context().Cabinet.Add(_currentCabinet);
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
