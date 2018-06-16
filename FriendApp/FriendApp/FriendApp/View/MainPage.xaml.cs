﻿using FriendApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendApp.View
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}
        protected override void OnAppearing()
        {
            this.BindingContext = new MainPageViewModel(Navigation);
        }
    }
}
