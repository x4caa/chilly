
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkbox_timer = new System.Windows.Forms.CheckBox();
            this.checkbox_reach = new System.Windows.Forms.CheckBox();
            this.checkbox_fly = new System.Windows.Forms.CheckBox();
            this.checkbox_noclip = new System.Windows.Forms.CheckBox();
            this.trackbar_timer = new System.Windows.Forms.TrackBar();
            this.trackbar_reach = new System.Windows.Forms.TrackBar();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_reach = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.tmr_check = new System.Windows.Forms.Timer(this.components);
            this.tpbutton = new System.Windows.Forms.Button();
            this.zpos = new System.Windows.Forms.NumericUpDown();
            this.ypos = new System.Windows.Forms.NumericUpDown();
            this.xpos = new System.Windows.Forms.NumericUpDown();
            this.antikb = new System.Windows.Forms.CheckBox();
            this.checkbox_step = new System.Windows.Forms.CheckBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.namebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_reach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ypos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpos)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbox_timer
            // 
            this.checkbox_timer.AccessibleName = "";
            this.checkbox_timer.AutoSize = true;
            this.checkbox_timer.Enabled = false;
            this.checkbox_timer.Location = new System.Drawing.Point(12, 12);
            this.checkbox_timer.Name = "checkbox_timer";
            this.checkbox_timer.Size = new System.Drawing.Size(52, 17);
            this.checkbox_timer.TabIndex = 0;
            this.checkbox_timer.Text = "Timer";
            this.checkbox_timer.UseVisualStyleBackColor = true;
            this.checkbox_timer.CheckedChanged += new System.EventHandler(this.checkbox_timer_CheckedChanged);
            // 
            // checkbox_reach
            // 
            this.checkbox_reach.AutoSize = true;
            this.checkbox_reach.Enabled = false;
            this.checkbox_reach.Location = new System.Drawing.Point(12, 35);
            this.checkbox_reach.Name = "checkbox_reach";
            this.checkbox_reach.Size = new System.Drawing.Size(58, 17);
            this.checkbox_reach.TabIndex = 1;
            this.checkbox_reach.Text = "Reach";
            this.checkbox_reach.UseVisualStyleBackColor = true;
            this.checkbox_reach.CheckedChanged += new System.EventHandler(this.checkbox_reach_CheckedChanged);
            // 
            // checkbox_fly
            // 
            this.checkbox_fly.AutoSize = true;
            this.checkbox_fly.Enabled = false;
            this.checkbox_fly.Location = new System.Drawing.Point(12, 58);
            this.checkbox_fly.Name = "checkbox_fly";
            this.checkbox_fly.Size = new System.Drawing.Size(39, 17);
            this.checkbox_fly.TabIndex = 2;
            this.checkbox_fly.Text = "Fly";
            this.checkbox_fly.UseVisualStyleBackColor = true;
            this.checkbox_fly.CheckedChanged += new System.EventHandler(this.checkbox_fly_CheckedChanged);
            // 
            // checkbox_noclip
            // 
            this.checkbox_noclip.AutoSize = true;
            this.checkbox_noclip.Enabled = false;
            this.checkbox_noclip.Location = new System.Drawing.Point(12, 81);
            this.checkbox_noclip.Name = "checkbox_noclip";
            this.checkbox_noclip.Size = new System.Drawing.Size(56, 17);
            this.checkbox_noclip.TabIndex = 3;
            this.checkbox_noclip.Text = "Noclip";
            this.checkbox_noclip.UseVisualStyleBackColor = true;
            this.checkbox_noclip.CheckedChanged += new System.EventHandler(this.checkbox_noclip_CheckedChanged);
            // 
            // trackbar_timer
            // 
            this.trackbar_timer.AutoSize = false;
            this.trackbar_timer.Enabled = false;
            this.trackbar_timer.Location = new System.Drawing.Point(76, 12);
            this.trackbar_timer.Maximum = 5000;
            this.trackbar_timer.Minimum = 1000;
            this.trackbar_timer.Name = "trackbar_timer";
            this.trackbar_timer.Size = new System.Drawing.Size(104, 17);
            this.trackbar_timer.TabIndex = 5;
            this.trackbar_timer.Value = 1000;
            this.trackbar_timer.Scroll += new System.EventHandler(this.trackbar_timer_Scroll);
            // 
            // trackbar_reach
            // 
            this.trackbar_reach.AutoSize = false;
            this.trackbar_reach.Enabled = false;
            this.trackbar_reach.LargeChange = 1;
            this.trackbar_reach.Location = new System.Drawing.Point(76, 35);
            this.trackbar_reach.Maximum = 7;
            this.trackbar_reach.Minimum = 3;
            this.trackbar_reach.Name = "trackbar_reach";
            this.trackbar_reach.Size = new System.Drawing.Size(104, 17);
            this.trackbar_reach.TabIndex = 6;
            this.trackbar_reach.Value = 3;
            this.trackbar_reach.Scroll += new System.EventHandler(this.trackbar_reach_Scroll);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(390, 225);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(27, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "N/A";
            // 
            // lbl_reach
            // 
            this.lbl_reach.AutoSize = true;
            this.lbl_reach.Location = new System.Drawing.Point(186, 39);
            this.lbl_reach.Name = "lbl_reach";
            this.lbl_reach.Size = new System.Drawing.Size(27, 13);
            this.lbl_reach.TabIndex = 8;
            this.lbl_reach.Text = "N/A";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(186, 16);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(27, 13);
            this.lbl_timer.TabIndex = 9;
            this.lbl_timer.Text = "N/A";
            // 
            // tmr_check
            // 
            this.tmr_check.Interval = 200;
            this.tmr_check.Tick += new System.EventHandler(this.tmr_check_Tick);
            // 
            // tpbutton
            // 
            this.tpbutton.BackColor = System.Drawing.Color.Maroon;
            this.tpbutton.Location = new System.Drawing.Point(232, 173);
            this.tpbutton.Name = "tpbutton";
            this.tpbutton.Size = new System.Drawing.Size(40, 40);
            this.tpbutton.TabIndex = 13;
            this.tpbutton.Text = "TP";
            this.tpbutton.UseVisualStyleBackColor = false;
            this.tpbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // zpos
            // 
            this.zpos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.zpos.ForeColor = System.Drawing.Color.White;
            this.zpos.Location = new System.Drawing.Point(159, 185);
            this.zpos.Maximum = new decimal(new int[] {
            29999984,
            0,
            0,
            0});
            this.zpos.Minimum = new decimal(new int[] {
            29999984,
            0,
            0,
            -2147483648});
            this.zpos.Name = "zpos";
            this.zpos.Size = new System.Drawing.Size(67, 20);
            this.zpos.TabIndex = 16;
            // 
            // ypos
            // 
            this.ypos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ypos.ForeColor = System.Drawing.Color.White;
            this.ypos.Location = new System.Drawing.Point(86, 185);
            this.ypos.Maximum = new decimal(new int[] {
            29999984,
            0,
            0,
            0});
            this.ypos.Minimum = new decimal(new int[] {
            29999984,
            0,
            0,
            -2147483648});
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(67, 20);
            this.ypos.TabIndex = 17;
            // 
            // xpos
            // 
            this.xpos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.xpos.ForeColor = System.Drawing.Color.White;
            this.xpos.Location = new System.Drawing.Point(13, 185);
            this.xpos.Maximum = new decimal(new int[] {
            29999984,
            0,
            0,
            0});
            this.xpos.Minimum = new decimal(new int[] {
            29999984,
            0,
            0,
            -2147483648});
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(67, 20);
            this.xpos.TabIndex = 18;
            // 
            // antikb
            // 
            this.antikb.AutoSize = true;
            this.antikb.Location = new System.Drawing.Point(12, 127);
            this.antikb.Name = "antikb";
            this.antikb.Size = new System.Drawing.Size(57, 17);
            this.antikb.TabIndex = 19;
            this.antikb.Text = "antiKB";
            this.antikb.UseVisualStyleBackColor = true;
            this.antikb.CheckedChanged += new System.EventHandler(this.antikb_CheckedChanged);
            // 
            // checkbox_step
            // 
            this.checkbox_step.AutoSize = true;
            this.checkbox_step.Location = new System.Drawing.Point(12, 104);
            this.checkbox_step.Name = "checkbox_step";
            this.checkbox_step.Size = new System.Drawing.Size(48, 17);
            this.checkbox_step.TabIndex = 20;
            this.checkbox_step.Text = "Step";
            this.checkbox_step.UseVisualStyleBackColor = true;
            this.checkbox_step.CheckedChanged += new System.EventHandler(this.checkbox_step_CheckedChanged);
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(13, 151);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(100, 20);
            this.nametext.TabIndex = 21;
            // 
            // namebutton
            // 
            this.namebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namebutton.Location = new System.Drawing.Point(119, 147);
            this.namebutton.Name = "namebutton";
            this.namebutton.Size = new System.Drawing.Size(86, 26);
            this.namebutton.TabIndex = 22;
            this.namebutton.Text = "Change Name";
            this.namebutton.UseVisualStyleBackColor = true;
            this.namebutton.Click += new System.EventHandler(this.namebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 242);
            this.Controls.Add(this.namebutton);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.checkbox_step);
            this.Controls.Add(this.antikb);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.zpos);
            this.Controls.Add(this.tpbutton);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_reach);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.trackbar_reach);
            this.Controls.Add(this.trackbar_timer);
            this.Controls.Add(this.checkbox_noclip);
            this.Controls.Add(this.checkbox_fly);
            this.Controls.Add(this.checkbox_reach);
            this.Controls.Add(this.checkbox_timer);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "xacaa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_reach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ypos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_timer;
        private System.Windows.Forms.CheckBox checkbox_reach;
        private System.Windows.Forms.CheckBox checkbox_fly;
        private System.Windows.Forms.CheckBox checkbox_noclip;
        private System.Windows.Forms.TrackBar trackbar_timer;
        private System.Windows.Forms.TrackBar trackbar_reach;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_reach;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer tmr_check;
        private System.Windows.Forms.Button tpbutton;
        private System.Windows.Forms.NumericUpDown zpos;
        private System.Windows.Forms.NumericUpDown ypos;
        private System.Windows.Forms.NumericUpDown xpos;
        private System.Windows.Forms.CheckBox antikb;
        private System.Windows.Forms.CheckBox checkbox_step;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Button namebutton;
    }
}

