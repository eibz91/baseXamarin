using System;
using Xamarin.Forms;

namespace templateBase
{
	public class MainView : ContentPage
	{

		HybridWebView web;
		static BaseRelativeLayout objContent;
		public MainView(string email, string password)
		{
			NavigationPage.SetHasNavigationBar(this, false);
			objContent = new BaseRelativeLayout();
			web = new HybridWebView();
			web.Uri = tLinks.getWebUr();
 			tPush.saveCloud(3);
			objContent.setCustomView(web, 0, 0, 1, 1);
			Content = objContent.Content;
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
		}


	}
}
