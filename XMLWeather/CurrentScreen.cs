using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {
            if (Form1.days[0].condition == "clear sky")
            {
                this.BackgroundImage = Properties.Resources.backclear;            
            }       
            if (Form1.days[0].condition == "snow")
            {
                this.BackgroundImage = Properties.Resources.snowybackground;
                label3.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
                timeLabel.ForeColor = Color.Black;
                cityOutput.ForeColor = Color.Black;
                currentTempOutput.ForeColor = Color.Black;
                date2.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                minOutput.ForeColor = Color.Black;
                maxOutput.ForeColor = Color.Black;
                conditionLabel.ForeColor = Color.Black;
            }
            if (Form1.days[0].condition == "rain" || Form1.days[0].condition == "shower rain" || Form1.days[0].condition == "scattered clouds" 
                || Form1.days[0].condition == "broken clouds" || Form1.days[0].condition == "thunderstorms" || Form1.days[0].condition == "few clouds"
                || Form1.days[0].condition == "overcast")
            {
                this.BackgroundImage = Properties.Resources.cloudybackground;
            }
        }
        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentTempOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)) + "°";
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow)) + "°";
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh)) + "°";
            date2.Text = Convert.ToDateTime(Form1.days[0].date).ToString("dddd, MMMM dd, yyyy");
            conditionLabel.Text = Form1.days[0].condition.ToUpper();
            timeLabel.Text = DateTime.Now.ToString("hh:mm");

            if (Form1.days[0].condition == "clear sky")
            {
              conditionPicLabel.Image = Properties.Resources.sunny1;
            }
            if (Form1.days[0].condition == "rain" || conditionLabel.Text == "shower rain")
            {
              conditionPicLabel.Image = Properties.Resources.rainy1;
            }
            if (Form1.days[0].condition == "snow") 
            {
              conditionPicLabel.Image = Properties.Resources.snowy1;
            }
            if (Form1.days[0].condition == "scattered clouds" || Form1.days[0].condition == "broken clouds" 
                || Form1.days[0].condition == "overcast")
            {
              conditionPicLabel.Image = Properties.Resources.partlycloudy;
            }
            if (Form1.days[0].condition == "few clouds")
            {
                conditionPicLabel.Image = Properties.Resources.cloudy1;
            }
            if (Form1.days[0].condition == "thunderstorm")
            {
                conditionPicLabel.Image = Properties.Resources.storm;
            }      
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string city = citySearchBar.Text;
        }
    }
}
