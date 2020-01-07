using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Json;

namespace AutoExecPrograms
{

    [DataContract]
    class DataProcess
    {

        [DataMember]
        private String mName;

        [DataMember]
        private String mPath;

        [DataMember]
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
    [DataContract]
    class DataController
    {
        private static DataController sDataController;
        [DataMember]
        private List<DataProcess> dataProcesses = new List<DataProcess>();
        String fileSettingsPath = (Application.ExecutablePath + "processes.json").Replace("AutoExecPrograms.exe", "");
        public DataController()
        {
            
        }
        public void LoadData()
        {
            if (File.Exists(fileSettingsPath))
            {
                FileStream stream = File.Open(fileSettingsPath, FileMode.OpenOrCreate);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<DataProcess>));
                List<DataProcess> d = (List<DataProcess>)serializer.ReadObject(stream);
                stream.Close();
                this.dataProcesses = d;
            }
        }
        public void SaveData()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<DataProcess>));
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, dataProcesses);
            File.Delete(fileSettingsPath);
            FileStream file = File.OpenWrite(fileSettingsPath);
            byte[] streamBytes = stream.ToArray();
            file.Write(streamBytes, 0, streamBytes.Length);
            file.Close();
        }
        public static DataController get()
        {
            if (sDataController == null)
            {
                sDataController = new DataController();
                sDataController.LoadData();
                return sDataController;
            }
            return sDataController;
        }
        public void addProcess(String name, String path, String args)
        {
            DataProcess process = new DataProcess();
            process.setName(name);
            process.setPath(path);
            process.setArgs(args);
            dataProcesses.Add(process);
            SaveData();
        }
        public void deleteProcess(String s)
        {
            DataProcess process = findProcessByPath(s);
            if (process == null) process = findProcessByName(s);
            if (process != null) dataProcesses.Remove(process);
            SaveData();
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
