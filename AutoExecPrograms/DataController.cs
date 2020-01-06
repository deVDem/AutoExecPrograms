using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutoExecPrograms
{
    class DataProcess
    {
        private String mName;
        private String mPath;
        private String mArgs;
        public String getName()
        {
            return mName;
        }
        public void setName(String s)
        {
            mName = s;
        }

        public String getPath()
        {
            return mPath;
        }
        public String getArgs()
        {
            return mArgs;
        }
        public void setPath(String s)
        {
            mPath = s;
        }
        public void setArgs(String s)
        {
            mArgs = s;
        }
        public DataProcess()
        {
        }
    }
    class DataController
    {
        private static DataController sDataController;
        private List<DataProcess> dataProcesses = new List<DataProcess>();
        FileStream fileStream;
        String fileSettingsPath = (Application.ExecutablePath + "processes.txt").Replace("AutoExecPrograms.exe", "");
        public DataController()
        {
            
        }
        public static DataController get()
        {
            //FileStream fileStream = File.OpenRead();
            if (sDataController == null) sDataController = new DataController();
            return sDataController;
        }
        public void addProcess(String name, String path, String args)
        {
            DataProcess process = new DataProcess();
            process.setName(name);
            process.setPath(path);
            process.setArgs(args);
            dataProcesses.Add(process);
        }
        public void deleteProcess(String s)
        {
            DataProcess process = findProcessByPath(s);
            if (process == null) process = findProcessByName(s);
            if (process != null) dataProcesses.Remove(process);
        }
        public DataProcess findProcessByName(String name)
        {
            for (int i = 0; i < dataProcesses.Count; i++)
            {
                DataProcess process = dataProcesses[i];
                if (process.getName() == name)
                {
                    return process;
                }
            }
            return null;
        }
        public DataProcess findProcessByPath(String path)
        {
            for (int i = 0; i < dataProcesses.Count; i ++)
            {
                DataProcess process = dataProcesses[i];
                if(process.getPath()==path)
                {
                    return process;
                }
            }
            return null;
        }
        public List<DataProcess> GetDataProcesses()
        {
            return dataProcesses;
        }
    }
}
