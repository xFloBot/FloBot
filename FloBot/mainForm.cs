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
            rbBuff5_Changed(null, null);
            rbBuff6_Changed(null, null);
            rbBuff7_Changed(null, null);
            rbBuff8_Changed(null, null);
            rbBuff9_Changed(null, null);
            rbBuff0_Changed(null, null);

            Console.WriteLine("AttArraySizAfter:{0}\nBuffArrayAfter:{1}\n_____________", player.AttArray.Count, player.BuffArray.Count);
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            machine.endBotThread();
            googleChrome.Properties.Settings.Default.Save();
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
        private void rbBuff5_Changed(object sender, EventArgs e)
        {
            lblMax5M.Text = tbMax5M.Value + "%";
            lblMin5M.Text = tbMin5M.Value + "%";
            lblMax5P.Text = tbMax5P.Value + "%";
            lblMin5P.Text = tbMin5P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad5, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad5, 0, 0, 0, 0, 0));

            if (cbUseSkill5.Checked)
            {
                if (rbBuff5.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay5.Text, tbCast5.Text, Keys.NumPad5, tbMax5M.Value, tbMin5M.Value, tbMax5P.Value, tbMin5P.Value, (int)nudPrio5.Value));
                if (rbAtt5.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay5.Text, tbCast5.Text, Keys.NumPad5, tbMax5M.Value, tbMin5M.Value, tbMax5P.Value, tbMin5P.Value, (int)nudPrio5.Value));
            }
        }

        private void rbBuff6_Changed(object sender, EventArgs e)
        {
            lblMax6M.Text = tbMax6M.Value + "%";
            lblMin6M.Text = tbMin6M.Value + "%";
            lblMax6P.Text = tbMax6P.Value + "%";
            lblMin6P.Text = tbMin6P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad6, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad6, 0, 0, 0, 0, 0));

            if (cbUseSkill6.Checked)
            {
                if (rbBuff6.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay6.Text, tbCast6.Text, Keys.NumPad6, tbMax6M.Value, tbMin6M.Value, tbMax6P.Value, tbMin6P.Value, (int)nudPrio6.Value));
                if (rbAtt6.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay6.Text, tbCast6.Text, Keys.NumPad6, tbMax6M.Value, tbMin6M.Value, tbMax6P.Value, tbMin6P.Value, (int)nudPrio6.Value));
            }
        }

        private void rbBuff7_Changed(object sender, EventArgs e)
        {
            lblMax7M.Text = tbMax7M.Value + "%";
            lblMin7M.Text = tbMin7M.Value + "%";
            lblMax7P.Text = tbMax7P.Value + "%";
            lblMin7P.Text = tbMin7P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad7, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad7, 0, 0, 0, 0, 0));

            if (cbUseSkill7.Checked)
            {
                if (rbBuff7.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay7.Text, tbCast7.Text, Keys.NumPad7, tbMax7M.Value, tbMin7M.Value, tbMax7P.Value, tbMin7P.Value, (int)nudPrio7.Value));
                if (rbAtt7.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay7.Text, tbCast7.Text, Keys.NumPad7, tbMax7M.Value, tbMin7M.Value, tbMax7P.Value, tbMin7P.Value, (int)nudPrio7.Value));
            }
        }

        private void rbBuff8_Changed(object sender, EventArgs e)
        {
            lblMax8M.Text = tbMax8M.Value + "%";
            lblMin8M.Text = tbMin8M.Value + "%";
            lblMax8P.Text = tbMax8P.Value + "%";
            lblMin8P.Text = tbMin8P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad8, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad8, 0, 0, 0, 0, 0));

            if (cbUseSkill8.Checked)
            {
                if (rbBuff8.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay8.Text, tbCast8.Text, Keys.NumPad8, tbMax8M.Value, tbMin8M.Value, tbMax8P.Value, tbMin8P.Value, (int)nudPrio8.Value));
                if (rbAtt8.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay8.Text, tbCast8.Text, Keys.NumPad8, tbMax8M.Value, tbMin8M.Value, tbMax8P.Value, tbMin8P.Value, (int)nudPrio8.Value));
            }
        }

        private void rbBuff9_Changed(object sender, EventArgs e)
        {
            lblMax9M.Text = tbMax9M.Value + "%";
            lblMin9M.Text = tbMin9M.Value + "%";
            lblMax9P.Text = tbMax9P.Value + "%";
            lblMin9P.Text = tbMin9P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad9, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad9, 0, 0, 0, 0, 0));

            if (cbUseSkill9.Checked)
            {
                if (rbBuff9.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay9.Text, tbCast9.Text, Keys.NumPad9, tbMax9M.Value, tbMin9M.Value, tbMax9P.Value, tbMin9P.Value, (int)nudPrio9.Value));
                if (rbAtt9.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay9.Text, tbCast9.Text, Keys.NumPad9, tbMax9M.Value, tbMin9M.Value, tbMax9P.Value, tbMin9P.Value, (int)nudPrio9.Value));
            }
        }

        private void rbBuff0_Changed(object sender, EventArgs e)
        {
            lblMax0M.Text = tbMax0M.Value + "%";
            lblMin0M.Text = tbMin0M.Value + "%";
            lblMax0P.Text = tbMax0P.Value + "%";
            lblMin0P.Text = tbMin0P.Value + "%";
            player.removeElement(player.AttArray, new Skill("", "", Keys.NumPad0, 0, 0, 0, 0, 0));
            player.removeElement(player.BuffArray, new Skill("", "", Keys.NumPad0, 0, 0, 0, 0, 0));

            if (cbUseSkill0.Checked)
            {
                if (rbBuff0.Checked)
                    player.addElement(player.BuffArray, new Skill(tbDelay0.Text, tbCast0.Text, Keys.NumPad0, tbMax0M.Value, tbMin0M.Value, tbMax0P.Value, tbMin0P.Value, (int)nudPrio0.Value));
                if (rbAtt0.Checked)
                    player.addElement(player.AttArray, new Skill(tbDelay0.Text, tbCast0.Text, Keys.NumPad0, tbMax0M.Value, tbMin0M.Value, tbMax0P.Value, tbMin0P.Value, (int)nudPrio0.Value));
            }
        }

        private void cbAutoLoot_CheckedChanged(object sender, EventArgs e)
        {
            player.MobToLootCount = 0;
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

        private void tp4_Click(object sender, EventArgs e)
        {

        }

        private void tp5_Click(object sender, EventArgs e)
        {

        }

        private void cbUse5_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void rbBuff5_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void rbAtt5_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void tbDelay5_TextChanged(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void tbCast5_TextChanged(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void nudPrio5_ValueChanged(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void tbMax5M_Scroll(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void tbMin5M_Scroll(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void tbMax5P_Scroll(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void tbMin5P_Scroll(object sender, EventArgs e)
        {
            rbBuff5_Changed(null, null);
        }

        private void cbUseSkill6_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void rbBuff6_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void rbAtt6_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void tbDelay6_TextChanged(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void tbCast6_TextChanged(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void nudPrio6_ValueChanged(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void tbMax6M_Scroll(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void tbMin6M_Scroll(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void tbMax6P_Scroll(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void tbMin6P_Scroll(object sender, EventArgs e)
        {
            rbBuff6_Changed(null, null);
        }

        private void tp7_Click(object sender, EventArgs e)
        {

        }

        private void cbUseSkill7_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void rbBuff7_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void rbAtt7_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void tbDelay7_TextChanged(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void tbCast7_TextChanged(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void nudPrio7_ValueChanged(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void tbMax7M_Scroll(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void tbMin7M_Scroll(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void tbMax7P_Scroll(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void tbMin7P_Scroll(object sender, EventArgs e)
        {
            rbBuff7_Changed(null, null);
        }

        private void cbUseSkill8_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void rbBuff8_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void rbAtt8_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void tbDelay8_TextChanged(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void tbCast8_TextChanged(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void nudPrio8_ValueChanged(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void tbMax8M_Scroll(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void tbMin8M_Scroll(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void tbMax8P_Scroll(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void tbMin8P_Scroll(object sender, EventArgs e)
        {
            rbBuff8_Changed(null, null);
        }

        private void cbUseSkill9_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void rbBuff9_CheckedChanged_1(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void tbDelay9_TextChanged_1(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void tbCast9_TextChanged_1(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void nudPrio9_ValueChanged(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void tbMax9M_Scroll(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void tbMin9M_Scroll(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void tbMax9P_Scroll(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void tbMin9P_Scroll(object sender, EventArgs e)
        {
            rbBuff9_Changed(null, null);
        }

        private void cbUseSkill0_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void rbBuff0_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void rbAtt0_CheckedChanged(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void tbDelay0_TextChanged(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void tbCast0_TextChanged(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void nudPrio0_ValueChanged(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void tbMax0M_Scroll(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void tbMin0M_Scroll(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void tbMax0P_Scroll(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void tbMin0P_Scroll(object sender, EventArgs e)
        {
            rbBuff0_Changed(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String targetName = lblTarget.Text;
            if (!String.IsNullOrWhiteSpace(targetName)) 
                if (!lbWhitelist.Items.Contains(targetName))
                    lbWhitelist.Items.Add(targetName);
        }

        private void btDeleteEntry_Click(object sender, EventArgs e)
        {
            if (lbWhitelist.SelectedIndex < 0) return;
            lbWhitelist.Items.RemoveAt(lbWhitelist.SelectedIndex);
        }
    }
}
