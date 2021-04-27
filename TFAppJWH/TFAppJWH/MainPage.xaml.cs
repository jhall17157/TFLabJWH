using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TFAppJWH
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private string[] questions = {"United States is a country", "Viiolence is usually the answer", "Apple is both a fruit and a company",
        "7 is a letter", "C# is a programming language"};
        private string[] answers = { "true", "false", "true", "false", "true" };
        private string[] imgs = { "usa.png", "roadhog.jpg", "apple.png", "seven.png", "c.png" };
        private int count = 0;
        private int number = 0;


        private void QuizClick(object sender, EventArgs e)
        {
            QLabel.IsVisible = true;
            //True.IsVisible = true;
            //False.IsVisible = true;
            StartButton.IsVisible = false;
            Swiper.IsVisible = true;
            QLabel.Text = questions[0];
            Swiper.Source = imgs[0];

            //int number = 0;
          
            //while(number < questions.Length)
            //{
            //    QLabel.Text = questions[number];
                
            //    if ( Answer.Text == answers[number])
            //    {
            //        count++;
            //    } else if (Answer.Text == [number] )
            //    {
            //        count++;
            //    }
            //    number++;
            //}

           // QLabel.Text = "You got " + count + " right!";
        }

        private void True_Swiped(object sender, EventArgs e)
        {
            Answer.Text = "true";
            if (answers[number] == "true")
            {
                count++;
            }
            number++;
            if (number < questions.Length)
            {
                QLabel.Text = questions[number];
                Swiper.Source = imgs[number];
            } else
            {
                QLabel.Text = "You got " + count + " right!";

                //True.IsVisible = false;
                //False.IsVisible = false;
                Swiper.IsVisible = false;
            }
        }

        private void False_Swiped(object sender, EventArgs e)
        {
            Answer.Text = "false";
            if (answers[number] == "false")
            {
                count++;
            }
            number++;
            if (number < questions.Length)
            {
                QLabel.Text = questions[number];
                Swiper.Source = imgs[number];
            }
            else
            {
                QLabel.Text = "You got " + count + " right!";

                //True.IsVisible = false;
                //False.IsVisible = false;
                Swiper.IsVisible = false;
            }
        }
    }
}
