using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label_appname.Text = strings.getString(stringsIDs.getId(this.label_appname.Text));
            this.button_exec.Text = strings.getString(stringsIDs.getId(this.button_exec.Text));
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            // Process.Start("C:/Windows/System32/dxcpl.exe", ""); // тест #TODO: использовать для запуска процессов
        }
    }
}
