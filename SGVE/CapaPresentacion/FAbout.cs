using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAbout_Load(object sender, EventArgs e)
        {

        }
    }
}