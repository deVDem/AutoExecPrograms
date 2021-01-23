using System.Collections.Generic;

namespace AutoExec2.Objects
{
    public class Profile
    {
        public string name;
        public List<Process> Processes { get; private set; } = new List<Process>();

        public Profile(string name)
        {
            this.name = name;
        }

        public void AddProcess(Process process)
        {
            Processes.Add(process);
        }

        public void DeleteProcess(Process process)
        {
            Processes.Remove(process);
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
