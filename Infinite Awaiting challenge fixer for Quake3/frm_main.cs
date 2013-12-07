using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Infinite_Awaiting_challenge_fixer_for_Quake3 {
    public partial class frm_main : Form {
        string lng = CultureInfo.CurrentUICulture.LCID.ToString();
        string sys32 = Environment.GetFolderPath(Environment.SpecialFolder.System).ToString(); 
        public frm_main() {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e) {
           // MessageBox.Show(lng);
            if (lng == "1049") {
                // MessageBox.Show(sys32);
            }
            else {
                
            }
        }

        private void btn_patch_Click(object sender, EventArgs e) {

        }


        private void btn_unpatch_Click(object sender, EventArgs e) {
            try {
                StreamReader sr = new StreamReader("path");
                string s = sr.ReadToEnd();
                sr.Close();
                s = s.Replace("text 123", "");
                StreamWriter sw = new StreamWriter("path", false);
                sw.Write(s);
                sw.Close();
            }
            catch (Exception ex) { }
            finally { 
             
            }
        }

      
    }
}
