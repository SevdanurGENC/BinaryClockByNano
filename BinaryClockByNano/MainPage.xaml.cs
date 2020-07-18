using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace BinaryClockByNano
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        //rectangle1.Fill = new SolidColorBrush(Colors.Red); renklendirme komutu bu olacak!
 
        int Seconds = 0;
        int Minutes = 0;
        int Hours = 0; 

        private void MainTime_Tick(object sender, EventArgs e)
        {
            MainTimeLabel.Text = DateTime.Now.ToShortTimeString();
        }


        public void ResetSecondsColor1stHalf()
        {
            Seconds1stHalf1.Fill = new SolidColorBrush(Colors.Gray);
            Seconds1stHalf2.Fill = new SolidColorBrush(Colors.Gray);
            Seconds1stHalf4.Fill = new SolidColorBrush(Colors.Gray);
        }

        public void ResetSecondsColor2ndHalf()
        {
            Seconds2ndHalf1.Fill = new SolidColorBrush(Colors.Gray);
            Seconds2ndHalf2.Fill = new SolidColorBrush(Colors.Gray);
            Seconds2ndHalf4.Fill = new SolidColorBrush(Colors.Gray);
            Seconds2ndHalf8.Fill = new SolidColorBrush(Colors.Gray);
        }

        public void ResetMinutesColor1stHalf()
        {
            Minutes1stHalf1.Fill = new SolidColorBrush(Colors.Gray);
            Minutes1stHalf2.Fill = new SolidColorBrush(Colors.Gray);
            Minutes1stHalf4.Fill = new SolidColorBrush(Colors.Gray);
        }

        public void ResetMinutesColor2ndHalf()
        {
            Minutes2ndHalf1.Fill = new SolidColorBrush(Colors.Gray);
            Minutes2ndHalf2.Fill = new SolidColorBrush(Colors.Gray);
            Minutes2ndHalf4.Fill = new SolidColorBrush(Colors.Gray);
            Minutes2ndHalf8.Fill = new SolidColorBrush(Colors.Gray);
        }

        public void ResetHoursColor1stHalf()
        {
            Hours1stHalf1.Fill = new SolidColorBrush(Colors.Gray);
            Hours1stHalf2.Fill = new SolidColorBrush(Colors.Gray);

        }

        public void ResetHoursColor2ndHalf()
        {
            Hours2ndHalf1.Fill = new SolidColorBrush(Colors.Gray);
            Hours2ndHalf2.Fill = new SolidColorBrush(Colors.Gray);
            Hours2ndHalf4.Fill = new SolidColorBrush(Colors.Gray);
            Hours2ndHalf8.Fill = new SolidColorBrush(Colors.Gray);
        }



        public void DeterminingSeconds()
        {
            if (Seconds == 1 || Seconds == 11 || Seconds == 21 || Seconds == 31 || Seconds == 41 || Seconds == 51)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 2 || Seconds == 12 || Seconds == 22 || Seconds == 32 || Seconds == 42 || Seconds == 52)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 3 || Seconds == 13 || Seconds == 23 || Seconds == 33 || Seconds == 43 || Seconds == 53)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Seconds2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 4 || Seconds == 14 || Seconds == 24 || Seconds == 34 || Seconds == 44 || Seconds == 54)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 5 || Seconds == 15 || Seconds == 25 || Seconds == 35 || Seconds == 45 || Seconds == 55)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                Seconds2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 6 || Seconds == 16 || Seconds == 26 || Seconds == 36 || Seconds == 46 || Seconds == 56)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                Seconds2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 7 || Seconds == 17 || Seconds == 27 || Seconds == 37 || Seconds == 47 || Seconds == 57)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Seconds2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Seconds2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 8 || Seconds == 18 || Seconds == 28 || Seconds == 38 || Seconds == 48 || Seconds == 58)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf8.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Seconds == 9 || Seconds == 19 || Seconds == 29 || Seconds == 39 || Seconds == 49 || Seconds == 59)
            {
                ResetSecondsColor2ndHalf();
                Seconds2ndHalf8.Fill = new SolidColorBrush(Colors.White);
                Seconds2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }

        }
        
        public void DeterminingMinutes()
        {
            if (Minutes == 1 || Minutes == 11 || Minutes == 21 || Minutes == 31 || Minutes == 41 || Minutes == 51)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Minutes == 2 || Minutes == 12 || Minutes == 22 || Minutes == 32 || Minutes == 42 || Minutes == 52)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Minutes == 3 || Minutes == 13 || Minutes == 23 || Minutes == 33 || Minutes == 43 || Minutes == 53)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Minutes2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Minutes == 4 || Minutes == 14 || Minutes == 24 || Minutes == 34 || Minutes == 44 || Minutes == 54)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Minutes == 5 || Minutes == 15 || Minutes == 25 || Minutes == 35 || Minutes == 45 || Minutes == 55)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                Minutes2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Minutes == 6 || Minutes == 16 || Minutes == 26 || Minutes == 36 || Minutes == 46 || Minutes == 56)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                Minutes2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Minutes == 7 || Minutes == 17 || Minutes == 27 || Minutes == 37 || Minutes == 47 || Minutes == 57)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Minutes2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Minutes2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            else if (Minutes == 8 || Minutes == 18 || Minutes == 28 || Minutes == 38 || Minutes == 48 || Minutes == 58)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf8.Fill = new SolidColorBrush(Colors.White);
            }

            else if (Minutes == 9 || Minutes == 19 || Minutes == 29 || Minutes == 39 || Minutes == 49 || Minutes == 59)
            {
                ResetMinutesColor2ndHalf();
                Minutes2ndHalf8.Fill = new SolidColorBrush(Colors.White);
                Minutes2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
        }

        public void DeterminingHours()
        {
            if (Hours == 1)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 2)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 3)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 4)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 5)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 6)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 7)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 8)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 9)
            {
                ResetHoursColor2ndHalf();
                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 10)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 11)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 12)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 13)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 14)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 15)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 16)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 17)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 18)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 19)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 20)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 21)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 22)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 23)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
            }
            if (Hours == 24 || Hours == 0)
            {
                ResetHoursColor2ndHalf();
                ResetHoursColor1stHalf();
            }

        }



        private void SecondsTimer_Tick(object sender, EventArgs e)
        {
            SecondsLabel.Text = DateTime.Now.Second.ToString();
            Seconds = Int32.Parse(SecondsLabel.Text);

            if (Seconds == 0)
            {
                ResetSecondsColor1stHalf();
                ResetSecondsColor2ndHalf();
            }
            else if (Seconds >= 1 && Seconds <= 9)
            {
                DeterminingSeconds();
            }
            else if (Seconds >= 10 && Seconds <= 19)
            {
                ResetSecondsColor2ndHalf();
                Seconds1stHalf1.Fill = new SolidColorBrush(Colors.White);
                DeterminingSeconds();
            }
            else if (Seconds >= 20 && Seconds <= 29)
            {
                ResetSecondsColor1stHalf();
                ResetSecondsColor2ndHalf();
                Seconds1stHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingSeconds();
            }
            else if (Seconds >= 30 && Seconds <= 39)
            {
                ResetSecondsColor2ndHalf();
                Seconds1stHalf2.Fill = new SolidColorBrush(Colors.White);
                Seconds1stHalf1.Fill = new SolidColorBrush(Colors.White);
                DeterminingSeconds();
            }
            else if (Seconds >= 40 && Seconds <= 49)
            {
                ResetSecondsColor1stHalf();
                ResetSecondsColor2ndHalf();
                Seconds1stHalf4.Fill = new SolidColorBrush(Colors.Gray);
                DeterminingSeconds();
            }
            else if (Seconds >= 50 && Seconds <= 59)
            {
                ResetSecondsColor1stHalf();
                ResetSecondsColor2ndHalf();
                Seconds1stHalf1.Fill = new SolidColorBrush(Colors.White);
                Seconds1stHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingSeconds();
            }
        }
        
        private void MinutesTimer_Tick(object sender, EventArgs e)
        {
            MinutesLabel.Text = DateTime.Now.Minute.ToString();
            Minutes = Int32.Parse(MinutesLabel.Text);

            if (Minutes == 0)
            {
                ResetMinutesColor1stHalf();
                ResetMinutesColor2ndHalf();
            }
            else if (Minutes >= 1 && Minutes <= 9)
            {
                ResetMinutesColor1stHalf();
                DeterminingMinutes();
            }
            else if (Minutes >= 10 && Minutes <= 19)
            {
                ResetMinutesColor1stHalf();
                ResetMinutesColor2ndHalf();

                Minutes1stHalf1.Fill = new SolidColorBrush(Colors.White);
                DeterminingMinutes();
            }

            else if (Minutes >= 20 && Minutes <= 29)
            {
                ResetMinutesColor1stHalf();
                ResetMinutesColor2ndHalf();

                Minutes1stHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingMinutes();
            }
            else if (Minutes >= 30 && Minutes <= 39)
            {
                ResetMinutesColor1stHalf();
                ResetMinutesColor2ndHalf();

                Minutes1stHalf2.Fill = new SolidColorBrush(Colors.White);
                Minutes1stHalf1.Fill = new SolidColorBrush(Colors.White);
                DeterminingMinutes();
            }
            else if (Minutes >= 40 && Minutes <= 49)
            {
                ResetMinutesColor1stHalf();
                ResetMinutesColor2ndHalf();
                Minutes1stHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingMinutes();
            }
            else if (Minutes >= 50 && Minutes <= 59)
            {
                ResetMinutesColor1stHalf();
                ResetMinutesColor2ndHalf();
                Minutes1stHalf1.Fill = new SolidColorBrush(Colors.White);
                Minutes1stHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingMinutes();
            }
        }

        private void HoursTimer_Tick(object sender, EventArgs e)
        {
            HoursLabel.Text = DateTime.Now.Hour.ToString();
            Hours = Int32.Parse(HoursLabel.Text);

            if (Hours == 1)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();

            }
            if (Hours == 2)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 3)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }

            if (Hours == 4)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 5)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 6)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 7)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 8)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 9)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 10)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                DeterminingHours();
            }
            if (Hours == 11)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 12)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 13)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 14)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 15)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 16)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 17)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf4.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 18)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 19)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf1.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf8.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 20)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 21)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 22)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 23)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                Hours1stHalf2.Fill = new SolidColorBrush(Colors.White);

                Hours2ndHalf1.Fill = new SolidColorBrush(Colors.White);
                Hours2ndHalf2.Fill = new SolidColorBrush(Colors.White);
                DeterminingHours();
            }
            if (Hours == 24 || Hours == 0)
            {
                ResetHoursColor1stHalf();
                ResetHoursColor2ndHalf();
                DeterminingHours();
            }
        }



        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer dt = new System.Windows.Threading.DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 100);  
            dt.Tick += new EventHandler(MainTime_Tick);
            dt.Tick += new EventHandler(SecondsTimer_Tick);
            dt.Tick += new EventHandler(MinutesTimer_Tick);
            dt.Tick += new EventHandler(HoursTimer_Tick);
            dt.Start();            
            
        }
        
    }
}