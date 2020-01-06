using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoExecPrograms
{
    public partial class Form2 : Form
    {
        private Strings strings = new Strings();
        private StringsIDs stringsIDs = new StringsIDs();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelNameProcess.Text = strings.getString(stringsIDs.getId(labelNameProcess.Text));
            labelPathProcess.Text = strings.getString(stringsIDs.getId(labelPathProcess.Text));
            labelArgsProcess.Text = strings.getString(stringsIDs.getId(labelArgsProcess.Text));
            buttonAddProcess.Text = strings.getString(stringsIDs.getId(buttonAddProcess.Text));
            buttonCancel.Text = strings.getString(stringsIDs.getId(buttonCancel.Text));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
