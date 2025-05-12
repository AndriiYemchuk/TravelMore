using Android.Content;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Booked : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.trip_booked);
        string userName = Intent.GetStringExtra("username");

        Button next = FindViewById<Button>(Resource.Id.next_page);
        next.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Home));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
    }
}
