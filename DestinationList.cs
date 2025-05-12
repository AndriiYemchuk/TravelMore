using Android.Content;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class DestinationList : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.Destination);

        string destination_1 = Intent.GetStringExtra("destination");
        string photo1 = Intent.GetStringExtra("photo");
        string description = Intent.GetStringExtra("description");
        string userName = Intent.GetStringExtra("username");


        TextView destinations = FindViewById<TextView>(Resource.Id.destination_text);
        destinations.Text = $"{destination_1}";

        TextView description1 = FindViewById<TextView>(Resource.Id.description);
        description1.Text = $"{description}";

        Button button= FindViewById<Button>(Resource.Id.next_page);
        button.Text = $"I want to go to {destination_1}!";

        button.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Countries));
            intent.PutExtra("username", userName);
            intent.PutExtra("destination", destination_1);
            StartActivity(intent);
        };

        ImageView photo = FindViewById<ImageView>(Resource.Id.photo);
        if (photo1 == "Europe")
        {
            photo.SetImageResource(Resource.Drawable.Europe);
        }
        else if (photo1 == "Africa")
        {
            photo.SetImageResource(Resource.Drawable.Africa);
        }
        else if (photo1 == "Asia")
        {
            photo.SetImageResource(Resource.Drawable.Asia);
        }
        else if (photo1 == "North America")
        {
            photo.SetImageResource(Resource.Drawable.NorthAmerica);
        }
        else if (photo1 == "South America")
        {
            photo.SetImageResource(Resource.Drawable.SouthAmerica);
        }
        else if (photo1 == "Oceania")
        {
            photo.SetImageResource(Resource.Drawable.Oceania);
        }
        ImageView backButton = FindViewById<ImageView>(Resource.Id.backButton);
        backButton.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Destinations));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
    }
}
