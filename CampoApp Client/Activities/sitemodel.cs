using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CampoApp
{
	public class sitemodel
	{
		public sitemodel()
		{

		}
		public sitemodel(string nom, string dir, string coor,string _tag)
		{
			name = nom;
			address = dir;
			coordinates = coor;
			tag = _tag;
		}
		public sitemodel(string nom, string _desc, string _web)
		{
			name = nom;
			description = _desc;
			web = _web;
		}
		[JsonProperty("id")]
		public int id { get; set;}

		[JsonProperty("name")]
		public string name { get; set; }

		[JsonProperty("address")]
		public string address { get; set; }

		[JsonProperty("coordinates")]
		public string coordinates { get; set; }

		[JsonProperty("web")]
		public string web { get; set; }

		[JsonProperty("description")]
		public string description { get; set; }

		[JsonProperty("tag")]
		public string tag { get; set; }
	}
	public class sitemodelList
	{

		[JsonProperty("sitemodel")]
		public sitemodel sitemodel { get; set; }
	}
}