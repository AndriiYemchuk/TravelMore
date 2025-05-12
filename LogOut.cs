using Android.Content;
using Java.Nio.Channels;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class LogOut : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.log_out_page);
        string userName = Intent.GetStringExtra("username");
        Button NoButton = FindViewById<Button>(Resource.Id.NoButton);
        NoButton.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Profile_list));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        Button YesButton = FindViewById<Button>(Resource.Id.YesButton);
        YesButton.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            Toast.MakeText(this, "You are log out!", ToastLength.Short).Show();
            StartActivity(intent);
        };
    }
}

