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
    /// Логика взаимодействия для MedcardView.xaml
    /// </summary>
    public partial class MedcardView : Page
    {
        public MedcardView()
        {
            InitializeComponent();
            MedcardDataGrid.ItemsSource = TraumaCenterEntities.Context().Medcard.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TraumaCenterEntities.Context().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                MedcardDataGrid.ItemsSource = TraumaCenterEntities.Context().Medcard.ToList();
            }
        }

        private void RefreshButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TraumaCenterEntities.Context().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            MedcardDataGrid.ItemsSource = TraumaCenterEntities.Context().Medcard.ToList();
        }
        private void CustomerButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.GoBack();
        }
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            FrameController.Container.Navigate(new EditMedcardView(null));
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var remove = MedcardDataGrid.SelectedItems.Cast<Medcard>().ToList();

            if (MessageBox.Show("Do you wanna delete selected items?", "Alert!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TraumaCenterEntities.Context().Medcard.RemoveRange(remove);
                    TraumaCenterEntities.Context().SaveChanges();
                    MessageBox.Show($"{remove.Count()} items were successful removed.");
                    MedcardDataGrid.ItemsSource = TraumaCenterEntities.Context().Medcard.ToList();
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
                MedcardDataGrid.ItemsSource = TraumaCenterEntities.Context().Medcard.Where(x => x.Number == SearchBox.Text).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
