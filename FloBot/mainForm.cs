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

           
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            tbRestHP_Scroll(null, null);
            tbEmHP_Scroll(null, null);
            tbRestMP_Scroll(null, null);
            tbEmMP_Scroll(null, null);
            initAttacks();
            machine = new StateMachine(this, player);
        }
        private void initAttacks()
        {
            Console.WriteLine("AttArraySizeBefor:{0}\nBuffArrayBefor{1}:", player.AttArray.Count, player.BuffArray.Count);
            rbBuff1_Changed(null, null);
            rbBuff2_Changed(null, null);
            rbBuff3_Changed(null, null);
            rbBuff4_Changed(null, null);
            rbBuff9_CheckedChanged(null, null);

            Console.WriteLine("AttArraySizAfter:{0}\nBuffArrayAfter:{1}\n_____________", player.AttArray.Count, player.BuffArray.Count);
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
        
        private void rbBuff1_Changed(object sender, EventArgs e)
        {
            lblMax1M.Text = tbMax1M.Value + "%";
            lblMin1M.Text = tbMin1M.Value + "%";
            lblMax1P.Text = tbMax1P.Value + "%";
            lblMin1P.Text = tbMin1P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad1,0,0,0,0,0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad1, 0, 0, 0, 0, 0));

            if (cbUseSkill1.Checked)
            {
                if (rbBuff1.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay1.Text, tbCast1.Text, Keys.NumPad1, tbMax1M.Value, tbMin1M.Value,tbMax1P.Value,tbMin1P.Value,(int)nudPrio1.Value));
                if(rbAtt1.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay1.Text, tbCast1.Text, Keys.NumPad1, tbMax1M.Value, tbMin1M.Value, tbMax1P.Value, tbMin1P.Value, (int)nudPrio1.Value));
            }
                
                    

        }


        private void rbBuff2_Changed(object sender, EventArgs e)
        {
            lblMax2M.Text = tbMax2M.Value + "%";
            lblMin2M.Text = tbMin2M.Value + "%";
            lblMax2P.Text = tbMax2P.Value + "%";
            lblMin2P.Text = tbMin2P.Value + "%";
            player.removeElement(player.AttArray, new Skill("","", Keys.NumPad2, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad2, 0, 0, 0, 0, 0));

            if (cbUseSkill2.Checked)
            {
                if (rbBuff2.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay2.Text, tbCast2.Text, Keys.NumPad2, tbMax2M.Value, tbMin2M.Value, tbMax2P.Value, tbMin2P.Value, (int)nudPrio2.Value));
                if (rbAtt2.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay2.Text, tbCast2.Text, Keys.NumPad2, tbMax2M.Value, tbMin2M.Value, tbMax2P.Value, tbMin2P.Value, (int)nudPrio2.Value));
            }


        }


        private void rbBuff3_Changed(object sender, EventArgs e)
        {
            lblMax3M.Text = tbMax3M.Value + "%";
            lblMin3M.Text = tbMin3M.Value + "%";
            lblMax3P.Text = tbMax3P.Value + "%";
            lblMin3P.Text = tbMin3P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad3, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad3, 0, 0, 0, 0, 0));

            if (cbUseSkill3.Checked)
            {
                if (rbBuff3.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay3.Text, tbCast3.Text, Keys.NumPad3, tbMax3M.Value, tbMin3M.Value, tbMax3P.Value, tbMin3P.Value, (int)nudPrio3.Value));
                if (rbAtt3.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay3.Text, tbCast3.Text, Keys.NumPad3, tbMax3M.Value, tbMin3M.Value, tbMax3P.Value, tbMin3P.Value, (int)nudPrio3.Value));
            }
        }
        private void rbBuff4_Changed(object sender, EventArgs e)
        {
            lblMax4M.Text = tbMax4M.Value + "%";
            lblMin4M.Text = tbMin4M.Value + "%";
            lblMax4P.Text = tbMax4P.Value + "%";
            lblMin4P.Text = tbMin4P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad4, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad4, 0, 0, 0, 0, 0));

            if (cbUseSkill4.Checked)
            {
                if (rbBuff4.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay4.Text, tbCast4.Text, Keys.NumPad4, tbMax4M.Value, tbMin4M.Value, tbMax4P.Value, tbMin4P.Value, (int)nudPrio4.Value));
                if (rbAtt4.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay4.Text, tbCast4.Text, Keys.NumPad4, tbMax4M.Value, tbMin4M.Value, tbMax4P.Value, tbMin4P.Value, (int)nudPrio4.Value));
            }
        }

        private void rbBuff9_CheckedChanged(object sender, EventArgs e)
        {
            /*
            lblMax9M.Text = tbMax9M.Value + "%";
            lblMin9M.Text = tbMin9M.Value + "%";
            lblMax9P.Text = tbMax9P.Value + "%";
            lblMin9P.Text = tbMin9P.Value + "%";
            player.removeElement(player.AttArray, new Skill(0, 0, Keys.NumPad9, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill(0, 0, Keys.NumPad9, 0, 0, 0, 0, 0));

            if (cbUseSkill9.Checked)
            {
                int delay = 0;
                int cast = 0;
                Int32.TryParse(tbDelay9.Text, out delay);
                Int32.TryParse(tbCast9.Text, out cast);
                if (rbBuff9.Checked)
                    player.addElement(player.BuffArray, new Skill(delay, cast, Keys.NumPad9, tbMax9M.Value, tbMin9M.Value, tbMax9P.Value, tbMin9P.Value, (int)nudPrio9.Value));
                if (rbAtt9.Checked)
                    player.addElement(player.BuffArray, new Skill(delay, cast, Keys.NumPad9, tbMax9M.Value, tbMin9M.Value, tbMax9P.Value, tbMin9P.Value, (int)nudPrio9.Value));
            }*/
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

       

        private void tbMax9_Scroll(object sender, EventArgs e)
        {
            lblMax9.Text = "" + tbMax9.Value;
        }

        private void tbMin9_Scroll(object sender, EventArgs e)
        {
            lblMin9.Text = "" + tbMin9.Value;
        }

        private void cbEnableCombatState_CheckedChanged(object sender, EventArgs e)
        {
            initAttacks();
        }

        private void tbProcessName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbUseSkill4_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void rbBuff4_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void rbAtt4_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void tbDelay4_TextChanged(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void tbCast4_TextChanged(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void nudPrio4_ValueChanged(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void tbMax4M_Scroll(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void tbMin4M_Scroll(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void tbMax4P_Scroll(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }

        private void tbMin4P_Scroll(object sender, EventArgs e)
        {
            rbBuff4_Changed(null, null);
        }
    }
}
