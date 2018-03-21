﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace CampoApp
{
	public class frg_campingSites : Fragment
	{
		ListView listview;
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);
			var toReturn = inflater.Inflate(Resource.Layout.campingSites_fragment, container, false);
			return toReturn;
		}
		public override void OnStart()
		{
			base.OnStart();
			sitesAdapter sitesAdapter = new sitesAdapter(Activity, fillnewCampingSitelist());
			listview = View.FindViewById<ListView>(Resource.Id.campingsites_listview);
			listview.Adapter = sitesAdapter;
		}
		List<sitemodel>fillnewCampingSitelist()
		{
			List<sitemodel> list = new List<sitemodel>();
			list.Add(new sitemodel("La Posada", "Antiguo Camino a Potrero Chico 825, Las Pedreras, 65600 Hidalgo, N.L.", "25.956590, -100.475669", new string[] { "acampar" }));
			return list;
		}
	}
}