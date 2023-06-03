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
    /// Логика взаимодействия для TreaterView.xaml
    /// </summary>
    public partial class TreaterView : Page
    {
        public TreaterView()
        {
            InitializeComponent();
            TreaterDataGrid.ItemsSource = TraumaCenterEntities.Context().Treater.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TraumaCenterEntities.Context().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                TreaterDataGrid.ItemsSource = TraumaCenterEntities.Context().Treater.ToList();
            }
        }

        private void RefreshButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TraumaCenterEntities.Context().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            TreaterDataGrid.ItemsSource = TraumaCenterEntities.Context().Treater.ToList();
        }
        private void CabinetButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.Navigate(new CabinetView());
        }
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.Navigate(new EditTreaterView(null));
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var remove = TreaterDataGrid.SelectedItems.Cast<Treater>().ToList();

            if (MessageBox.Show("Do you wanna delete selected items?", "Alert!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TraumaCenterEntities.Context().Treater.RemoveRange(remove);
                    TraumaCenterEntities.Context().SaveChanges();
                    MessageBox.Show($"{remove.Count()} items were successful removed.");
                    TreaterDataGrid.ItemsSource = TraumaCenterEntities.Context().Treater.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void SearchWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchBox.Focus();
        }
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchBox.Text) && SearchBox.Text.Length > 0) { SearchWatermark.Visibility = Visibility.Collapsed; }
            else { SearchWatermark.Visibility = Visibility.Visible; }

            try
            {
                TreaterDataGrid.ItemsSource = TraumaCenterEntities.Context().Treater.Where(x => x.Name == SearchBox.Text || x.Surname == SearchBox.Text || x.Birth == SearchBox.Text || x.Phone == SearchBox.Text || x.Education == SearchBox.Text || x.Career == SearchBox.Text).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
