## Xamarin Base Template

An initial template for general propouses that manage the next features

*   sqlite
*   push notification (ios/android)
*   hybriew webview
*   login screen
*   webview screen

### Testing

At least you need to have installed xamarin studio or visual studio with xamarin tools
This is an template (or at least this is the main idea). If you have errors to run this proyect
you could update xamarin for last version (xamarin.ios xamarin.android xamarin, nuget for visual studio).
Well my experience so far is that always has a surprise (Welcome to Xamarin)

The happy path is that you only need to run this proyect to test it

Hope that you can run this proyect without bugs.

### What is it for?
To serves as template.
Basically this app get its push token and stored in a sqlite table tPush
Has a login with a commented api call that validate user credential

Here is :

    private async System.Threading.Tasks.Task<bool> loginConnection()
		{
			//Connection objConnection = new Connection();
			//objConnection.sUrl = tLinks.getApiUrl() + EndPoints.Login;
			//var obj = new
			//{
			//	sEmail = entUser.Text,
			//	sPassword = entPassword.Text
			//};
			//objConnection.sParameter = JsonConvert.SerializeObject(obj);
			//var response = await objConnection.postMethod();
			//if (response != "")
			//{
			//	try
			//	{
			//		Response objResponse = JsonConvert.DeserializeObject<Response>(response);
			//		if (objResponse.iErrorCode == ErrorCode.NoError)
			//		{
			//			return true;
			//		}
			//	}
			//	catch (Exception ex)
			//	{
			//		System.Diagnostics.Debug.WriteLine(ex.Message);
			//		return false;
			//	}
			//}
			return true;
		}
    
As you can see this app has an Connection class that manages get and post connection that expectes a especial response 
After the user log in successfuly, open a new screen to display google web page, and yes it has no back button (for ios TnT)
and that all. 
>Good things  do not count, but they count a lot






### Especial considerations

*   ios Push notifications require to generate certificates, provisional profiles and installing on xcode [Xamarin guide](https://developer.xamarin.com/guides/ios/application_fundamentals/notifications/remote_notifications_in_ios/)
*   android push notifications require to generate a fire cloud message proyect and linked to app with sender id [Xamarin guide](https://developer.xamarin.com/guides/android/application_fundamentals/notifications/firebase-cloud-messaging/)
*   senderid for android proyect is declare at  EndPoints class FCMSENDERID string 
*   you need to change bundle id for ios and android 
*   i dont know if there is a way to change namespace for al proyect.
*   yes i use code to make layout dont freak out 


<div class="footer">
        &copy; eibz91
    </div>

#### Next to come
I will add general features and post some xaml screens [XAML guide](https://developer.xamarin.com/guides/xamarin-forms/xaml/xaml-basics/) 
Also improve the code and documentation

### Colaborate
Of course be free to fork this proyect and improved it i know that has a lot of things to improve
