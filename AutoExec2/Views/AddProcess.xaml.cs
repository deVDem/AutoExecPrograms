using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace AutoExec2.Views
{
    /// <summary>
    /// Логика взаимодействия для AddProcess.xaml
    /// </summary>
    public partial class AddProcess : Window
    {

        MainWindow main;

        public AddProcess(MainWindow mainWindow)
        {
            main = mainWindow;
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            main.LockButtons(false);
        }

        private void PathButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if ((bool)openFileDialog.ShowDialog(this))
            {
                String filename = openFileDialog.FileName;
                pathTextBox.Text = filename;
                if (nameTextBox.Text.Length == 0) nameTextBox.Text = Path.GetFileNameWithoutExtension(filename);
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            main.AddProcess(new Objects.Process(nameTextBox.Text, pathTextBox.Text, argsTextBox.Text));
            Close();
        }
    }
}
