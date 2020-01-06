using System;
using System.Windows.Forms;

namespace AutoExecPrograms
{
    public partial class Form2 : Form
    {
        private Strings strings = new Strings();
        private StringsIDs stringsIDs = new StringsIDs();
        private DataController mDataController;
        private Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelNameProcess.Text = strings.getString(stringsIDs.getId(labelNameProcess.Text));
            labelPathProcess.Text = strings.getString(stringsIDs.getId(labelPathProcess.Text));
            labelArgsProcess.Text = strings.getString(stringsIDs.getId(labelArgsProcess.Text));
            buttonAddProcess.Text = strings.getString(stringsIDs.getId(buttonAddProcess.Text));
            buttonCancel.Text = strings.getString(stringsIDs.getId(buttonCancel.Text));
            mDataController = DataController.get();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length != 0 && textBoxPath.Text.Length != 0)
            {
                mDataController.addProcess(textBoxName.Text, textBoxPath.Text, textBoxArgs.Text);
                form1.updateUI();
                Close();
            }
            else MessageBox.Show(strings.getString(stringsIDs.getId("ERROR_NO_NAME_PATH")), strings.getString(stringsIDs.getId("ERROR")));
        }
    }
}
