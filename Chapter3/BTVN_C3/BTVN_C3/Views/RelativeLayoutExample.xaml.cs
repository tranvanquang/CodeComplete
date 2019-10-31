﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTVN_C3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayoutExample : ContentPage
    {
        public RelativeLayoutExample()
        {
            InitializeComponent();
            Label below = new Label
            {
                Text = "Below Upper Left",
                FontSize = 15
            };

            LayoutContainer.Children.Add(below,
                Constraint.Constant(0),
                Constraint.RelativeToView(UpperLeft, (parent, sibling) =>
                {
                    return sibling.Y + sibling.Height;
                })
            );
        }
    }
}