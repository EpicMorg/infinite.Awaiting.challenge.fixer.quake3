namespace Infinite_Awaiting_challenge_fixer_for_Quake3 {
    partial class frm_main {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.btn_patch = new System.Windows.Forms.Button();
            this.btn_unpatch = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_null1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(12, 66);
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(374, 194);
            this.txt_log.TabIndex = 0;
            this.txt_log.Text = "";
            // 
            // btn_patch
            // 
            this.btn_patch.Location = new System.Drawing.Point(121, 266);
            this.btn_patch.Name = "btn_patch";
            this.btn_patch.Size = new System.Drawing.Size(75, 23);
            this.btn_patch.TabIndex = 1;
            this.btn_patch.Text = "btn_patch";
            this.btn_patch.UseVisualStyleBackColor = true;
            this.btn_patch.Click += new System.EventHandler(this.btn_patch_Click);
            // 
            // btn_unpatch
            // 
            this.btn_unpatch.Location = new System.Drawing.Point(202, 266);
            this.btn_unpatch.Name = "btn_unpatch";
            this.btn_unpatch.Size = new System.Drawing.Size(75, 23);
            this.btn_unpatch.TabIndex = 2;
            this.btn_unpatch.Text = "btn_unpatch";
            this.btn_unpatch.UseVisualStyleBackColor = true;
            this.btn_unpatch.Click += new System.EventHandler(this.btn_unpatch_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_logo.Image = global::Infinite_Awaiting_challenge_fixer_for_Quake3.Properties.Resources.favicon;
            this.pic_logo.Location = new System.Drawing.Point(12, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(52, 52);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo.TabIndex = 3;
            this.pic_logo.TabStop = false;
            // 
            // lbl_null1
            // 
            this.lbl_null1.AutoSize = true;
            this.lbl_null1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_null1.Location = new System.Drawing.Point(70, 12);
            this.lbl_null1.Name = "lbl_null1";
            this.lbl_null1.Size = new System.Drawing.Size(311, 16);
            this.lbl_null1.TabIndex = 4;
            this.lbl_null1.Text = "Infinite \"Awaiting challenge\" fixer for Quake3";
            // 
            // frm_main
            // 
            this.AcceptButton = this.btn_patch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 301);
            this.Controls.Add(this.lbl_null1);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.btn_unpatch);
            this.Controls.Add(this.btn_patch);
            this.Controls.Add(this.txt_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infinite \"Awaiting challenge\" fixer for Quake3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_log;
        private System.Windows.Forms.Button btn_patch;
        private System.Windows.Forms.Button btn_unpatch;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_null1;
    }
}

