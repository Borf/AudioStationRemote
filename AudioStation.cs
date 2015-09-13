using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using json;

namespace AudioStationRemote
{
	class AudioStation
	{
		string sid;



		public async void login(string username, string password)
		{
			json.Value ret = await callApi("GET", "auth.cgi", "?api=SYNO.API.Auth&version=2&method=login&account="+username+"&passwd="+Encoding.UTF8.GetString(Convert.FromBase64String(password))+"&Session=AudioStation&format=sid");
			sid = ret["data"]["sid"].asString();
		}







		private async Task<json.Value> callApi(string method, string api, string parameters, json.Value postData = null)
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("http://192.168.2.205:5000/webapi/" + api);
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			// List data response.
			HttpResponseMessage response = null;
			if (method == "POST")
			{
				Dictionary<string, string> postFields = new Dictionary<string, string>();
				foreach (var a in postData)
					postFields[a.Key] = a.Value.asString();
				response = client.PostAsync(parameters, new FormUrlEncodedContent(postFields)).Result;  // Blocking call!
																																			//response = client.PostAsync(parameters, new StringContent(postData.ToString(), Encoding.UTF8, "application/json")).Result;  // Blocking call!
			}
			else
				response = client.GetAsync(parameters).Result;  // Blocking call!
			if (response.IsSuccessStatusCode)
			{
				var data = Encoding.UTF8.GetString(await response.Content.ReadAsByteArrayAsync());
			//	Console.WriteLine("API OK: " + data);
				return json.Value.fromString(data);
			}
			else
			{
				Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
			}
			return null;
		}

		internal void setVolume(int newVolume)
		{
			control("set_volume", new Dictionary<string, string>() { { "value", (newVolume + "") } } );

		}


		//			callApi("AudioStation/remote_player_status.cgi", "?_sid="+sid+"&api=SYNO.AudioStation.RemotePlayerStatus&method=getstatus&id=uuid%3Accb075c1-6775-c1b9-da7c-c10967b96ed7&additional=song_tag%2Csong_audio%2Csubplayer_volume&version=1");

		public void play()
		{
			control("play");
		}
		public void pause()
		{
			control("pause");
		}
		public void stop()
		{
			control("stop");
		}
		public void prev()
		{
			control("prev");
		}
		public void next()
		{
			control("next");
		}


		public async Task<Value> getDirectory(string id = "")
		{
			json.Value postData = new json.ObjectValue();
			postData["_sid"] = sid;
			postData["limit"] = "1000";
			postData["api"] = "SYNO.AudioStation.Folder";
			postData["method"] = "list";
			postData["library"] = "shared";
			postData["additional"] = "song_tag,song_audio,song_rating";
			postData["sort_by"] = "track";
			postData["sort_direction"] = "ASC";
			postData["version"] = "2";
			if (id != "")
				postData["id"] = id;
			json.Value v = await callApi("POST", "AudioStation/folder.cgi", "?_sid=" + sid, postData);
			return v;

		}

		public async Task<Value> getStatus()
		{
			return await callApi("GET", "AudioStation/remote_player_status.cgi", "?_sid="+sid+"&api=SYNO.AudioStation.RemotePlayerStatus&method=getstatus&id=uuid%3Accb075c1-6775-c1b9-da7c-c10967b96ed7&additional=song_tag%2Csong_audio%2Csubplayer_volume&version=1");

		}

		public async void getDevices()
		{
			json.Value postData = new json.ObjectValue();
			postData["_sid"] = sid;
			postData["limit"] = "1000";
			postData["api"] = "SYNO.AudioStation.Folder";
			postData["method"] = "list";
			postData["library"] = "shared";
			postData["additional"] = "song_tag,song_audio,song_rating";
			postData["sort_by"] = "track";
			postData["sort_direction"] = "ASC";
			postData["version"] = "2";
			json.Value v = await callApi("POST", "AudioStation/remote_player.cgi", "?_sid=" + sid, postData);
			Console.WriteLine(v.ToString());

		}

		public async void control(string action, Dictionary<string,string> extra = null)
		{
			json.Value postData = new json.ObjectValue();
			postData["_sid"] = sid;
			postData["api"] = "SYNO.AudioStation.RemotePlayer";
			postData["method"] = "control";
			postData["id"] = "uuid:ccb075c1-6775-c1b9-da7c-c10967b96ed7";
			postData["version"] = "2";
			postData["action"] = action;

			if(extra != null)
				foreach (var a in extra)
					postData[a.Key] = a.Value;

			await callApi("POST", "AudioStation/remote_player.cgi", "?_sid=" + sid, postData);
		}


	}
}
