using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_1._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cantidad.Text))
            {
                float re, can1, can10, can20, can50, can100, can200, can5, cm50, cm25, cm5, cm10;
                re = can1 = can10 = can20 = can50 = can100 = can200 = can5 = cm50 = cm25 = cm5 = cm10 = 0.00f;

                var can = float.Parse(Cantidad.Text);


                if (can >= 200)
                {
                    can200 = (int)(can / 200);//devuelve un valor entero
                    can = can - (can200 * 200);

                }
                if (can >= 100)
                {
                    can100 = (int)(can / 100);
                    can = can - (can100 * 100);

                }
                if (can >= 50)
                {
                    can50 = (int)(can / 50);
                    can = can - (can50 * 50);

                }
                if (can >= 20)
                {
                    can20 = (int)(can / 20);
                    can = can - (can20 * 20);

                }
                if (can >= 10)
                {
                    can10 = (int)(can / 10);
                    can = can - (can10 * 10);
                }
                if (can >= 5)
                {
                    can5 = (int)(can / 5);
                    can = can - (can5 * 5);
                }
                if (can >= 1)
                {
                    can1 = (int)(can / 1);
                    can = can - (can1 * 1);
                }
                if (can >= 0.50)
                {
                    cm50 = (int)(can / 0.50);
                    can = can - (cm50 * 0.50f);
                }
                if (can >= 0.25)
                {
                    cm25 = (int)(can / 0.25);
                    can = can - (cm25 * 0.25f);
                }
                if (can >= 0.10)
                {
                    cm10 = (int)(can / 0.10);
                    can = can - (cm10 * 0.10f);
                }
                if (can >= 0.05)
                {
                    cm5 = (int)(can / 0.05);
                    can = can - (cm5 * 0.05f);
                }
                if (can >= 00.01f)
                {
                    can = (can / 00.01f);
                    re = (int)Math.Round(can);//aproxima al entero mas cercano

                }
                C200.Text = $"Q200= {Convert.ToString(can200)}";
                C100.Text = $"Q100= {Convert.ToString(can100)}";
                C50.Text = $"Q50= {Convert.ToString(can50)}";
                C20.Text = $"Q20= {Convert.ToString(can20)}";
                C10.Text = $"Q10= {Convert.ToString(can10)}";
                C5.Text = $"Q5= {Convert.ToString(can5)}";
                C1.Text = $"Q1= {Convert.ToString(can1)}";
                M50.Text = $"Q0.50= {Convert.ToString(cm50)}";
                M25.Text = $"Q0.25= {Convert.ToString(cm25)}";
                M10.Text = $"Q0.10= {Convert.ToString(cm10)}";
                M5.Text = $"Q0.05= {Convert.ToString(cm5)}";
                M1.Text = $"Q0.01= {Convert.ToString(re)}";
            }
            else
            {
                DisplayAlert("Cantidad invalida",
                    "Por favor ingresa bien la cantidad",
                    "Ok");
            }
        }
    }
}
