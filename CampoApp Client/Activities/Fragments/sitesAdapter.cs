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
			View row = null;
			if (list[position].tag==("restaurante") ) //opciones para los restaurantes
			{
				row = context.LayoutInflater.Inflate(Resource.Layout.campingsitesfragmentlistviewelement, parent, false);

				ImageView img = row.FindViewById<ImageView>(Resource.Id.campingsitelistviewElement_img);
				TextView title = row.FindViewById<TextView>(Resource.Id.campingsiteListViewElement_Title);
				TextView address = row.FindViewById<TextView>(Resource.Id.campingSiteListViewElement_Address);
				ImageButton btn = row.FindViewById<ImageButton>(Resource.Id.campingSiteListViewElement_imgBtn);
				LinearLayout textcontainer = row.FindViewById<LinearLayout>(Resource.Id.campingsitesListViewelement_textContainer);

				img.SetImageResource(Resource.Drawable.restaurantMarker);
				title.Text = list[position].name;
				address.Text = list[position].address;
				btn.SetImageResource(Resource.Drawable.mapmarker);
				img.LayoutParameters.Width = MainActivity.DevicePxWidth / 5;
				img.LayoutParameters.Height = img.LayoutParameters.Width;
				img.SetScaleType(ImageView.ScaleType.FitCenter);

				textcontainer.LayoutParameters.Width = (MainActivity.DevicePxWidth / 5) * 3;

				btn.LayoutParameters.Height = img.LayoutParameters.Width;
				btn.LayoutParameters.Width = img.LayoutParameters.Width;
				btn.SetScaleType(ImageView.ScaleType.FitCenter);

				btn.Click += delegate
				{
					var geoUri = Android.Net.Uri.Parse("geo:" + list[position].coordinates + "?z=20");
					var mapIntent = new Intent(Intent.ActionView, geoUri);
					context.StartActivity(mapIntent);
				};
			}
			else if(list[position].description!=null && list[position].description!="")// opciones para los sitios de senderismo
			{

				row = context.LayoutInflater.Inflate(Resource.Layout.climbingsitesfragmentlistviewelement, parent, false);
				TextView name = row.FindViewById<TextView>(Resource.Id.climbingsiteListViewElement_Title);
				TextView description = row.FindViewById<TextView>(Resource.Id.climbingSiteListViewElement_Address);
				Button btn = row.FindViewById<Button>(Resource.Id.climbingSiteListViewElement_Btn);
				LinearLayout  txtcontainer= row.FindViewById<LinearLayout>(Resource.Id.climbingsitesListViewelement_textContainer);

				name.Text = list[position].name;
				description.Text = list[position].description;
				//name.LayoutParameters.Width = (MainActivity.DevicePxWidth / 6) * 4;
				//description.LayoutParameters.Width = name.LayoutParameters.Width;
				txtcontainer.LayoutParameters.Width=(MainActivity.DevicePxWidth/6)*4;

				btn.Click += delegate
				{
					var httpUri = Android.Net.Uri.Parse(list[position].web);
					var mapIntent = new Intent(Intent.ActionView, httpUri);
					context.StartActivity(mapIntent);
				};
			}else if (list[position].tag.Contains("acampar")) //opciones para los sitiops de acampas
			{
				row = context.LayoutInflater.Inflate(Resource.Layout.campingsitesfragmentlistviewelement, parent, false);

				ImageView img = row.FindViewById<ImageView>(Resource.Id.campingsitelistviewElement_img);
				TextView title = row.FindViewById<TextView>(Resource.Id.campingsiteListViewElement_Title);
				TextView address = row.FindViewById<TextView>(Resource.Id.campingSiteListViewElement_Address);
				ImageButton btn = row.FindViewById<ImageButton>(Resource.Id.campingSiteListViewElement_imgBtn);
				LinearLayout textcontainer = row.FindViewById<LinearLayout>(Resource.Id.campingsitesListViewelement_textContainer);

				img.SetImageResource(Resource.Drawable.restaurantMarker);
				title.Text = list[position].name;
				address.Text = list[position].address;
				btn.SetImageResource(Resource.Drawable.mapmarker);
				img.LayoutParameters.Width = MainActivity.DevicePxWidth / 5;
				img.LayoutParameters.Height = img.LayoutParameters.Width;
				img.SetScaleType(ImageView.ScaleType.FitCenter);

				textcontainer.LayoutParameters.Width = (MainActivity.DevicePxWidth / 5) * 3;

				btn.LayoutParameters.Height = img.LayoutParameters.Width;
				btn.LayoutParameters.Width = img.LayoutParameters.Width;
				btn.SetScaleType(ImageView.ScaleType.FitCenter);

				btn.Click += delegate
				{
					var geoUri = Android.Net.Uri.Parse("geo:" + list[position].coordinates + "?z=20");
					var mapIntent = new Intent(Intent.ActionView, geoUri);
					context.StartActivity(mapIntent);
				};
			}
			return row;
		}
	}
}