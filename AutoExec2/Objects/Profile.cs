using System.Collections.Generic;

namespace AutoExec2.Objects
{
    public class Profile
    {
        public string name { get; set; }
        public List<Process> Processes { get; set; } = new List<Process>();
        Controllers.DataContoller dataContoller = Controllers.DataContoller.GetInstance();

        public Profile(string name)
        {
            this.name = name;
        }

        public void AddProcess(Process process)
        {
            Processes.Add(process);
            dataContoller.SaveSettings();
        }

        public void DeleteProcess(Process process)
        {
            Processes.Remove(process);
            dataContoller.SaveSettings();
        }
        
        public Process FindProcessByName(string name)
        {
            Process process = null;
            foreach (Process item in Processes)
            {
                if (item.name == name) process = item;
            }
            return process;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
