﻿using System;

using Xamarin.Forms;

namespace templateBase
{
	public class App : Application
	{
		static DataBaseAction database;
		static NavigationPage nav;
		public static NavigationPage Nav
		{
			get
			{
				if (nav == null)
				{
					nav = new NavigationPage();
				}
				return nav;
			}
		}
		public static DataBaseAction Database
		{
			get
			{
				if (database == null)
				{
					database = new DataBaseAction();
				}
				return database;
			}
		}
		public App()
		{


			nav = new NavigationPage(new LoginView());

			MainPage = nav;
		}
		private void setDefaultData()
		{

			var objLink = App.Database.isLinkInDataBase();
			if (objLink == null)
			{
				App.Database.insertLink(
					new tLinks
					{
						baseWebApi = EndPoints.URLAPIBASE
						,
						baseWebUrl = EndPoints.URLWEBBASE
					}
				);
			}


		}

		protected override void OnStart()
		{
			// Handle when your app starts
			setDefaultData();
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
