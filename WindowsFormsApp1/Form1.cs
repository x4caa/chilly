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
            m.WriteMemory(Offsets.timer, "double", timer.ToString());
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
                Thread fovthread = new Thread(fov) { IsBackground = true };
                Thread tpthread = new Thread(pixelparadiseswimming) { IsBackground = true };
                fovthread.Start();
                tpthread.Start();
                Debug.WriteLine("thread started successfully");
                m.OpenProcess("minecraft.windows");
            }
        }

        async void fov()
        {
            //TODO: add fov changer QOL
            //NVM FUCK THIS I HATE LIFE
            //read mem for starting fov instead of setting to default of 70
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
                Thread.Sleep(1);
            }
        }

        void pixelparadiseswimming()
        {
            //thread sleep time
            int x = 40;
            while (true)
            {// map 1
                if (GetAsyncKeyState(Keys.LButton) < 0 && GetAsyncKeyState(Keys.Y) < 0)
                {
                    //checkpoint 1

                    Thread.Sleep(3050);
                    Debug.WriteLine("keys pressed");
                    m.WriteMemory(Offsets.feetx, "float", "100");
                    m.WriteMemory(Offsets.headx, "float", (100f + 0.7168208957).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feety, "float", "22");
                    m.WriteMemory(Offsets.heady, "float", (22f + 1.799999952).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feetz, "float", "120");
                    m.WriteMemory(Offsets.headz, "float", (120f + 0.7140606046).ToString());
                    Thread.Sleep(x);
                    Debug.WriteLine("checkpoint 1");
                    //checkpoint 2
                    m.WriteMemory(Offsets.feetx, "float", "86.7");
                    m.WriteMemory(Offsets.headx, "float", (87.7f + 0.7168208957).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feety, "float", "21");
                    m.WriteMemory(Offsets.heady, "float", (21f + 1.799999952).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feetz, "float", "134.5");
                    m.WriteMemory(Offsets.headz, "float", (134.5f + 0.7140606046).ToString());
                    Thread.Sleep(x);
                    //checkpoint 3
                    m.WriteMemory(Offsets.feetx, "float", "65.9");
                    m.WriteMemory(Offsets.headx, "float", (65.9f + 0.7168208957).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feety, "float", "20");
                    m.WriteMemory(Offsets.heady, "float", (20f + 1.799999952).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feetz, "float", "123.6");
                    m.WriteMemory(Offsets.headz, "float", (123.6f + 0.7140606046).ToString());
                    Thread.Sleep(x);
                    //checkpoint 4
                    m.WriteMemory(Offsets.feetx, "float", "53.7");
                    m.WriteMemory(Offsets.headx, "float", (53.7f + 0.7168208957).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feety, "float", "23");
                    m.WriteMemory(Offsets.heady, "float", (23f + 1.799999952).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feetz, "float", "143.5");
                    m.WriteMemory(Offsets.headz, "float", (143.5f + 0.7140606046).ToString());
                    Thread.Sleep(x);
                    //checkpoint 5
                    m.WriteMemory(Offsets.feetx, "float", "49");
                    m.WriteMemory(Offsets.headx, "float", (49f + 0.7168208957).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feety, "float", "20");
                    m.WriteMemory(Offsets.heady, "float", (20f + 1.799999952).ToString());
                    Thread.Sleep(x);
                    m.WriteMemory(Offsets.feetz, "float", "134");
                    m.WriteMemory(Offsets.headz, "float", (134f + 0.7140606046).ToString());
                    Thread.Sleep(x);
                }
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
                lbl_status.Text = "No process";
                lbl_status.ForeColor = Color.Red;
            }
            else
            {

                lbl_status.Text = "Process Found";
                lbl_status.ForeColor = Color.Green;
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
            Debug.WriteLine(m.ReadInt(Offsets.namelength).ToString());
            Debug.WriteLine(nametext.Text.Length.ToString());

        }
    }
}
