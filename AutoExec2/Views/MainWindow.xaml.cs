using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AutoExec2.Controllers;
using AutoExec2.Views;

namespace AutoExec2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataContoller dataContoller = DataContoller.GetInstance();

        

        public MainWindow()
        {
            InitializeComponent();
            profileList.ItemsSource = dataContoller.Profiles;

        }

        public void LockButtons(bool locked)
        {
            addProfileButton.IsEnabled = !locked;
            deleteProfileButton.IsEnabled = !locked;
            addButton.IsEnabled = !locked;
            removeButton.IsEnabled = !locked;
            execButton.IsEnabled = !locked;
            blur.Radius = locked ? 5d : 0d;
        }

        private void addProfile(object sender, RoutedEventArgs e)
        {
            AddProfile addProfileForm = new AddProfile(this);
            addProfileForm.Show();
            LockButtons(true);
        }

        private void deleteProfile(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
