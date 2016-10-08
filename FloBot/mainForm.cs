using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloBot
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            tbRestHP_Scroll(null, null);
            tbEmHP_Scroll(null, null);
            tbRestMP_Scroll(null, null);
            tbEmMP_Scroll(null, null);
            new Main.StateMachine(this);
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            Console.WriteLine("Called!");
            Properties.Settings.Default.Save();
        }

        private void tbRestHP_Scroll(object sender, EventArgs e)
        {
            lblRestHP.Text = tbRestHP.Value + "%";
        }
        private void tbRestMP_Scroll(object sender, EventArgs e)
        {
            lblRestMP.Text = tbRestMP.Value + "%";
        }
        private void tbEmHP_Scroll(object sender, EventArgs e)
        {
            lblEmHP.Text = tbEmHP.Value + "%";
        }
        private void tbEmMP_Scroll(object sender, EventArgs e)
        {
            lblEmMP.Text = tbEmMP.Value + "%";
        }

        private void lblExpCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lblRestHP_Click(object sender, EventArgs e)
        {

        }
    }
}
