using Android.Content;
using Android.Views;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Profile_list : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.Profile);

        string userName = Intent.GetStringExtra("username");
        TextView name = FindViewById<TextView>(Resource.Id.name_text);
        name.Text = $"{userName}";

        ImageView backButton = FindViewById<ImageView>(Resource.Id.backButton);
        backButton.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Home));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        TextView saved_trips = FindViewById<TextView>(Resource.Id.saved_trips);
        saved_trips.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(SavedTrips));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        TextView future_trips = FindViewById<TextView>(Resource.Id.future_trips);
        future_trips.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(FutureTrips));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        TextView logout = FindViewById<TextView>(Resource.Id.logout);
        logout.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(LogOut));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
    }
}
