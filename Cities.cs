using Android.Content;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Cities : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.place_to_stay);
        string userName = Intent.GetStringExtra("username");
        string destination_1 = Intent.GetStringExtra("destination");
        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Connections));
            intent.PutExtra("username", userName);
            intent.PutExtra("destination", destination_1);
            StartActivity(intent);
        };
    }
}
