﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTVN_C4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomDarkThemePage : ContentPage
    {
        public CustomDarkThemePage()
        {
            InitializeComponent();
            Feedback.Text = placeHolderText;
        }
        const string placeHolderText = "Type your message here";

        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var text = Feedback.Text;

            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                return;
            }

            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                return;
            }
        }
    }
}