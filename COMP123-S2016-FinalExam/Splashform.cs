using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }
        // timer1_Tick event handler
        // after 3 seconds is passed, it will show generateNameFoem and hide Splashform
        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.generateNameForm.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
