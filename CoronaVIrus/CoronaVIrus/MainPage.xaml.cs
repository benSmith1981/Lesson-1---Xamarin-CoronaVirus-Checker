using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoronaVIrus
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

        }

        public void Submit(object sender, EventArgs args)
        {
            var temp = tempInput.Text;
            if (int.Parse(temp) > 36)
            {
                Console.WriteLine("COVID BRUV!!!!!");
            }
            else
            {
                Console.WriteLine("NO COVID HERE!!!!!!!!!!!!!");
            }
        }
    }
}
