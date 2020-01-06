using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoExecPrograms
{
    public partial class Form1 : Form
    {
        private Strings strings = new Strings();
        private StringsIDs stringsIDs = new StringsIDs();
        private List<DataProcess> dataProcesses;
        private DataController dataController = new DataController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label_appname.Text = strings.getString(stringsIDs.getId(this.label_appname.Text));
            this.button_exec.Text = strings.getString(stringsIDs.getId(this.button_exec.Text));
            this.button_add.Text = strings.getString(stringsIDs.getId(this.button_add.Text));
            this.button_remove.Text = strings.getString(stringsIDs.getId(this.button_remove.Text));
            dataProcesses = dataController.GetDataProcesses();
            updateUI();
        }

        public void updateUI()
        {
            listView1.Columns.Clear();
            int width = (listView1.Width / 3);
            listView1.Columns.Add(strings.getString(stringsIDs.getId("NAME_PROCESS")), width);
            listView1.Columns.Add(strings.getString(stringsIDs.getId("PATH_PROCESS")), width);
            listView1.Columns.Add(strings.getString(stringsIDs.getId("ARGS_PROCESS")), width);
            for(int i = 0; i<dataProcesses.Count; i++)
            {
                listView1.Columns.Add(dataProcesses[i].getName());
            }
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            //listView1.Items.Add(object); // добавить объект
            // Process.Start("C:/Windows/System32/dxcpl.exe", ""); // использовать для запуска процессов
        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void button_remove_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            updateUI();
        }
    }
}
