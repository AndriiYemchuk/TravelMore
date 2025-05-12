using Android.Content;
using static Android.Graphics.ColorSpace;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Tours : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.tours_page);
        string userName = Intent.GetStringExtra("username");

        Button india = FindViewById<Button>(Resource.Id.india_Button);
        india.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("title", "Five days in India");
            intent.PutExtra("des", "Have a perfect time in India");
            intent.PutExtra("price", 3900);
            StartActivity(intent);
        };
        Button egypt = FindViewById<Button>(Resource.Id.egypt);
        egypt.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("title", "A week in Egypt");
            intent.PutExtra("des", "Have a perfect time in Egypt");
            intent.PutExtra("price", 1900);
            StartActivity(intent);
        };
        Button cities = FindViewById<Button>(Resource.Id.fairytalebutton);
        cities.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("title", "Fairytale cities");
            intent.PutExtra("des", "Have a perfect time in Europe");
            intent.PutExtra("price", 1900);
            StartActivity(intent);
        };
        Button wine = FindViewById<Button>(Resource.Id.wine);
        wine.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("title", "Wine fan");
            intent.PutExtra("des", "WineTour");
            intent.PutExtra("price", 3000);
            StartActivity(intent);
        };
        Button mountains = FindViewById<Button>(Resource.Id.mountains);
        mountains.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("title", "Mountain seeker");
            intent.PutExtra("des", "Mountains");
            intent.PutExtra("price", 2300);
            StartActivity(intent);
        };
        Button holiday = FindViewById<Button>(Resource.Id.holiday);
        holiday.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("title", "Lazy holiday");
            intent.PutExtra("des", "Holiday");
            intent.PutExtra("price", 5000);
            StartActivity(intent);
        };


        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Home));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
    }
}
