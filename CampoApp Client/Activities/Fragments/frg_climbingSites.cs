using System;
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
	public class frg_climbingSites : Fragment
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
			var toReturn = inflater.Inflate(Resource.Layout.climbingsites_fragment, container, false);
			return toReturn;
		}
		public override void OnStart()
		{
			base.OnStart();
			sitesAdapter sitesAdapter = new sitesAdapter(Activity, fillNewClimbingSiteList());
			listview = View.FindViewById<ListView>(Resource.Id.climbingSites_listiview);
			listview.Adapter = sitesAdapter;
		}
		List<sitemodel> fillNewClimbingSiteList()
		{
			List<sitemodel> list = new List<sitemodel>();
			list.Add(new sitemodel("Cañón de San Lorenzo", "8,62 km, Santa Emilia, Coahuila", "https://es.wikiloc.com/rutas-senderismo/canon-de-san-lorenzo-20162893"));
			list.Add(new sitemodel("EL MUSGO", "10,79 km, Dolores, Coahuila", "https://es.wikiloc.com/rutas-senderismo/el-musgo-por-san-juan-de-dolores-y-bajando-por-tarillal-10237619"));
			list.Add(new sitemodel("La catarina", "8,07 km, Santa Rosa, Coahuila", "https://es.wikiloc.com/rutas-senderismo/la-catarina-10011313"));
			list.Add(new sitemodel("Las Nieves", "25,41 km, Los Aromos, Coahuila", "https://es.wikiloc.com/rutas-senderismo/las-nieves-refugio-la-catarina-19449239"));
			list.Add(new sitemodel("La Viga por la Iglesia", "7,31 km,La Maroma, Coahuila, Solo Expertos", "https://es.wikiloc.com/rutas-senderismo/la-viga-por-la-iglesia-11049234"));
			list.Add(new sitemodel("Aguja Inferior", "53,86 km, de La Azufrosa, Coahuila, Bicicleta", "https://es.wikiloc.com/rutas-senderismo/aguja-inferior-en-mina-nl-bici-desde-termas-de-san-joaquin-16386361"));
			list.Add(new sitemodel("El Penitente", "7,78 km, Sierra Hermosa, Coahuila", "https://es.wikiloc.com/rutas-senderismo/el-penitente-desde-sierra-hermosa-arteaga-n-l-18560007"));
			return list;
		}
	}
}