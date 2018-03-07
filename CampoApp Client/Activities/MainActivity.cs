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


			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.idtoolbar);
			SetSupportActionBar(toolbar);

			SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_white_24dp);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);



			drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
			navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);


			navigationView.NavigationItemSelected += (sender, e) => {
				e.MenuItem.SetChecked(true);
				//react to click here and swap fragments or navigate
				drawerLayout.CloseDrawers();
			};
		}
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
	}
}