using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxPosition.Items.Add("Student");
            comboBoxPosition.Items.Add("Programmer");
            comboBoxPosition.Items.Add("Manager");
            comboBoxPosition.Items.Add("Barista");
            comboBoxPosition.Items.Add("Driver");

            dateTimePickerBirth.MinDate = DateTime.Today.AddYears(-100);
            dateTimePickerBirth.MaxDate = DateTime.Today.AddYears(-18);

            numericUpDownExperience.Minimum = 0;
            numericUpDownExperience.Maximum = 50;

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            richTextBoxCard.Clear();
            richTextBoxCard.AppendText($"Name: {textBoxFirstName.Text} {textBoxLastName.Text}\n");
            richTextBoxCard.AppendText($"Email: {textBoxEmail.Text}\n");
            richTextBoxCard.AppendText($"Date of birth: {dateTimePickerBirth.Value.ToLongDateString()}\n");
            richTextBoxCard.AppendText($"Position: {comboBoxPosition.Text}\n");
            richTextBoxCard.AppendText($"Experience: {numericUpDownExperience.Value} years\n");
            {
                string workTime = "---";
                if (radioButtonFullTime.Checked)
                {
                    workTime = "Full-time";
                }
                else if (radioButtonPartTime.Checked)
                {
                    workTime = "Part-time";
                }
                richTextBoxCard.AppendText($"Work time: {workTime}\n");
            }
            richTextBoxCard.AppendText($"Remote work: {(checkBoxRemote.Checked ? "Yes" : "No")}\n");
            richTextBoxCard.AppendText($"Driver license: {(checkBoxRemote.Checked ? "Yes" : "No")}\n");
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                pictureBoxPhoto.Image = Image.FromFile(fileName);
            }
        }

        private void newClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            dateTimePickerBirth.Value = dateTimePickerBirth.MaxDate;
            comboBoxPosition.Text = "";
            comboBoxPosition.SelectedItem = null;
            numericUpDownExperience.Value = numericUpDownExperience.Minimum;
            radioButtonFullTime.Checked = false;
            radioButtonPartTime.Checked = false;
            checkBoxRemote.Checked = false;
            checkBoxDriver.Checked = false;

            richTextBoxCard.Clear();
            pictureBoxPhoto.Image = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
