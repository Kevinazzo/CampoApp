using Android.App;
using Android.Widget;
using Android.Views;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using System.Net;

namespace CampoApp
{
	[Activity(Label = "CampApp", MainLauncher = true, Theme = "@style/CampoTheme")]
	public partial class MainActivity : AppCompatActivity
	{

		private DrawerLayout drawerLayout;
		private NavigationView navigationView;
		private ImageView logo_container;
		//private readonly ListView campingSitesfragmentListView;
		public static Android.Util.DisplayMetrics metrics;
		public static int DeviceDpHeight { get; set; }
		public static int DeviceDpWidth { get; set; }
		public static int DevicePxHeight { get; set; }
		public static int DevicePxWidth { get; set; }
		public static WebClient webC = new WebClient();


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);
			drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
			navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
			metrics = Resources.DisplayMetrics;
			DeviceDpWidth = ConvertPxToDp(metrics.WidthPixels);
			DeviceDpHeight = ConvertPxToDp(metrics.HeightPixels);
			DevicePxWidth = ConvertDpToPx(DeviceDpWidth);
			DevicePxHeight = ConvertDpToPx(DeviceDpHeight);

			var customtoolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(customtoolbar);
			SupportActionBar.Title = "CampApp";
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetHomeButtonEnabled(true);
			SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_white_24dp);

			logo_container = FindViewById<ImageView>(Resource.Id.logo_container);
			logo_container.SetImageResource(Resource.Drawable.LogoCampAppAgenciaDave);



			//control de acciones del menu, swapear entre fragments
			navigationView.NavigationItemSelected += (sender, e) =>
			{
				Android.App.Fragment fragment = null;

				switch (e.MenuItem.ItemId)
				{
					case Resource.Id.nav_campSites:
						SupportActionBar.Title = "CampApp - Sitios de Acampar";
						fragment = new frg_campingSites();
						break;
					case Resource.Id.nav_climbSites:
						SupportActionBar.Title = "CampApp - Rutas de escalada";
						fragment = new frg_climbingSites();
						break;
					case Resource.Id.nav_Restaurants:
						SupportActionBar.Title = "CampApp - Restaurantes";
						fragment = new frg_restaurants();
						break;
					default:
						Toast.MakeText(this, "No hay aplicacion de uber", ToastLength.Short).Show();
						break;
				}
				e.MenuItem.SetChecked(true);
				//react to click here and swap fragments or navigate
				if (fragment != null)
				{
					FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container, fragment).Commit();
				}
				drawerLayout.CloseDrawers();
			};
		}

		//public override bool OnCreateOptionsMenu(IMenu menu)
		//{
		//	MenuInflater.Inflate(Resource.Menu.nav_menu, menu);
		//	return base.OnCreateOptionsMenu(menu);
		//}
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
				case Android.Resource.Id.Home:
					drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
					return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		#region obtener tamaño de la pantalla

		public int ConvertPxToDp(float pixelValue)
		{
			var dp = (int)((pixelValue) / Resources.DisplayMetrics.Density);
			return dp;
		}
		public int ConvertDpToPx(float dpValue)
		{
			var pix = ((dpValue) * Resources.DisplayMetrics.Density);
			return (int)pix;
		}
		#endregion
	}
}