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
	//clase que forma la lista con vistas personalizadas
	public class sitesAdapter : BaseAdapter
	{
		public sitesAdapter(Activity _context, List<sitemodel> db)
		{
			context = _context;
			list = db;
		}
		List<sitemodel> list;
		Activity context;
		public override int Count { get { return list.Count; } }

		public override Java.Lang.Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return list.IndexOf(list[position]);
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var row = context.LayoutInflater.Inflate(Resource.Layout.campingsitesfragmentlistviewelement, parent,false);
			ImageView img = row.FindViewById<ImageView>(Resource.Id.campingsitelistviewElement_img);
			TextView title = row.FindViewById<TextView>(Resource.Id.campingsiteListViewElement_Title);
			TextView address = row.FindViewById<TextView>(Resource.Id.campingSiteListViewElement_Address);
			ImageButton btn = row.FindViewById<ImageButton>(Resource.Id.campingSiteListViewElement_imgBtn);
			LinearLayout textcontainer = row.FindViewById<LinearLayout>(Resource.Id.campingsitesListViewelement_textContainer);

			img.LayoutParameters.Width = MainActivity.DevicePxWidth/5;
			img.LayoutParameters.Height = img.LayoutParameters.Width;
			img.SetScaleType(ImageView.ScaleType.FitCenter);

			textcontainer.LayoutParameters.Width = (MainActivity.DevicePxWidth / 5) * 3;

			btn.LayoutParameters.Height = img.LayoutParameters.Width;
			btn.LayoutParameters.Width = img.LayoutParameters.Width;
			btn.SetScaleType(ImageView.ScaleType.FitCenter);

			img.SetImageResource(Resource.Drawable.restaurant);
			title.Text = list[position].nombre;
			address.Text = list[position].direccion;
			btn.SetImageResource(Resource.Drawable.mapmarker);

			btn.Click += delegate
			{
				var geoUri = Android.Net.Uri.Parse("geo:" + list[position].coordenadas+"?z=20");
				var mapIntent = new Intent(Intent.ActionView, geoUri);
				context.StartActivity(mapIntent);
			};
			return row;
		}
	}
}