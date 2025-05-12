using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using Android.Views;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Destinations : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.destinations_page);
        string userName = Intent.GetStringExtra("username");
        string destination_1;
        ImageView backButton = FindViewById<ImageView>(Resource.Id.backButton);
        backButton.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Home));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        ImageView image1 = FindViewById<ImageView>(Resource.Id.image1);
        image1.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(DestinationList));
            intent.PutExtra("destination", "Europe");
            intent.PutExtra("photo", "Europe");
            intent.PutExtra("description", "Europe is a must-visit for its rich " +
                "history, diverse cultures, and breathtaking landscapes. " +
                "You can explore ancient ruins, medieval castles, and world-class museums while indulging in incredible cuisine like " +
                "French pastries, Italian pasta, and Spanish tapas. Traveling is seamless with efficient public transport and open borders," +
                " making it easy to hop between vibrant cities and charming small towns. From stunning natural wonders like the Swiss Alps and " +
                "Greek islands to lively festivals and cozy cafés, Europe offers an unforgettable experience. Whether for adventure, relaxation, or cultural immersion, a trip to " +
                "Europe is always worth it!");
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        ImageView image2 = FindViewById<ImageView>(Resource.Id.image2);
        image2.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(DestinationList));
            intent.PutExtra("destination", "Africa");
            intent.PutExtra("photo", "Africa");
            intent.PutExtra("description", "Africa is an incredible destination offering breathtaking natural beauty, " +
                "vibrant cultures, and deep historical roots. From the iconic wildlife safaris in Kenya and South Africa to the majestic" +
                " landscapes of Mount Kilimanjaro, the Sahara Desert, and Victoria Falls, the continent is a paradise for nature lovers and " +
                "adventurers. Rich in cultural diversity, Africa boasts over 2,000 languages and countless traditions, reflected in its music, dance," +
                " art, and cuisine—like jollof rice, injera, and fresh coastal seafood. History buffs can explore ancient civilizations in Egypt, Ethiopia, " +
                "and Mali, while thrill-seekers can dive in Mozambique, trek with gorillas in Uganda, or surf in Morocco. With warm, welcoming " +
                "locals and a refreshing sense of authenticity, Africa promises a travel experience that’s truly unforgettable.");
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        ImageView image3 = FindViewById<ImageView>(Resource.Id.image3);
        image3.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(DestinationList));
            intent.PutExtra("destination", "Asia");
            intent.PutExtra("photo", "Asia");
            intent.PutExtra("description", "Asia is a continent of stunning contrasts, blending ancient traditions with modern innovation. " +
                "From the Great Wall of China and Japan’s historic temples to the bustling streets of Bangkok and the futuristic skyline of " +
                "Singapore, every destination offers a unique experience. Food lovers can indulge in sushi, dumplings, spicy curries, and street food delights, while" +
                " nature enthusiasts can explore everything from tropical beaches in the Maldives to the towering Himalayas. With diverse cultures, " +
                "breathtaking landscapes, and affordable travel options, Asia is an adventure waiting to happen.");
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        ImageView image4 = FindViewById<ImageView>(Resource.Id.image4);
        image4.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(DestinationList));
            intent.PutExtra("destination", "North America");
            intent.PutExtra("photo", "North America");
            intent.PutExtra("username", userName);
            intent.PutExtra("description", "North America is a land of vast landscapes, diverse cultures, and iconic cities. " +
                "From the towering skyscrapers of New York and Toronto to the breathtaking Grand Canyon and Rocky Mountains, the continent offers " +
                "endless adventures. Food lovers can savor everything from Texas BBQ and fresh seafood in New England to authentic tacos in Mexico. " +
                "Whether you're exploring Hollywood, hiking through Yellowstone, or relaxing on the beaches of the Caribbean, North America is packed with unforgettable " +
                "experiences. Its mix of history, modern innovation, and natural wonders makes it a must-visit for any traveler.");
            StartActivity(intent);
        };
        ImageView image5 = FindViewById<ImageView>(Resource.Id.image5);
        image5.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(DestinationList));
            intent.PutExtra("destination", "South America");
            intent.PutExtra("photo", "South America");
            intent.PutExtra("description", "South America is a vibrant, diverse continent that offers something for every kind of traveler—whether you're " +
    "drawn to natural wonders, rich history, colorful cultures, or culinary adventures. You can trek to the ancient ruins of " +
    "Machu Picchu in Peru, marvel at the thundering Iguazu Falls on the Argentina-Brazil border, or explore the otherworldly " +
    "landscapes of Bolivia’s Uyuni Salt Flats and Chile’s Atacama Desert. The Amazon rainforest, the world’s largest, stretches across " +
    "several countries and teems with unique wildlife. South America also pulses with culture—from the tango rhythms of Buenos Aires to " +
    "the samba-fueled streets of Rio de Janeiro, and the Indigenous traditions still alive in the Andes. Add in world-class cuisine like " +
    "Argentine steak, Peruvian ceviche, and Colombian arepas, and you’ve got a continent rich in flavor, soul, and unforgettable adventure.");
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        ImageView image6 = FindViewById<ImageView>(Resource.Id.image6);
        image6.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(DestinationList));
            intent.PutExtra("destination", "Oceania");
            intent.PutExtra("photo", "Oceania");
            intent.PutExtra("description", "Oceania is a dream destination made up of thousands of islands scattered across the Pacific," +
                " offering a mix of stunning natural beauty, unique cultures, and laid-back vibes. Australia dazzles with its diverse landscapes—from the " +
                "Great Barrier Reef and pristine beaches to the rugged Outback and cosmopolitan cities like Sydney and Melbourne. New Zealand is a " +
                "haven for outdoor lovers, with snow-capped mountains, lush forests, and adventure sports galore. " +
                "Oceania is also home to fascinating Indigenous cultures. Whether you’re chasing waves, hiking volcanoes, or soaking in island serenity, Oceania is a place where " +
                "nature and culture blend in the most magical way.");
            intent.PutExtra("username", userName);

            StartActivity(intent);
        };
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image1), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image2), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image3), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image4), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image5), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image6), 30);
    }
    public void ApplyRoundedCorners(ImageView imageView, float radiusDp)
    {
        float radiusPx = TypedValue.ApplyDimension(
            ComplexUnitType.Dip,
            radiusDp,
            imageView.Context.Resources.DisplayMetrics);

        GradientDrawable rounded = new GradientDrawable();
        rounded.SetCornerRadius(radiusPx);
        rounded.SetColor(Android.Graphics.Color.Transparent);

        imageView.Background = rounded;
        imageView.ClipToOutline = true;
    }
}
