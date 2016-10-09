using FloBot.MemoryClass;
using FloBot.Model;
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

            rbBuff1_CheckedChanged(null, null);
            rbBuff2_CheckedChanged(null, null);
            rbBuff3_CheckedChanged(null, null);
            rbBuff9_CheckedChanged(null, null);
            
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

        private void rbBuff1_CheckedChanged(object sender, EventArgs e)
        {

            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.AttArray, new Skill(0, 0, Keys.NumPad1));
            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.BuffArray, new Skill(0, 0, Keys.NumPad1));

            if (cbUseAtt1.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay1.Text, out delay);
                Int32.TryParse(tbCast1.Text, out cast);
                if (rbBuff1.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.BuffArray, new Skill(delay, cast, Keys.NumPad1));
                if(rbAttack1.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.AttArray, new Skill(delay, cast, Keys.NumPad1));
            }
                
                    

        }

        private void rbAttack1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbDelay1_TextChanged(object sender, EventArgs e)
        {
            rbBuff1_CheckedChanged(null, null);
        }

        private void tbCast1_TextChanged(object sender, EventArgs e)
        {
            rbBuff1_CheckedChanged(null, null);
        }

        private void cbUseAtt1_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff1_CheckedChanged(null, null);
        }

        private void rbBuff2_CheckedChanged(object sender, EventArgs e)
        {
            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.AttArray, new Skill(0, 0, Keys.NumPad2));
            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.BuffArray, new Skill(0, 0, Keys.NumPad2));

            if (cbUseSkill2.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay2.Text, out delay);
                Int32.TryParse(tbCast2.Text, out cast);
                if (rbBuff2.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.BuffArray, new Skill(delay, cast, Keys.NumPad2));
                
                if (rbAtt2.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.AttArray, new Skill(delay, cast, Keys.NumPad2));
                
            }
        }

        private void cbUseSkill2_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff2_CheckedChanged(null, null);
        }

        private void tbDelay2_TextChanged(object sender, EventArgs e)
        {
            rbBuff2_CheckedChanged(null, null);
        }

        private void tbCast2_TextChanged(object sender, EventArgs e)
        {
            rbBuff2_CheckedChanged(null, null);
        }

        private void rbBuff3_CheckedChanged(object sender, EventArgs e)
        {
            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.AttArray, new Skill(0, 0, Keys.NumPad3));
            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.BuffArray, new Skill(0, 0, Keys.NumPad3));

            if (cbUseSkill3.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay3.Text, out delay);
                Int32.TryParse(tbCast3.Text, out cast);
                if (rbBuff3.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.BuffArray, new Skill(delay, cast, Keys.NumPad3));

                if (rbAtt3.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.AttArray, new Skill(delay, cast, Keys.NumPad3));

            }
        }

        private void cbUseSkill3_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff3_CheckedChanged(null, null);
        }

        private void tbCast3_TextChanged(object sender, EventArgs e)
        {
            rbBuff3_CheckedChanged(null, null);
        }

        private void rbAtt3_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff3_CheckedChanged(null, null);
        }

        private void tbDelay3_TextChanged(object sender, EventArgs e)
        {
            rbBuff3_CheckedChanged(null, null);
        }

        private void rbAtt2_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff2_CheckedChanged(null, null);
        }

        private void rbBuff9_CheckedChanged(object sender, EventArgs e)
        {
            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.AttArray, new Skill(0, 0, Keys.NumPad9));
            DataNeededCrossTaskUtil.removeElement(DataNeededCrossTaskUtil.BuffArray, new Skill(0, 0, Keys.NumPad9));

            if (cbUseSkill9.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay9.Text, out delay);
                Int32.TryParse(tbCast9.Text, out cast);
                if (rbBuff9.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.BuffArray, new Skill(delay, cast, Keys.NumPad9));

                if (rbAtt9.Checked)
                    DataNeededCrossTaskUtil.addElement(DataNeededCrossTaskUtil.AttArray, new Skill(delay, cast, Keys.NumPad9));

            }
        }

        private void tbDelay9_TextChanged(object sender, EventArgs e)
        {
            rbBuff9_CheckedChanged(null, null);
        }

        private void tbCast9_TextChanged(object sender, EventArgs e)
        {
            rbBuff9_CheckedChanged(null, null);
        }
    }
}
