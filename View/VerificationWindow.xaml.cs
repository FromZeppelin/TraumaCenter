using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
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
using System.Windows.Shapes;
using System.Windows.Threading;
using TraumaSoftware.Model;

namespace TraumaSoftware.View
{
    /// <summary>
    /// Логика взаимодействия для VerificationWindow.xaml
    /// </summary>
    public partial class VerificationWindow : Window
    {
        public VerificationWindow()
        {
            InitializeComponent();
        }

        private void IndicatorWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IndicatorBox.Focus();
        }
        private void IndicatorBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(IndicatorBox.Text) && IndicatorBox.Text.Length > 0) { IndicatorWatermark.Visibility = Visibility.Collapsed; }
            else { IndicatorWatermark.Visibility = Visibility.Visible; }
        }

        private void PasswordWatermark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PasswordBox.Focus();
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordBox.Password) && PasswordBox.Password.Length > 0) { PasswordWatermark.Visibility = Visibility.Collapsed; }
            else { PasswordWatermark.Visibility = Visibility.Visible; }
        }

        int retries = 0;
        DispatcherTimer timeout = new DispatcherTimer();
        private void Timeout(object sender, EventArgs e)
        {
            EnterButton.IsHitTestVisible = true;
            TimeoutWatermark.Text = null;
            timeout.Stop();
        }
        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = TraumaCenterEntities.Context().User.FirstOrDefault(u => u.Role == IndicatorBox.Text && u.Password == PasswordBox.Password);

            if (CurrentUser != null && IndicatorBox.Text == "admin")
            {
                LauncherWindow Launcher = new LauncherWindow();
                Launcher.Show();
                this.Close();
            }
            else if (CurrentUser != null && IndicatorBox.Text == "assistant")
            {
                LauncherLimitedWindow LauncherLimited = new LauncherLimitedWindow();
                LauncherLimited.Show();
                this.Close();
            }
            else if (string.IsNullOrEmpty(IndicatorBox.Text) || string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Please, indicate your details before entering.");
            }
            else if (CurrentUser == null)
            {
                retries++;
                if (retries < 3)
                {
                    MessageBox.Show("Actual user has not verificated from data base!");
                }
                else
                {
                    TimeoutWatermark.Text = "RETRIES LIMITED: 2 MIN";
                    EnterButton.IsHitTestVisible = false;
                    timeout.Interval = new TimeSpan(0, 2, 0);
                    timeout.Tick += Timeout;
                    timeout.Start();
                    retries = 0;
                }
            }
        }

        private void EmblemSpace_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { DragMove(); }
        }
        private void TaskBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { DragMove(); }
        }
        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
