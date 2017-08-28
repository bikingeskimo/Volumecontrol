using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace VolumeControl
{
    public partial class volumControlForm : Form
    {
        public volumControlForm()
        {
            InitializeComponent();
        }

        private void volumControlForm_Load(object sender, EventArgs e)
        {



            //find available COMports and list them
            string[] ports = SerialPort.GetPortNames();
            COMPortSelector.Items.Add("Select a port...");
            COMPortSelector.Items.AddRange(ports);
            COMPortSelector.SelectedIndex = 0;

            //disable save button before all options are set
            buttonSave.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ConfigurationManager.Appsettings[""] = COMPortSelector.SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {

        }

        private void COMPortSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (COMPortSelector.SelectedIndex != 0)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }

        private void knobFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
