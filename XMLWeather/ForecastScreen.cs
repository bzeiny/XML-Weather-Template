using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Convert.ToDateTime(Form1.days[1].date).ToString("dddd");     
            max1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh)) + "°";
            min1.Text = Math.Round(Convert.ToDouble(Form1.days[1].tempLow)) + "°";

         
            date2.Text = Convert.ToDateTime(Form1.days[2].date).ToString("dddd");
            max2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh)) + "°";
            min2.Text = Math.Round(Convert.ToDouble(Form1.days[2].tempLow)) + "°";

            date3.Text = Convert.ToDateTime(Form1.days[3].date).ToString("dddd");
            max3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh)) + "°";
            min3.Text = Math.Round(Convert.ToDouble(Form1.days[3].tempLow)) + "°";

            date4.Text = Convert.ToDateTime(Form1.days[4].date).ToString("dddd");
            max4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh)) + "°";
            min4.Text = Math.Round(Convert.ToDouble(Form1.days[4].tempLow)) + "°";

            date5.Text = Convert.ToDateTime(Form1.days[5].date).ToString("dddd");
            max5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh)) + "°";
            min5.Text = Math.Round(Convert.ToDouble(Form1.days[5].tempLow)) + "°";

            date6.Text = Convert.ToDateTime(Form1.days[6].date).ToString("dddd");
            max6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempHigh)) + "°";
            min6.Text = Math.Round(Convert.ToDouble(Form1.days[6].tempLow)) + "°";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }


    }
}
