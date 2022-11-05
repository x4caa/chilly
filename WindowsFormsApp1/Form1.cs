using Memory;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();
        public float startingfov;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        public Form1()
        {
            InitializeComponent();
            tmr_check.Enabled = true;
        }

        void Timer(double timer)
        {
            m.OpenProcess("minecraft.windows");
            m.WriteMemory("Minecraft.Windows.exe+3F108D0", "double", timer.ToString());
        }
        public Vector3 Position()
        {
            Vector3 feetpos = new Vector3(m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,18,B8,3F0"), m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,20,C8,3F4"), m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,18,B8,3F8"));
            return feetpos;
        }
        void Reach(float reach)
        {
            m.OpenProcess("minecraft.windows");
            m.WriteMemory("Minecraft.Windows.exe+3F10808", "float", reach.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
            Debug.WriteLine("form loaded");

            if (m != null)
            {
                Debug.WriteLine("thread loaded");
                Thread thread = new Thread(Main) { IsBackground = true };
                thread.Start();
                m.OpenProcess("minecraft.windows");
            }
        }

        void Main()
        {
            startingfov = 70f;
            while (true)
            {
                if (GetAsyncKeyState(Keys.C) < 0)
                {
                    m.WriteMemory(Offsets.fov, "float", "30");
                }
                else
                {
                    m.WriteMemory(Offsets.fov, "float", startingfov.ToString());
                }
                Thread.Sleep(10);
            }
        }

        private void checkbox_timer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_timer.Checked == true) { Timer(trackbar_timer.Value); trackbar_timer.Enabled = true; }
            else { Timer(1000f); trackbar_timer.Enabled = false; }
        }

        private void checkbox_reach_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_reach.Checked == true) { Reach(trackbar_reach.Value); trackbar_reach.Enabled = true; }
            else { Reach(3f); trackbar_reach.Enabled = false; }
        }

        private void checkbox_fly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_fly.Checked == true)
            {
                m.OpenProcess("minecraft.windows.exe");
                m.FreezeValue("Minecraft.Windows.exe+04926308,10,18,b8,a48", "byte", "1");
            }
            else
            {
                m.UnfreezeValue("Minecraft.Windows.exe+04926308,10,18,b8,a48");
                m.WriteMemory("Minecraft.Windows.exe+04926308,10,18,b8,a48", "byte", "0");
            }
        }

        private void checkbox_noclip_CheckedChanged(object sender, EventArgs e)
        {
            float feetyval = m.ReadFloat(Offsets.feety);
            if (checkbox_noclip.Checked == true)
            {
                m.OpenProcess("minecraft.windows.exe");
                m.WriteMemory(Offsets.heady, "float", feetyval.ToString());
            }
            else
            {

                m.WriteMemory(Offsets.heady, "float", (feetyval + 1.800000906).ToString());
            }
        }

        private void trackbar_timer_Scroll(object sender, EventArgs e)
        {
            Timer(trackbar_timer.Value);
            lbl_timer.Text = trackbar_timer.Value.ToString();
        }

        private void trackbar_reach_Scroll(object sender, EventArgs e)
        {
            Reach(trackbar_reach.Value);
            lbl_reach.Text = trackbar_reach.Value.ToString();
        }

        private void tmr_check_Tick(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcessesByName("minecraft.windows");



            if (process.Length == 0)
            {
                checkbox_timer.Enabled = false;
                checkbox_reach.Enabled = false;
                checkbox_fly.Enabled = false;
                checkbox_noclip.Enabled = false;
                lbl_status.Text = "No process";
                lbl_status.ForeColor = Color.Red;
            }
            else
            {
                checkbox_timer.Enabled = true;
                checkbox_reach.Enabled = true;
                checkbox_fly.Enabled = true;
                checkbox_noclip.Enabled = true;
                if (checkbox_timer.Checked == true) { trackbar_timer.Enabled = true; }
                if (checkbox_reach.Checked == true) { trackbar_reach.Enabled = true; }
                lbl_status.Text = "Process Found";
                lbl_status.ForeColor = Color.Green;
                //textBox1.Text = new Vector3(m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,18,B8,3F0"), m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,20,C8,3F4"), m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,18,B8,3F8")).ToString();
                //Debug.WriteLine(new Vector3(m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,18,B8,3F0"), m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,20,C8,3F4"), m.ReadFloat("Minecraft.Windows.exe+04926308,20,0,18,B8,3F8")).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.OpenProcess("minecraft.windows.exe");
            m.WriteMemory(Offsets.feetx, "float", xpos.Value.ToString());
            m.WriteMemory(Offsets.feety, "float", ypos.Value.ToString());
            m.WriteMemory(Offsets.feetz, "float", zpos.Value.ToString());
            m.WriteMemory(Offsets.headx, "float", (float.Parse(xpos.Value.ToString()) + 0.7168208957).ToString());
            m.WriteMemory(Offsets.heady, "float", (float.Parse(ypos.Value.ToString()) + 1.799999952).ToString());
            m.WriteMemory(Offsets.headz, "float", (float.Parse(zpos.Value.ToString()) + 0.7140606046).ToString());
            // make velocity next!!!!
        }

        private void antikb_CheckedChanged(object sender, EventArgs e)
        {
            if (antikb.Checked)
            {
                string a = "90 90 90 90 90 90";
                m.OpenProcess("minecraft.windows.exe");
                m.WriteMemory(Offsets.antikbx, "bytes", a);
                m.WriteMemory(Offsets.antikby, "bytes", a);
                m.WriteMemory(Offsets.antikbz, "bytes", a);
            }
            else
            {
                m.WriteMemory(Offsets.antikbx, "bytes", "89 81 28 04 00 00");
                m.WriteMemory(Offsets.antikby, "bytes", "89 81 2C 04 00 00");
                m.WriteMemory(Offsets.antikbz, "bytes", "89 81 30 04 00 00");
            }
        }

        private void checkbox_step_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_step.Checked)
            {
                m.OpenProcess("minecraft.windows.exe");
                m.WriteMemory(Offsets.step, "double", "2");
            }
            else
            {
                m.WriteMemory(Offsets.step, "double", "0.00006103515625");
            }
        }

        private void namebutton_Click(object sender, EventArgs e)
        {
            m.OpenProcess("minecraft.windows.exe");
            m.WriteMemory(Offsets.name, "string", nametext.Text);
            m.WriteMemory(Offsets.namelength, "int", nametext.Text.Length.ToString());

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hitbox.Checked)
            {
                m.OpenProcess("minecraft.windows.exe");
                m.WriteMemory(Offsets.hitboxwidth, "float", "6");
            }
            else
            {
                m.WriteMemory(Offsets.hitboxwidth, "float", "0.6");
            }
        }
    }
}
