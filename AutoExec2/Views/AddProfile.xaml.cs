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
using System.Windows.Shapes;
using AutoExec2.Controllers;

namespace AutoExec2.Views
{
    /// <summary>
    /// Логика взаимодействия для AddProfile.xaml
    /// </summary>
    public partial class AddProfile : Window
    {
        DataContoller dataContoller = DataContoller.GetInstance();

        MainWindow mainWindow;

        public AddProfile(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            dataContoller.AddProfile(newNameText.Text);
            mainWindow.LockButtons(false);
            Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mainWindow.LockButtons(false);
        }
    }
}
