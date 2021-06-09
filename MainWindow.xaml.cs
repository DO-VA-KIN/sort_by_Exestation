using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using System.Windows.Forms;



namespace WoW
{
    public partial class MainWindow : Window
    {
        string wayOut = "";
        string wayIn = "";


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


        private void TextWayOut_TextChanged(object sender, TextChangedEventArgs e)
        {
            wayOut = TextWayOut.Text;
        }
        private void TextWayIn_TextChanged(object sender, TextChangedEventArgs e)
        {
            wayIn = TextWayIn.Text;
        }
        private void ButtonWayOut_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonWayIn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void chooseSaveWay()
        {
            FolderBrowserDialog fbdReader = new FolderBrowserDialog();
            string way = fbdReader.SelectedPath;
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
