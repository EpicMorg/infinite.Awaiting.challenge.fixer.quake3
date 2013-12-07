using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Infinite_Awaiting_challenge_fixer_for_Quake3 {
    public partial class frm_main : Form {
        string lng = CultureInfo.CurrentUICulture.LCID.ToString();
        string hosts = Environment.GetFolderPath(Environment.SpecialFolder.System).ToString() + "\\drivers\\etc\\hosts";
         

        private bool patch_status = false;
        public frm_main() {
            InitializeComponent();
        //    patchStatus();
        }

        private void patchStatus() {
            if (patch_status == false) {
                btn_patch.Enabled = true;
                btn_unpatch.Enabled = false;
            }
            else {
                btn_patch.Enabled = false;
                btn_unpatch.Enabled = true;
            }
        }

        private void FlushDNS() {
            try {
                new Process {
                    StartInfo = {
                        FileName = "ipconfig",
                        Arguments = "/flushdns",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                }.Start();
            }
            catch (Exception ex) { 
                if (lng == "1049") {
                    rtxt_log.AppendText(Environment.NewLine + "Не удалось сбросить кэш DNS!" + Environment.NewLine + Environment.NewLine + ex);
                }
                else {
                    {
                        rtxt_log.AppendText(Environment.NewLine + "Failed to flush the DNS cache!" + Environment.NewLine + Environment.NewLine + ex);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) { 
            if (lng == "1049") { 
                rtxt_log.Text = "Данный патч может исправить ошибку, когда у вас бесконечно висит"; 
                rtxt_log.AppendText(" ''Awaiting challenge'' ");
                rtxt_log.AppendText("в игре Quake3." + Environment.NewLine + "------------------------------------------------------------------------" + Environment.NewLine +
                "Патч добавляет в файл hosts следующие записи:" + Environment.NewLine + Environment.NewLine +    
                "127.0.0.1 q3a1.evenbalance.com" + Environment.NewLine +   
                "127.0.0.1 q3a2.evenbalance.com" + Environment.NewLine +   
                "127.0.0.1 pbq3a.idsoftware.com" + Environment.NewLine +  
                "127.0.0.1 master1.evenbalance.com" + Environment.NewLine +  
                "127.0.0.1 master2.evenbalance.com" + Environment.NewLine +  
                "127.0.0.1 master3.evenbalance.com" + Environment.NewLine +  
                "127.0.0.1 master4.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 namereg.evenbalance.com" + Environment.NewLine +  
                "127.0.0.1 authorize.quake3arena.com");
                btn_patch.Text = "Применить";
                btn_unpatch.Text = "Откатить";
            }
            else {
                rtxt_log.Text = "This patch may fix this problem when you have infinitely hanging";
                rtxt_log.AppendText(" ''Awaiting challenge'' ");
                rtxt_log.AppendText("in Quake3." + Environment.NewLine + "------------------------------------------------------------------------" + Environment.NewLine +
                "Patch adding into hosts-file this strings:" + Environment.NewLine + Environment.NewLine + 
                "127.0.0.1 q3a1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 q3a2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 pbq3a.idsoftware.com" + Environment.NewLine +
                "127.0.0.1 master1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master3.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master4.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 namereg.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 authorize.quake3arena.com");
                btn_patch.Text = "Patch";
                btn_unpatch.Text = "Unpatch";
          
            } 
        }

        private void btn_patch_Click(object sender, EventArgs e) {
            try {
                rtxt_log.Text = "";
                rtxt_log.ForeColor = Color.Green;
                if (lng == "1049") {
                    rtxt_log.AppendText("Добавление записей" + Environment.NewLine + Environment.NewLine +
                "127.0.0.1 q3a1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 q3a2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 pbq3a.idsoftware.com" + Environment.NewLine +
                "127.0.0.1 master1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master3.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master4.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 namereg.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 authorize.quake3arena.com" + Environment.NewLine + Environment.NewLine +
                "из файла: " + hosts + Environment.NewLine + Environment.NewLine +"Очистка DNS кэша..."+ Environment.NewLine);
                    rtxt_log.AppendText(Environment.NewLine + "------------------------------------------------------------------------" + Environment.NewLine + "Патч применен успешно!");
           
                }
                else {
                    rtxt_log.AppendText("Adding entries" + Environment.NewLine + Environment.NewLine +
                 "127.0.0.1 q3a1.evenbalance.com" + Environment.NewLine +
                 "127.0.0.1 q3a2.evenbalance.com" + Environment.NewLine +
                 "127.0.0.1 pbq3a.idsoftware.com" + Environment.NewLine +
                 "127.0.0.1 master1.evenbalance.com" + Environment.NewLine +
                 "127.0.0.1 master2.evenbalance.com" + Environment.NewLine +
                 "127.0.0.1 master3.evenbalance.com" + Environment.NewLine +
                 "127.0.0.1 master4.evenbalance.com" + Environment.NewLine +
                 "127.0.0.1 namereg.evenbalance.com" + Environment.NewLine +
                 "127.0.0.1 authorize.quake3arena.com" + Environment.NewLine + Environment.NewLine +
                 "from file: " + hosts + Environment.NewLine + Environment.NewLine + "Flushing the DNS cache..." + Environment.NewLine);
                    rtxt_log.AppendText(Environment.NewLine + "------------------------------------------------------------------------" + Environment.NewLine + "Patching successfully Done!");
                }
             
                //WRIGTHING BLOCK//
                System.IO.File.AppendAllText(hosts,"127.0.0.1 q3a1.evenbalance.com" + Environment.NewLine + 
               "127.0.0.1 q3a2.evenbalance.com"   + Environment.NewLine + 
               "127.0.0.1 pbq3a.idsoftware.com"    + Environment.NewLine + 
               "127.0.0.1 master1.evenbalance.com"   + Environment.NewLine + 
               "127.0.0.1 master2.evenbalance.com"   + Environment.NewLine + 
               "127.0.0.1 master3.evenbalance.com"    + Environment.NewLine + 
               "127.0.0.1 master4.evenbalance.com"   + Environment.NewLine + 
               "127.0.0.1 namereg.evenbalance.com"    + Environment.NewLine + 
               "127.0.0.1 authorize.quake3arena.com"  + Environment.NewLine); 
            }
            catch (Exception ex) {
                rtxt_log.ForeColor = Color.Red;
                rtxt_log.Text = "Error writing file!";
                rtxt_log.AppendText(Environment.NewLine + Environment.NewLine + ex + Environment.NewLine + Environment.NewLine + "Try to run as Admin?"); 
            }
            finally { 
                patch_status = true;
                patchStatus();
                FlushDNS();
            }  
        }


        private void btn_unpatch_Click(object sender, EventArgs e) {
            rtxt_log.Text = "";
            rtxt_log.ForeColor = Color.OrangeRed;
            try {

                if (lng == "1049") {
                    rtxt_log.AppendText("Удаление записей" + Environment.NewLine + Environment.NewLine +
                "127.0.0.1 q3a1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 q3a2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 pbq3a.idsoftware.com" + Environment.NewLine +
                "127.0.0.1 master1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master3.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master4.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 namereg.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 authorize.quake3arena.com" + Environment.NewLine + Environment.NewLine +
                "из файла: " + hosts + Environment.NewLine + Environment.NewLine + "Очистка DNS кэша..." + Environment.NewLine);
                    rtxt_log.AppendText(Environment.NewLine + "------------------------------------------------------------------------" + Environment.NewLine + "Откат патча произведен успешно!");  
                }
                else {
                    rtxt_log.AppendText("Removing entries" + Environment.NewLine + Environment.NewLine +
                "127.0.0.1 q3a1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 q3a2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 pbq3a.idsoftware.com" + Environment.NewLine +
                "127.0.0.1 master1.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master2.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master3.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 master4.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 namereg.evenbalance.com" + Environment.NewLine +
                "127.0.0.1 authorize.quake3arena.com" + Environment.NewLine + Environment.NewLine +
                "from file: " + hosts + Environment.NewLine + Environment.NewLine + "Flushing the DNS cache..." + Environment.NewLine);
                    rtxt_log.AppendText(Environment.NewLine + "------------------------------------------------------------------------" + Environment.NewLine + "Unpatching successfully Done!");
                }

                //WRIGTHING BLOCK//
                StreamReader sr = new StreamReader(hosts);
                string s = sr.ReadToEnd();
                sr.Close();
                s = s.Replace("\r\n127.0.0.1 q3a1.evenbalance.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 q3a2.evenbalance.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 pbq3a.idsoftware.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 master1.evenbalance.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 master2.evenbalance.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 master3.evenbalance.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 master4.evenbalance.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 namereg.evenbalance.com", string.Empty);
                s = s.Replace("\r\n127.0.0.1 authorize.quake3arena.com", string.Empty);
                StreamWriter sw = new StreamWriter(hosts, false);
                sw.Write(s);
                sw.Close();
            }
            catch (Exception ex) { 
                rtxt_log.ForeColor = Color.Red;
                rtxt_log.Text = "Error reading file!";
                rtxt_log.AppendText(Environment.NewLine + Environment.NewLine + ex + Environment.NewLine + Environment.NewLine + "Try to run as Admin?");
            }
            finally {  
                patch_status = false;
                patchStatus();
                FlushDNS();
            }
        }

        private void lnl_null3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/stamepicmorg/infinite.Awaiting.challenge.fixer.quake3");
        }

      
    }
}
