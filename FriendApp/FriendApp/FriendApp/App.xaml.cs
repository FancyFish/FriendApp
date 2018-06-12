using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using FriendApp.View;
using FriendApp.Data;
using FriendApp.Services;

namespace FriendApp
{
	public partial class App : Application
	{
        private static FriendDataBase dataBase;
        public static FriendDataBase DataBase
        {
            get
            {
            if (dataBase == null)
                {
                    dataBase = new FriendDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db3"));
                }
                return dataBase;
            }
        }
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new View.MainPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
