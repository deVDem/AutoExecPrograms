using System.Collections.Generic;
using System.IO;
using System.Windows;
using AutoExec2.Objects;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;

namespace AutoExec2.Controllers
{
    public class DataContoller
    {
        private static DataContoller _instance;
        private string settingsPath = "";

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
            settingsPath = Directory.GetCurrentDirectory() + "\\settings.json";
            LoadSettings();
        }

        public List<Profile> Profiles { get; set; } = new List<Profile>(); 


        public void SaveSettings()
        {
            byte[] jsonUtf8Bytes;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(Profiles, options);
            FileStream stream = File.OpenWrite(settingsPath);
            stream.Write(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length);
        }

        private void LoadSettings()
        {
            if (File.Exists(settingsPath))
            {
                try
                {
                    byte[] jsonUtf8Bytes = File.ReadAllBytes(settingsPath);
                    var utf8Reader = new Utf8JsonReader(jsonUtf8Bytes);
                    Profiles = JsonSerializer.Deserialize<List<Profile>>(ref utf8Reader);
                } catch(Exception e)
                {
                    
                }
            }
        }


        public void AddProfile(string name)
        {
            if (FindProfileByName(name) != null) MessageBox.Show("Такой профиль уже существует");
            else
            {
                Profile profile = new Profile(name);
                Profiles.Add(profile);
                MessageBox.Show($"Профиль {name} был успешно создан");
                SaveSettings();
            }
        }

        public void DeleteProfile(string name)
        {
            Profile profile = FindProfileByName(name);
            if (profile != null)
            {
                Profiles.Remove(profile);
                SaveSettings();
            }
        }
        public Profile FindProfileByName(string name)
        {
            foreach (Profile item in Profiles)
            {
                if (item.name == name) return item;
            }
            return null;
        }
    }
}
