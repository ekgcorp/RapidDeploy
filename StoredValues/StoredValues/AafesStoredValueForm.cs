using DeploymentToolLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoredValues
{
    public partial class AafesStoredValueForm : Form
    {
        private Store store = new Store();
        private Device device = new Device();
        private User user = new User();
     
        public string Var1 { get; private set; }

        public AafesStoredValueForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AafesStoredValueForm_Load(object sender, EventArgs e)
        {
            string hdSnString = HardwareInfo.GetHDDSerialNo();
            //while (sr.Read())
            {
                hdSnValue.Text = hdSnString;
            }
            
        }

        private void OnShowAboutBox(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Echo Knowledge Group Co.", "About");
        }

        private void headerText_Click(object sender, EventArgs e)
        {

        }
        private void SetupData()
        {

        }

        private void termIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
