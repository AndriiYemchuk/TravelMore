using Android.Content;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Tour : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.tour_description);
        string userName = Intent.GetStringExtra("username");
        int price = Intent.GetIntExtra("price",0);
        string destination = Intent.GetStringExtra("des");
        string title = Intent.GetStringExtra("title");

        TextView pricetext = FindViewById<TextView>(Resource.Id.price);
        TextView name = FindViewById<TextView>(Resource.Id.destination_text);
        ImageView image = FindViewById<ImageView>(Resource.Id.image);
        TextView description = FindViewById<TextView>(Resource.Id.description);
        TextView dates = FindViewById<TextView>(Resource.Id.dates);
        TextView hotel = FindViewById<TextView>(Resource.Id.hotelInfo);

        if (title == "Five days in India")
        {
            image.SetImageResource(Resource.Drawable.India);
            dates.Text = "11 June - 16 June";
            hotel.Text = "You are going to be hosted by one of the best 5-star hotels in the old city centre of Dehli. Just 5 minute-walk to most famous locations";
            description.Text = "A tour in Delhi, the vibrant capital of India, offers a captivating " +
                "blend of ancient heritage and modern culture. Visitors can explore historic landmarks like the Red Fort, " +
                "Qutub Minar, and Humayun's Tomb, while also experiencing the bustling markets of Chandni Chowk and the serene " +
                "beauty of India Gate and Lotus Temple. Delhi's rich history, diverse cuisine, and colorful traditions make it a must-visit destination " +
                "for anyone looking to experience the essence of India.";
        }
        else if (title == "A week in Egypt")
        {
            image.SetImageResource(Resource.Drawable.camel);
            dates.Text = "23 June - 30 June";
            hotel.Text = "You are staying in a 4-star hotel in Cairo downtown. Enjoy the view on Pyramids and all inclusive combined with incredible service!";
            description.Text = "A tour in Egypt is a journey through one of the world's most ancient civilizations. " +
                "In Cairo, visitors can marvel at the iconic Pyramids of Giza and the Sphinx, explore the treasures of the Egyptian Museum, " +
                "and stroll through the lively Khan El Khalili bazaar. Along the Nile, cities like Luxor and Aswan reveal stunning temples, " +
                "tombs, and monuments that speak to Egypt's pharaonic past. With its rich history, unique culture, and warm hospitality, " +
                "Egypt offers an unforgettable travel experience.";
        }
        else if (title == "Fairytale cities")
        {
            image.SetImageResource(Resource.Drawable.fairytale);
            dates.Text = "30 May - 10 June";
            hotel.Text = "Enjoy your 4-star hotel in the city centre of the old city of Prague. More than that, it is all inclusive. It means there are no limits for you!";
            description.Text = "European fairytale cities enchant visitors with their cobblestone streets, " +
                "medieval architecture, and storybook charm. Places like Prague, with its gothic spires and historic bridges, or " +
                "Bruges, known for its winding canals and quaint squares, feel like stepping into a different era. Rothenburg ob der Tauber in " +
                "Germany captivates with timber-framed houses and preserved city walls, while Colmar in France delights with colorful " +
                "buildings and flower-lined canals. These magical towns offer a dreamy escape straight out of a fairytale.";
        }
        else if (title == "Wine fan")
        {
            image.SetImageResource(Resource.Drawable.wine);
            dates.Text = "4 June - 15 June";
            hotel.Text = "Incredible 4-star hotel in the city of Bordeaux is waiting for you! All inclusive service is on already on board";
            description.Text = "A French wine tour is a delightful experience for wine lovers and culture enthusiasts alike. " +
                "Traveling through renowned regions like Bordeaux, Burgundy, and Champagne, visitors can taste world-class " +
                "wines straight from the vineyards, learn about traditional winemaking techniques, and enjoy scenic countryside views. " +
                "Charming villages, historic châteaux, and gourmet French cuisine enhance the journey, making it not just a tasting trip, but a " +
                "full immersion into the art of French living.";
        }
        else if (title == "Mountain seeker")
        {
            image.SetImageResource(Resource.Drawable.mount);
            dates.Text = "14 June - 20 June";
            hotel.Text = "5- star hotel in the middle of Pyrenees is there to host you! Best service and food, because it's located right on the main street!";
            description.Text = "For mountain lovers, Spain offers breathtaking landscapes and thrilling adventures across its diverse ranges. " +
                "The Pyrenees in the north provide stunning hiking trails, alpine scenery, and winter sports, while the Sierra Nevada in the " +
                "south boasts Spain’s highest peaks and charming white villages. The Picos de Europa, with their dramatic cliffs and lush " +
                "valleys, are perfect for nature walks and wildlife spotting. Whether seeking tranquility or outdoor adventure, Spain's mountains " +
                "promise an unforgettable escape into nature.";
        }
        else if (title == "Lazy holiday")
        {
            image.SetImageResource(Resource.Drawable.lazy);
            dates.Text = "1 July - 20 July";
            hotel.Text = "First line 5-star hotel in Acapulca, what can be better? Delicious sea food from Pacific Ocean and mexican cuisine is waiting for you!";
            description.Text = "A lazy beach holiday in Mexico is the perfect way to unwind and soak up the sun. " +
                "With its warm turquoise waters, soft sandy shores, and laid-back vibe, destinations like Cancun, " +
                "Tulum, and Playa del Carmen invite visitors to relax under palm trees, sip tropical cocktails, and enjoy gentle" +
                " ocean breezes. Whether lounging by a resort pool or napping in a beachfront hammock, Mexico’s coastlines offer a " +
                "stress-free paradise for pure relaxation.";
        }

        name.Text = title;

        pricetext.Text = $"Price: {price}$ (including Tax)";

        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Home));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        Button next = FindViewById<Button>(Resource.Id.next_page);
        next.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(PersonalInfo));
            intent.PutExtra("username", userName);
            intent.PutExtra("price", price);
            intent.PutExtra("des", destination);
            StartActivity(intent);
        };
    }
}
