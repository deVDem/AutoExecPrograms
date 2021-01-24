using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using AutoExec2.Controllers;
using AutoExec2.Views;
using AutoExec2.Objects;

namespace AutoExec2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataContoller dataContoller;

        

        public MainWindow()
        {
            InitializeComponent();
            dataContoller = DataContoller.GetInstance();
            updateUI();
        }

        public void updateUI()
        {
            List<string> nameProfiles = new List<string>();
            foreach (Profile item in dataContoller.Profiles)
            {
                nameProfiles.Add(item.name);
            }
            profileList.ItemsSource = nameProfiles;
            profileList.SelectedIndex = dataContoller.Profiles.Count;
            Profile profile = dataContoller.FindProfileByName(profileList.Text);
            processesList.Items.Clear();
            if (profile == null) {
                currentProfileText.Content = "Current Profile";
                return;
            }
            currentProfileText.Content = profile.name;
            foreach (Process item in profile.Processes)
            {
                processesList.Items.Add(item);
            }
        }

        void LV_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var newWidth = processesList.ActualWidth / GridView1.Columns.Count;
            foreach (var column in GridView1.Columns)
            {
                column.Width = newWidth;
            }
        }

        public void LockButtons(bool locked)
        {
            addProfileButton.IsEnabled = !locked;
            deleteProfileButton.IsEnabled = !locked;
            addButton.IsEnabled = !locked;
            removeButton.IsEnabled = !locked;
            execButton.IsEnabled = !locked;
            blur.Radius = locked ? 10d : 0d;
            updateUI();
        }

        public void AddProcess(Process process)
        {
            dataContoller.FindProfileByName(profileList.Text).AddProcess(process);
            updateUI();
        }

        private void addProfile(object sender, RoutedEventArgs e)
        {
            AddProfile addProfileForm = new AddProfile(this);
            addProfileForm.Show();
            LockButtons(true);
        }

        private void deleteProfile(object sender, RoutedEventArgs e)
        {
            dataContoller.DeleteProfile(profileList.Text);
            updateUI();
        }

        private void profileList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateUI();
        }

        private void addProcessButton_Click(object sender, RoutedEventArgs e)
        {
            if(dataContoller.FindProfileByName(profileList.Text)==null)
            {
                MessageBox.Show("Нет профиля");
                return;
            }
            AddProcess addProcess = new AddProcess(this);
            addProcess.Show();
            LockButtons(true);
        }

        private void removeProcessButton_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = dataContoller.FindProfileByName(profileList.Text);
            if (profile == null)
                return;
            Process process = (Process)processesList.SelectedValue;
            if (process == null)
                return;
            if (profile.FindProcessByName(process.name)!=null)
                profile.DeleteProcess(process);
            updateUI();
        }

        private void execProfileButton_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = dataContoller.FindProfileByName(profileList.Text);
            if (profile == null)
                return;
            foreach (Process item in profile.Processes)
            {
                item.run();
            }
        }
    }
}
