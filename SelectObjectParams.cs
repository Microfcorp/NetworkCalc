using NetworkCalc.NetworkObjects;
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
    public partial class SelectObjectParams : Form
    {
        public string NameObject
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public int CountPorts
        {
            get => (int)numericUpDown1.Value;
            set => numericUpDown1.Value = value;
        }

        public NetworkPort[] Ports;

        public SelectObjectParams()
        {
            InitializeComponent();
        }

        public SelectObjectParams(TypesNetworksObjects type) : this()
        {
            if(type != TypesNetworksObjects.Commutator)
            {
                tabControl1.TabPages.Remove(tabPage1);
            }
            if (type != TypesNetworksObjects.Conchetrator)
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
        }

        public void FromNetworkObject(BaseNetworkObject element)
        {
            NameObject = element.NetworkName;
        }

        private void SelectObjectParams_Load(object sender, EventArgs e)
        {

        }

        private void SelectObjectParams_FormClosing(object sender, FormClosingEventArgs e)
        {
            var msg = MessageBox.Show("Вы хотите сохранить текущие настройки?", "Сохранить настройки?", MessageBoxButtons.YesNoCancel);
            if (msg == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
            else if(msg == DialogResult.No)
            {
                DialogResult = DialogResult.No;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
