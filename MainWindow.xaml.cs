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

namespace WoW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //dataGrid1.ItemsSource = ;

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("ContactList 1.0\rWritten by Ghost");
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
            {
            if (MessageBox.Show("Exit, you are shure?", "GoodBYE...",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Question,
                    MessageBoxResult.Cancel,
                    MessageBoxOptions.ServiceNotification) != MessageBoxResult.OK)

            { e.Cancel = true; }

        }
    }
}
