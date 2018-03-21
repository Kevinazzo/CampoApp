using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
		public sitemodel(string nom, string dir, string coor,string[] tags)
		{
			nombre = nom;
			direccion = dir;
			coordenadas = coor;
			tagset = tags;
		}
		public sitemodel(string nom, string _desc, string _web)
		{
			nombre = nom;
			desc = _desc;
			web = _web;
		}
		public string nombre { get; set; }
		public string direccion { get; set; }
		public string coordenadas { get; set; }
		public string web { get; set; }
		public string desc { get; set; }
		public string[] tagset = new string[] { "" };

	}
}