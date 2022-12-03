
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.xtext = new System.Windows.Forms.TextBox();
            this.ytext = new System.Windows.Forms.TextBox();
            this.ztext = new System.Windows.Forms.TextBox();
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
            this.checkbox_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.checkbox_timer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_timer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_timer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_timer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_timer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_timer.Location = new System.Drawing.Point(16, 16);
            this.checkbox_timer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbox_timer.Name = "checkbox_timer";
            this.checkbox_timer.Size = new System.Drawing.Size(64, 21);
            this.checkbox_timer.TabIndex = 0;
            this.checkbox_timer.Text = "Timer";
            this.checkbox_timer.UseVisualStyleBackColor = false;
            this.checkbox_timer.CheckedChanged += new System.EventHandler(this.checkbox_timer_CheckedChanged);
            // 
            // checkbox_reach
            // 
            this.checkbox_reach.AutoSize = true;
            this.checkbox_reach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.checkbox_reach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_reach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_reach.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_reach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_reach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_reach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_reach.Location = new System.Drawing.Point(16, 46);
            this.checkbox_reach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbox_reach.Name = "checkbox_reach";
            this.checkbox_reach.Size = new System.Drawing.Size(73, 21);
            this.checkbox_reach.TabIndex = 1;
            this.checkbox_reach.Text = "Reach";
            this.checkbox_reach.UseVisualStyleBackColor = false;
            this.checkbox_reach.CheckedChanged += new System.EventHandler(this.checkbox_reach_CheckedChanged);
            // 
            // checkbox_fly
            // 
            this.checkbox_fly.AutoSize = true;
            this.checkbox_fly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.checkbox_fly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_fly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_fly.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_fly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_fly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_fly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_fly.Location = new System.Drawing.Point(16, 76);
            this.checkbox_fly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbox_fly.Name = "checkbox_fly";
            this.checkbox_fly.Size = new System.Drawing.Size(49, 21);
            this.checkbox_fly.TabIndex = 2;
            this.checkbox_fly.Text = "Fly";
            this.checkbox_fly.UseVisualStyleBackColor = false;
            this.checkbox_fly.CheckedChanged += new System.EventHandler(this.checkbox_fly_CheckedChanged);
            // 
            // checkbox_noclip
            // 
            this.checkbox_noclip.AutoSize = true;
            this.checkbox_noclip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.checkbox_noclip.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkbox_noclip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_noclip.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_noclip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_noclip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_noclip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_noclip.Font = new System.Drawing.Font("Mojangles", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_noclip.Location = new System.Drawing.Point(16, 106);
            this.checkbox_noclip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbox_noclip.Name = "checkbox_noclip";
            this.checkbox_noclip.Size = new System.Drawing.Size(71, 21);
            this.checkbox_noclip.TabIndex = 3;
            this.checkbox_noclip.Text = "NoClip";
            this.checkbox_noclip.UseVisualStyleBackColor = false;
            this.checkbox_noclip.CheckedChanged += new System.EventHandler(this.checkbox_noclip_CheckedChanged);
            // 
            // trackbar_timer
            // 
            this.trackbar_timer.AutoSize = false;
            this.trackbar_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.trackbar_timer.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackbar_timer.Enabled = false;
            this.trackbar_timer.Location = new System.Drawing.Point(101, 16);
            this.trackbar_timer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackbar_timer.Maximum = 5000;
            this.trackbar_timer.Minimum = 1000;
            this.trackbar_timer.Name = "trackbar_timer";
            this.trackbar_timer.Size = new System.Drawing.Size(131, 22);
            this.trackbar_timer.TabIndex = 5;
            this.trackbar_timer.Value = 1000;
            this.trackbar_timer.Scroll += new System.EventHandler(this.trackbar_timer_Scroll);
            // 
            // trackbar_reach
            // 
            this.trackbar_reach.AutoSize = false;
            this.trackbar_reach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.trackbar_reach.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackbar_reach.Enabled = false;
            this.trackbar_reach.LargeChange = 1;
            this.trackbar_reach.Location = new System.Drawing.Point(101, 46);
            this.trackbar_reach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackbar_reach.Maximum = 7;
            this.trackbar_reach.Minimum = 3;
            this.trackbar_reach.Name = "trackbar_reach";
            this.trackbar_reach.Size = new System.Drawing.Size(131, 22);
            this.trackbar_reach.TabIndex = 6;
            this.trackbar_reach.Value = 3;
            this.trackbar_reach.Scroll += new System.EventHandler(this.trackbar_reach_Scroll);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Mojangles", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(174, 249);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(31, 16);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "N/A";
            this.lbl_status.Click += new System.EventHandler(this.lbl_status_Click);
            // 
            // lbl_reach
            // 
            this.lbl_reach.AutoSize = true;
            this.lbl_reach.Location = new System.Drawing.Point(240, 48);
            this.lbl_reach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reach.Name = "lbl_reach";
            this.lbl_reach.Size = new System.Drawing.Size(36, 17);
            this.lbl_reach.TabIndex = 8;
            this.lbl_reach.Text = "N/A";
            this.lbl_reach.Click += new System.EventHandler(this.lbl_reach_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(240, 18);
            this.lbl_timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(36, 17);
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
            this.tpbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.tpbutton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tpbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.tpbutton.FlatAppearance.BorderSize = 3;
            this.tpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tpbutton.Location = new System.Drawing.Point(113, 195);
            this.tpbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpbutton.Name = "tpbutton";
            this.tpbutton.Size = new System.Drawing.Size(53, 70);
            this.tpbutton.TabIndex = 13;
            this.tpbutton.Text = "TP";
            this.tpbutton.UseVisualStyleBackColor = false;
            this.tpbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // zpos
            // 
            this.zpos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.zpos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(184)))), ((int)(((byte)(244)))));
            this.zpos.Location = new System.Drawing.Point(16, 241);
            this.zpos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.zpos.Size = new System.Drawing.Size(89, 20);
            this.zpos.TabIndex = 16;
            // 
            // ypos
            // 
            this.ypos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.ypos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ypos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(184)))), ((int)(((byte)(244)))));
            this.ypos.Location = new System.Drawing.Point(16, 217);
            this.ypos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ypos.Size = new System.Drawing.Size(89, 20);
            this.ypos.TabIndex = 17;
            // 
            // xpos
            // 
            this.xpos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.xpos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(184)))), ((int)(((byte)(244)))));
            this.xpos.Location = new System.Drawing.Point(16, 195);
            this.xpos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.xpos.Size = new System.Drawing.Size(89, 20);
            this.xpos.TabIndex = 18;
            // 
            // antikb
            // 
            this.antikb.AutoSize = true;
            this.antikb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.antikb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.antikb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.antikb.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.antikb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.antikb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.antikb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.antikb.Location = new System.Drawing.Point(16, 166);
            this.antikb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.antikb.Name = "antikb";
            this.antikb.Size = new System.Drawing.Size(72, 21);
            this.antikb.TabIndex = 19;
            this.antikb.Text = "antiKB";
            this.antikb.UseVisualStyleBackColor = false;
            this.antikb.CheckedChanged += new System.EventHandler(this.antikb_CheckedChanged);
            // 
            // checkbox_step
            // 
            this.checkbox_step.AutoSize = true;
            this.checkbox_step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.checkbox_step.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_step.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_step.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_step.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_step.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(71)))), ((int)(((byte)(233)))));
            this.checkbox_step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_step.Location = new System.Drawing.Point(16, 136);
            this.checkbox_step.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbox_step.Name = "checkbox_step";
            this.checkbox_step.Size = new System.Drawing.Size(59, 21);
            this.checkbox_step.TabIndex = 20;
            this.checkbox_step.Text = "Step";
            this.checkbox_step.UseVisualStyleBackColor = false;
            this.checkbox_step.CheckedChanged += new System.EventHandler(this.checkbox_step_CheckedChanged);
            // 
            // xtext
            // 
            this.xtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(3)))), ((int)(((byte)(59)))));
            this.xtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtext.Cursor = System.Windows.Forms.Cursors.Default;
            this.xtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(184)))), ((int)(((byte)(244)))));
            this.xtext.Location = new System.Drawing.Point(5, 197);
            this.xtext.Name = "xtext";
            this.xtext.Size = new System.Drawing.Size(10, 17);
            this.xtext.TabIndex = 22;
            this.xtext.Text = "X";
            // 
            // ytext
            // 
            this.ytext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(3)))), ((int)(((byte)(59)))));
            this.ytext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ytext.Cursor = System.Windows.Forms.Cursors.Default;
            this.ytext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(184)))), ((int)(((byte)(244)))));
            this.ytext.Location = new System.Drawing.Point(5, 220);
            this.ytext.Name = "ytext";
            this.ytext.Size = new System.Drawing.Size(10, 17);
            this.ytext.TabIndex = 23;
            this.ytext.Text = "Y";
            // 
            // ztext
            // 
            this.ztext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(3)))), ((int)(((byte)(59)))));
            this.ztext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ztext.Cursor = System.Windows.Forms.Cursors.Default;
            this.ztext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(184)))), ((int)(((byte)(244)))));
            this.ztext.Location = new System.Drawing.Point(5, 244);
            this.ztext.Name = "ztext";
            this.ztext.Size = new System.Drawing.Size(10, 17);
            this.ztext.TabIndex = 24;
            this.ztext.Text = "Z";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(3)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(289, 274);
            this.Controls.Add(this.ztext);
            this.Controls.Add(this.ytext);
            this.Controls.Add(this.xtext);
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
            this.Font = new System.Drawing.Font("Mojangles", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(184)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chilly";
            this.TopMost = true;
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
        private System.Windows.Forms.TextBox xtext;
        private System.Windows.Forms.TextBox ytext;
        private System.Windows.Forms.TextBox ztext;
    }
}

