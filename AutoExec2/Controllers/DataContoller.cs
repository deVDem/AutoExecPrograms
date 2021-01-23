using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoExec2.Objects;

namespace AutoExec2.Controllers
{
    public class DataContoller
    {
        static DataContoller _instance;

        public static DataContoller GetInstance()
        {
            if (_instance == null)
            {
                return new DataContoller();
            }
            else return _instance;
        }

        private DataContoller()
        {
            _instance = this;
        }

        public List<Profile> Profiles { get; private set; } = new List<Profile>(); 

        public void AddProfile(string name)
        {
            if (FindProfileByName(name) != null) MessageBox.Show("Такой профиль уже существует");
            else
            {
                Profile profile = new Profile(name);
                Profiles.Add(profile);
                MessageBox.Show($"Профиль {name} был успешно создан");
            }
        }

        private Profile FindProfileByName(string name)
        {
            foreach (Profile item in Profiles)
            {
                if (item.name == name) return item;
            }
            return null;
        }
    }
}
