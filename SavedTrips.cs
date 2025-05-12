using Android.Content;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class SavedTrips : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.saved_trips_page);
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
