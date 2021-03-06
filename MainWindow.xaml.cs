using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
//using System.Windows.Forms;




namespace WoW
{
    public partial class MainWindow : Window
    {
        List<string> photoEx = new List<string> { ".gif", ".jpe", ".jpg", ".png", ".icon", ".pcx", ".bmp" };
        List<string> videoEx = new List<string> { ".avi", ".mpg", ".mpeg", ".mov", ".qt", ".wmv", ".mp4" };
        List<string> musicEx = new List<string> { ".wav", ".ra", ".ram", ".png", ".au", ".aiff", ".mp3" };

        private BackgroundWorker BackgroundWorker1;

        string wayOut = "";
        string wayIn = "";

        bool moveFiles = true;

        List<string> photo = new List<string>();
        List<string> video = new List<string>();
        List<string> music = new List<string>();
        List<string> other = new List<string>();


        private void enable()
        {
            checkBoxMove.IsEnabled = true;
            checkBoxCopy.IsEnabled = true;
            ButtonWayOut.IsEnabled = true;
            ButtonWayIn.IsEnabled = true;
            TextWayIn.IsEnabled = true;
            TextWayOut.IsEnabled = true;
            ButtonStart.IsEnabled = true;

            photo.Clear();
            video.Clear();
            music.Clear();
            other.Clear();
        }
        private void disable()
        {
            checkBoxMove.IsEnabled = false;
            checkBoxCopy.IsEnabled = false;
            ButtonWayOut.IsEnabled = false;
            ButtonWayIn.IsEnabled = false;
            TextWayIn.IsEnabled = false;
            TextWayOut.IsEnabled = false;
            ButtonStart.IsEnabled = false;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        public MainWindow()
        {
            InitializeComponent();
            BackgroundWorker1 = (BackgroundWorker)this.FindResource("BackgroundWorker1");
        }


        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("1.0\rWritten by Ghost");
        }



        // работа с путями
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
            TextWayOut.Text = wayOut = chooseWay();
        }
        private void ButtonWayIn_Click(object sender, RoutedEventArgs e)
        {
            TextWayIn.Text = wayIn = chooseWay();
        }
        private string chooseWay()
        {
            System.Windows.Forms.FolderBrowserDialog fbdReader = new System.Windows.Forms.FolderBrowserDialog();
            if (fbdReader.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return fbdReader.SelectedPath;
            }
            return "";
        }


        // выбор действия
        private void checkBoxMove_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxCopy.IsChecked = false;
            moveFiles = true;
        }
        private void checkBoxCopy_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxMove.IsChecked = false;
            moveFiles = false;
        }


        // осн алгоритм
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists(wayOut) || !Directory.Exists(wayIn))
            {
                MessageBox.Show("Не удалось получить доступ к директории\n" +
                    "Вероятно путь не существует","Ошибка", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
            else
            {
                string[] allFiles = Directory.GetFiles(wayOut);
                int numFiles = allFiles.Length;
                ProgressBar1.Maximum = numFiles;
                labelProgress.Content = 0 + " из " + numFiles;
            }
            disable();
            BackgroundWorker1.RunWorkerAsync(moveFiles);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;


            foreach (string file in Directory.GetFiles(wayOut))
            {
                try
                {
                    FileInfo fInfo = new FileInfo(file);

                    if (photoEx.Contains(fInfo.Extension))
                    {
                        string way = wayIn + ("\\photo");
                        if (!Directory.Exists(way))
                        {
                            DirectoryInfo dirInfo = new DirectoryInfo(wayIn);
                            dirInfo.CreateSubdirectory("photo");
                        }

                        if ((bool)e.Argument)
                            fInfo.MoveTo(way + "\\" + fInfo.Name);
                        else fInfo.CopyTo(way + "\\" + fInfo.Name);
                }
                    else if (videoEx.Contains(fInfo.Extension))
                    {
                        string way = wayIn + ("\\video");
                        if (!Directory.Exists(way))
                        {
                            DirectoryInfo dirInfo = new DirectoryInfo(wayIn);
                            dirInfo.CreateSubdirectory("video");
                        }

                        if ((bool)e.Argument)
                            fInfo.MoveTo(way + "\\" + fInfo.Name);
                        else fInfo.CopyTo(way + "\\" + fInfo.Name);
                    }
                    else if (musicEx.Contains(fInfo.Extension))
                    {
                        string way = wayIn + ("\\music");
                        if (!Directory.Exists(way))
                        {
                            DirectoryInfo dirInfo = new DirectoryInfo(wayIn);
                            dirInfo.CreateSubdirectory("music");
                        }

                        if ((bool)e.Argument)
                            fInfo.MoveTo(way + "\\" + fInfo.Name);
                        else fInfo.CopyTo(way + "\\" + fInfo.Name);
                    }
                    else
                    {
                        string way = wayIn + ("\\other");
                        if (!Directory.Exists(way + fInfo.Name))
                        {
                            DirectoryInfo dirInfo = new DirectoryInfo(wayIn);
                            dirInfo.CreateSubdirectory("other");
                        }

                        if ((bool)e.Argument)
                            fInfo.MoveTo(way + "\\" + fInfo.Name);
                        else fInfo.CopyTo(way + "\\" + fInfo.Name);
                    }
                }
                catch { }

                count++;
                BackgroundWorker1.ReportProgress(count);
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { 
            ProgressBar1.Value = e.ProgressPercentage;
            labelProgress.Content = ProgressBar1.Value + " из " + ProgressBar1.Maximum;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar1.Value = ProgressBar1.Maximum;
            labelProgress.Content = ProgressBar1.Value + " из " + ProgressBar1.Maximum;
            enable();
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
