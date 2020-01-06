using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoExecPrograms
{
    public partial class Form1 : Form
    {
        private Strings strings = new Strings();
        private StringsIDs stringsIDs = new StringsIDs();
        private List<DataProcess> dataProcesses;
        private DataController dataController = DataController.get();
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
            this.Text = strings.getString(stringsIDs.getId(this.Text));
            dataProcesses = dataController.GetDataProcesses();
            updateUI();
        }

        public void updateUI()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            int width = (listView1.Width / 3);
            String name = strings.getString(stringsIDs.getId("NAME_PROCESS"));
            String path = strings.getString(stringsIDs.getId("PATH_PROCESS"));
            String args = strings.getString(stringsIDs.getId("ARGS_PROCESS"));
            listView1.Columns.Add(name, width);
            listView1.Columns.Add(path, width);
            listView1.Columns.Add(args, width);
            for (int i = 0; i<dataProcesses.Count; i++)
            {
                ListViewItem newitem = new ListViewItem(dataProcesses[i].getName(), name);
                newitem.SubItems.Add(dataProcesses[i].getPath());
                newitem.SubItems.Add(dataProcesses[i].getArgs());
                listView1.Items.Add(newitem);
            }
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataProcesses.Count; i++)
            {
                Process.Start(dataProcesses[i].getPath(), dataProcesses[i].getArgs());
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                dataController.deleteProcess(listView1.SelectedItems[i].Text);
            }
            updateUI();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            updateUI();
        }
    }
}
