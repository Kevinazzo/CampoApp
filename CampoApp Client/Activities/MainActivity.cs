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

namespace CampoApp
{
	[Activity(Label = "CampoApp", MainLauncher = true, Theme = "@style/CampoTheme")]
	public partial class MainActivity : AppCompatActivity
	{

		private DrawerLayout drawerLayout;
		private NavigationView navigationView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);




			var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetSupportActionBar(toolbar);
			SupportActionBar.Title = "CampoApp-Potrero chico";
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetHomeButtonEnabled(true);
			SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_white_24dp);


			//var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			//ActionBar(toolbar);
			//ActionBar.Title = "My Toolbar";
			//ActionBar.SetHomeButtonEnabled(true);
			//ActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_white_24dp);


			drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
			navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);


			navigationView.NavigationItemSelected += (sender, e) => {
				switch (e.MenuItem.ItemId)
				{
					case Resource.Id.nav_campSites:
						
						break;
					case Resource.Id.nav_climbSites:
						break;
					default:
						break;
				}
				e.MenuItem.SetChecked(true);
				//react to click here and swap fragments or navigate


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
		
		public void changeColorScheme(string color)
		{
			var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
		}
	}
}