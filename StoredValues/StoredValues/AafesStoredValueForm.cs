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
        public AafesStoredValueForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AafesStoredValueForm_Load(object sender, EventArgs e)
        {

        }

        private void OnShowAboutBox(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Echo Knowledge Group Co.", "About");
        }
    }
}
