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
    public partial class FormOptions : Form
    {
        public int OptionFontSize
        {
            get
            {
                return trackBarSize.Value;
            }
            set
            {
                trackBarSize.Value = value;
            }
        }
        public FormOptions()
        {
            InitializeComponent();
            trackBarSize.Minimum = 6;
            trackBarSize.Maximum = 20;

            comboBoxColor.Items.Add("Homework");
            comboBoxColor.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
