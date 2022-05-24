using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCallParent_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.Owner;
            parent.NotifyMe("Come On Girls");
        }
    }
}
