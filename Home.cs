using Android.Content;
using Android.Views;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Home : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.home_page);
        string userName = Intent.GetStringExtra("username");
        bool saved1 = Intent.GetBooleanExtra("saved", saved);
    TextView greeting = FindViewById<TextView>(Resource.Id.Welcome_text);
        greeting.Text = $"Welcome back {userName}!";

        ImageView profile_button = FindViewById<ImageView>(Resource.Id.profile_button);
        profile_button.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Profile_list));
            intent.PutExtra("username", userName);
            intent.PutExtra("saved", saved);
            StartActivity(intent);
        };
        Button more_tours = FindViewById<Button>(Resource.Id.more_tours);
        more_tours.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tours));
            intent.PutExtra("username", userName);
            intent.PutExtra("saved", saved);
            StartActivity(intent);
        };
        Button india = FindViewById<Button>(Resource.Id.india_Button);
        india.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("saved", saved);
            intent.PutExtra("title","Five days in India");
            intent.PutExtra("des", "Have a perfect time in India");
            intent.PutExtra("price", 3900);
            StartActivity(intent);
        };
        Button egypt = FindViewById<Button>(Resource.Id.egypt);
        egypt.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("saved", saved);
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
            intent.PutExtra("saved", saved);
            intent.PutExtra("title", "Fairytale cities");
            intent.PutExtra("des", "Have a perfect time in Europe");
            intent.PutExtra("price", 1900);
            StartActivity(intent);
        };
        Button destination_Button = FindViewById<Button>(Resource.Id.destination_Button);
        destination_Button.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Destinations));
            intent.PutExtra("username", userName);
            intent.PutExtra("saved", saved1);
            StartActivity(intent);
        };

        Button tickets_button = FindViewById<Button>(Resource.Id.ticket_Button);
        tickets_button.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tickets));
            intent.PutExtra("username", userName);
            intent.PutExtra("saved", saved1);
            StartActivity(intent);
        };
        if (saved == true)
        {
            ImageView tour1 = FindViewById<ImageView>(Resource.Id.days_in_india);
            tour1.SetImageResource(Resource.Drawable.saved_black);
        }
        else if (saved == false)
        {
            ImageView tour1 = FindViewById<ImageView>(Resource.Id.days_in_india);
            tour1.SetImageResource(Resource.Drawable.saved);
        }
        ImageView days_in_india = FindViewById<ImageView>(Resource.Id.days_in_india);
        days_in_india.Click += (sender, e) =>
        {
            if (saved == false)
            {
                saved = true;
                saved1 = true;
            }
            else if (saved == true)
            {
                saved = false;
                saved1 = false;
            }
        };
    }
    public bool saved;
}
