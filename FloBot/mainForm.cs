using FloBot.Main;
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
        private Player player = new Player();
        private StateMachine machine;
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int test = 0;
            String testS = "1";
            Int32.TryParse(testS, out test);
            Console.WriteLine(test);
            rbBuff1_CheckedChanged(null, null);
            rbBuff2_CheckedChanged(null, null);
            rbBuff3_CheckedChanged(null, null);
            rbBuff9_CheckedChanged(null, null);
            
            tbRestHP_Scroll(null, null);
            tbEmHP_Scroll(null, null);
            tbRestMP_Scroll(null, null);
            tbEmMP_Scroll(null, null);
            machine = new StateMachine(this, player);
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            machine.endBotThread();
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
            lblMax1.Text = tbMax1.Value + "%";
            lblMin1.Text = tbMin1.Value + "%";
            player.removeElement(player.AttArray, new Skill(0, 0, Keys.NumPad1,tbMax1.Value,tbMin1.Value));
            player.removeElement(player.BuffArray, new Skill(0, 0, Keys.NumPad1, tbMax1.Value, tbMin1.Value));

            if (cbUseAtt1.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay1.Text, out delay);
                Int32.TryParse(tbCast1.Text, out cast);
                if (rbBuff1.Checked)
                    player.addElement(player.BuffArray, new Skill(delay, cast, Keys.NumPad1, tbMax1.Value, tbMin1.Value));
                if(rbAttack1.Checked)
                    player.addElement(player.AttArray, new Skill(delay, cast, Keys.NumPad1, tbMax1.Value, tbMin1.Value));
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
            player.removeElement(player.AttArray, new Skill(0, 0, Keys.NumPad2, 0, 0));
            player.removeElement(player.BuffArray, new Skill(0, 0, Keys.NumPad2, 0, 0));

            if (cbUseSkill2.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay2.Text, out delay);
                Int32.TryParse(tbCast2.Text, out cast);
                if (rbBuff2.Checked)
                    player.addElement(player.BuffArray, new Skill(delay, cast, Keys.NumPad2, tbMax2.Value, tbMin2.Value));
                
                if (rbAtt2.Checked)
                    player.addElement(player.AttArray, new Skill(delay, cast, Keys.NumPad2, tbMax2.Value, tbMin2.Value));
                
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
            player.removeElement(player.AttArray, new Skill(0, 0, Keys.NumPad3, tbMax3.Value, tbMax3.Value));
            player.removeElement(player.BuffArray, new Skill(0, 0, Keys.NumPad3, tbMax3.Value, tbMax3.Value));

            if (cbUseSkill3.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay3.Text, out delay);
                Int32.TryParse(tbCast3.Text, out cast);
                if (rbBuff3.Checked)
                    player.addElement(player.BuffArray, new Skill(delay, cast, Keys.NumPad3, tbMax3.Value, tbMax3.Value));

                if (rbAtt3.Checked)
                    player.addElement(player.AttArray, new Skill(delay, cast, Keys.NumPad3, tbMax3.Value, tbMax3.Value));

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
            player.removeElement(player.AttArray, new Skill(0, 0, Keys.NumPad9, tbMax9.Value, tbMin9.Value));
            player.removeElement(player.BuffArray, new Skill(0, 0, Keys.NumPad9, tbMax9.Value, tbMin9.Value));

            if (cbUseSkill9.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay9.Text, out delay);
                Int32.TryParse(tbCast9.Text, out cast);
                if (rbBuff9.Checked)
                    player.addElement(player.BuffArray, new Skill(delay, cast, Keys.NumPad9, tbMax9.Value, tbMin9.Value));

                if (rbAtt9.Checked)
                    player.addElement(player.AttArray, new Skill(delay, cast, Keys.NumPad9, tbMax9.Value, tbMin9.Value));

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

        private void cbAutoLoot_CheckedChanged(object sender, EventArgs e)
        {
            player.MobToLootCount = 0;
        }

        private void tbMax1_Scroll(object sender, EventArgs e)
        {
             
            rbBuff1_CheckedChanged(null, null);
        }

        private void tbMin1_Scroll(object sender, EventArgs e)
        {
            lblMin1.Text = tbMin1.Value + "%";
            
        }

        private void tbMax2_Scroll(object sender, EventArgs e)
        {
            lblMax2.Text = "" + tbMax2.Value;
        }

        private void tbMin2_Scroll(object sender, EventArgs e)
        {

            lblMin2.Text = "" + tbMin2.Value;

        }

        private void tbMax3_Scroll(object sender, EventArgs e)
        {
            lblMax3.Text = "" + tbMax3.Value;
        }

        private void tbMin3_Scroll(object sender, EventArgs e)
        {

            lblMin3.Text = "" + tbMin3.Value;
        }

        private void tbMax9_Scroll(object sender, EventArgs e)
        {
            lblMax9.Text = "" + tbMax9.Value;
        }

        private void tbMin9_Scroll(object sender, EventArgs e)
        {
            lblMin9.Text = "" + tbMin9.Value;
        }
        
    }
}
