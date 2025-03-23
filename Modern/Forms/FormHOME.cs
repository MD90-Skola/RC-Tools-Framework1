using System;
using System.Globalization;
using System.Management;
using System.Windows.Forms;

namespace Modern.Forms
{
    public partial class FormHOME : Form
    {
        private Timer timeUpdater;

        public FormHOME()
        {
            InitializeComponent();
        }

        // Körs när formuläret laddas


        // Startar klockan
        private void StartClock()
        {
            timeUpdater = new Timer();
            timeUpdater.Interval = 1000;
            timeUpdater.Tick += TimeUpdater_Tick;
            timeUpdater.Start();
        }

        // Uppdaterar tid, datum och vecka
        private void TimeUpdater_Tick(object sender, EventArgs e)
        {
            TimerAPII.Text = DateTime.Now.ToString("yyyy-MM-dd");
            labelDatum.Text = DateTime.Now.ToString("HH:mm:ss");

            CultureInfo ci = CultureInfo.CurrentCulture;
            Calendar calendar = ci.Calendar;
            CalendarWeekRule rule = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = ci.DateTimeFormat.FirstDayOfWeek;
            int vecka = calendar.GetWeekOfYear(DateTime.Now, rule, firstDayOfWeek);
            labelVecka.Text = "Vecka: " + vecka.ToString();

            labelManad.Text = DateTime.Now.ToString("MMMM", new CultureInfo("sv-SE"));
        }

        // Hämta CPU, GPU och RAM
        private void GetHardwareInfo()
        {
            try
            {
                // CPU
                using (var searcher = new ManagementObjectSearcher("select Name from Win32_Processor"))
                {
                    foreach (var item in searcher.Get())
                    {
                        textBox1.Text = item["Name"].ToString();
                        break;
                    }
                }

                // GPU
                using (var searcher = new ManagementObjectSearcher("select Name from Win32_VideoController"))
                {
                    foreach (var item in searcher.Get())
                    {
                        textBox2.Text = item["Name"].ToString();
                        break;
                    }
                }

                // RAM
                using (var searcher = new ManagementObjectSearcher("Select Capacity from Win32_PhysicalMemory"))
                {
                    ulong totalMemory = 0;
                    foreach (var item in searcher.Get())
                    {
                        totalMemory += Convert.ToUInt64(item["Capacity"]);
                    }
                    textBox3.Text = (totalMemory / (1024 * 1024 * 1024)) + " GB";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel vid hårdvaruhämtning: " + ex.Message);
            }
        }





























        // Tomma eventhandlers om du inte använder dem
        private void textBox1_TextChanged(object sender, EventArgs e) 
        
        { 
        
            
        
        }





        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) { }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
