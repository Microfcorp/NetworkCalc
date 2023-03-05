using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCalc
{
    public partial class SelectLinkParams : Form
    {
        /// <summary>
        /// Скорость соединения
        /// </summary>
        public NetworkSpeed Speed
        {
            get
            {
                return (NetworkSpeed)comboBox1.SelectedIndex;
            }
            set
            {
                comboBox1.SelectedIndex = (int)value;
            }
        }
        public SelectLinkParams()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
