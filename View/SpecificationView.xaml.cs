using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TraumaSoftware.Model;
using TraumaSoftware.ViewModel;

namespace TraumaSoftware.View
{
    /// <summary>
    /// Логика взаимодействия для SpecificationView.xaml
    /// </summary>
    public partial class SpecificationView : Page
    {
        public SpecificationView()
        {
            InitializeComponent();
            SpecificationDataGrid.ItemsSource = TraumaCenterEntities.Context().Specification.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TraumaCenterEntities.Context().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                SpecificationDataGrid.ItemsSource = TraumaCenterEntities.Context().Specification.ToList();
            }
        }

        private void RefreshButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TraumaCenterEntities.Context().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            SpecificationDataGrid.ItemsSource = TraumaCenterEntities.Context().Specification.ToList();
        }
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.Navigate(new EditSpecificationView(null));
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var remove = SpecificationDataGrid.SelectedItems.Cast<Specification>().ToList();

            if (MessageBox.Show("Do you wanna delete selected items?", "Alert!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TraumaCenterEntities.Context().Specification.RemoveRange(remove);
                    TraumaCenterEntities.Context().SaveChanges();
                    MessageBox.Show($"{remove.Count()} items were successful removed.");
                    SpecificationDataGrid.ItemsSource = TraumaCenterEntities.Context().Specification.ToList();
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
                SpecificationDataGrid.ItemsSource = TraumaCenterEntities.Context().Specification.Where(x => x.Type == SearchBox.Text).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
