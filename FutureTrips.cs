using Android.Content;
using Android.Views;


namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class FutureTrips : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.future_trips_page);
        string userName = Intent.GetStringExtra("username");
        ImageView backButton = FindViewById<ImageView>(Resource.Id.backButton);
        backButton.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Profile_list));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
    }
}
