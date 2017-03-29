using System;
using Newtonsoft.Json;

namespace yooin
{
	public class tPush
	{
		public string deviceToken
		{
			get;
			set;
		}
		public int iTipo
		{
			get;
			set;
		}
		public int iCliente {
			get;
			set;
		
		}

		public static void saveLocal(string token,int iTipo) {
			tPush objLink = App.Database.isPushInDataBase();
			if (objLink == null)
			{
				App.Database.insertPush(
					new tPush
					{
						deviceToken = token,
						iTipo = iTipo,
						iCliente = 0
					}
				);
			}
			else
			{
				if (objLink.deviceToken != token)
				{
					App.Database.insertPush(
						new tPush
						{
							deviceToken = token,
							iTipo = iTipo,
							iCliente = 0
						}
					);
				}
			}
		}
		public static async void saveCloud(int iCliente)
		{
			string deviceToken = String.Empty;
			int iTipo = 0;
			int iClienteSaved = 0;
			tPush objLink = App.Database.isPushInDataBase();
			if (objLink != null)
			{
				deviceToken = objLink.deviceToken;
				iTipo = objLink.iTipo;
				iClienteSaved = objLink.iCliente;
				if (iClienteSaved!=iCliente && await wasSaved(iCliente,deviceToken,iTipo))
				{
					App.Database.insertPush(
						new tPush
						{
							deviceToken = deviceToken,
							iTipo = iTipo,
							iCliente = iCliente
						}
					);
				}
			}
		}

		private static async System.Threading.Tasks.Task<bool> wasSaved(int iIdCLiente, string sPushId, int iTipo)
		{
			Connection objConnection = new Connection();
			objConnection.sUrl = tLinks.getApiUrl() + EndPoints.Login;
			var obj = new
			{
				iIdCLiente = iIdCLiente,
				sPushId = sPushId,
				iTipo=iTipo
			};
			objConnection.sParameter = JsonConvert.SerializeObject(obj);
			var response = await objConnection.postMethod();
			if (response != "")
			{
				try
				{
					Response objResponse = JsonConvert.DeserializeObject<Response>(response);
					if (objResponse.iErrorCode == ErrorCode.NoError)
					{
						return true;
					}
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(ex.Message);
					return false;
				}
			}
			return false;
		}



	}
}
