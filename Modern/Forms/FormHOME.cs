using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Modern.Forms
{
    public partial class FormHOME: Form
    {
        public FormHOME()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }











        //////////////////////////////////////////////////////
        ////////////////       KLOCKA        /////////////////
        //////////////////////////////////////////////////////


        private Timer timeUpdater;

        private void Form1_Load(object sender, EventArgs e)
        {
            timeUpdater = new Timer();
            timeUpdater.Interval = 1000; // 1000 ms = 1 sekund
            timeUpdater.Tick += TimeUpdater_Tick;
            timeUpdater.Start();
        }


        private void TimeUpdater_Tick(object sender, EventArgs e)
        {
            TimerAPII.Text = DateTime.Now.ToString("yyyy-MM-dd");
            labelDatum.Text = DateTime.Now.ToString("HH:mm:ss");

            // Hämta aktuell vecka (ISO 8601 - svensk standard)
            CultureInfo ci = CultureInfo.CurrentCulture;
            Calendar calendar = ci.Calendar;
            CalendarWeekRule rule = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = ci.DateTimeFormat.FirstDayOfWeek;

            int vecka = calendar.GetWeekOfYear(DateTime.Now, rule, firstDayOfWeek);
            labelVecka.Text = "Vecka: " + vecka.ToString();

            // Månadens namn på svenska
            labelManad.Text = DateTime.Now.ToString("MMMM", new CultureInfo("sv-SE"));


        }




        private void label11_Click(object sender, EventArgs e)
        {
            labelManad.Text = DateTime.Now.ToString("MMMM", new CultureInfo("sv-SE"));  // Ger "mars"


        }




















    }
}
