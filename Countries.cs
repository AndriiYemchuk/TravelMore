using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Countries : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.countries_list);
        string userName = Intent.GetStringExtra("username");
        string destination_1 = Intent.GetStringExtra("destination");

        TextView destination_text = FindViewById<TextView>(Resource.Id.destination_text);
        TextView text1 = FindViewById<TextView>(Resource.Id.text1);
        TextView text2 = FindViewById<TextView>(Resource.Id.text2);
        TextView text3 = FindViewById<TextView>(Resource.Id.text3);
        TextView text4 = FindViewById<TextView>(Resource.Id.text4);
        TextView text5 = FindViewById<TextView>(Resource.Id.text5);
        TextView text6 = FindViewById<TextView>(Resource.Id.text6);

        ImageView image1 = FindViewById<ImageView>(Resource.Id.image1);
        ImageView image2 = FindViewById<ImageView>(Resource.Id.image2);
        ImageView image3 = FindViewById<ImageView>(Resource.Id.image3);
        ImageView image4 = FindViewById<ImageView>(Resource.Id.image4);
        ImageView image5 = FindViewById<ImageView>(Resource.Id.image5);
        ImageView image6 = FindViewById<ImageView>(Resource.Id.image6);
        destination_text.Text = $"Countries in {destination_1}";
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image1), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image2), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image3), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image4), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image5), 30);
        ApplyRoundedCorners(FindViewById<ImageView>(Resource.Id.image6), 30);


        if (destination_1 == "Europe")
        {
            text1.Text = "Germany";
            text2.Text = "France";
            text3.Text = "Italy";
            text4.Text = "Spain";
            text5.Text = "United Kingdom";
            text6.Text = "Czech Republic";

            ImageView[] targetImages = new ImageView[]
{
    FindViewById<ImageView>(Resource.Id.image1),
    FindViewById<ImageView>(Resource.Id.image2),
    FindViewById<ImageView>(Resource.Id.image3),
    FindViewById<ImageView>(Resource.Id.image4),
    FindViewById<ImageView>(Resource.Id.image5),
    FindViewById<ImageView>(Resource.Id.image6)
};


            int[] imageResources = new int[]
            {
    Resource.Drawable.germany,
    Resource.Drawable.france,
    Resource.Drawable.italy,
    Resource.Drawable.spain,
    Resource.Drawable.unitedkingdom,
    Resource.Drawable.czechia
            };
            for (int i = 0; i < targetImages.Length; i++)
            {
                if (targetImages[i] != null)
                {
                    targetImages[i].SetImageResource(imageResources[i]);
                }
            }
         
            image1.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(DatesOfTrip));
                intent.PutExtra("username", userName);
                intent.PutExtra("destination", destination_1);
                StartActivity(intent);
            };
        }
        else if (destination_1 == "Africa")
        {
            text1.Text = "Egypt";
            text2.Text = "Morocco";
            text3.Text = "South Africa";
            text4.Visibility = ViewStates.Gone;
            text5.Visibility = ViewStates.Gone;
            text6.Visibility = ViewStates.Gone;
            image4.Visibility = ViewStates.Gone;
            image5.Visibility = ViewStates.Gone;
            image6.Visibility = ViewStates.Gone;


            ImageView[] targetImages = new ImageView[]
{
    FindViewById<ImageView>(Resource.Id.image1),
    FindViewById<ImageView>(Resource.Id.image2),
    FindViewById<ImageView>(Resource.Id.image3),
};

            int[] imageResources = new int[]
{
    Resource.Drawable.egypt,
    Resource.Drawable.morocco,
    Resource.Drawable.southafrica,
};
            for (int i = 0; i < targetImages.Length; i++)
            {
                if (targetImages[i] != null)
                {
                    targetImages[i].SetImageResource(imageResources[i]);
                }
            }
        }
        else if (destination_1 == "Asia")
        {
            text1.Text = "Japan";
            text2.Text = "South Korea";
            text3.Text = "Vietnam";
            text4.Text = "Laos";
            text5.Text = "India";
            text6.Text = "Thailand";

            ImageView[] targetImages = new ImageView[]
{
    FindViewById<ImageView>(Resource.Id.image1),
    FindViewById<ImageView>(Resource.Id.image2),
    FindViewById<ImageView>(Resource.Id.image3),
    FindViewById<ImageView>(Resource.Id.image4),
    FindViewById<ImageView>(Resource.Id.image5),
    FindViewById<ImageView>(Resource.Id.image6)
};

            int[] imageResources = new int[]
{
    Resource.Drawable.japan,
    Resource.Drawable.southkorea,
    Resource.Drawable.vietnam,
    Resource.Drawable.laos,
    Resource.Drawable.india2,
    Resource.Drawable.thailand
};
            for (int i = 0; i < targetImages.Length; i++)
            {
                if (targetImages[i] != null)
                {
                    targetImages[i].SetImageResource(imageResources[i]);
                }
            }
        }
        else if (destination_1 == "North America")
        {
            destination_text.TextSize = 20;
            text1.Text = "United States of America";
            text1.TextSize = 27;
            text2.Text = "Mexico";
            text3.Text = "Canada";
            text4.Text = "Panama";
            text5.Visibility = ViewStates.Gone;
            text6.Visibility = ViewStates.Gone;
            image5.Visibility = ViewStates.Gone;
            image6.Visibility = ViewStates.Gone;

            ImageView[] targetImages = new ImageView[]
{
    FindViewById<ImageView>(Resource.Id.image1),
    FindViewById<ImageView>(Resource.Id.image2),
    FindViewById<ImageView>(Resource.Id.image3),
    FindViewById<ImageView>(Resource.Id.image4),
};
            int[] imageResources = new int[]
{
    Resource.Drawable.usa,
    Resource.Drawable.mexico,
    Resource.Drawable.canada,
    Resource.Drawable.panama,
};
            for (int i = 0; i < targetImages.Length; i++)
            {
                if (targetImages[i] != null)
                {
                    targetImages[i].SetImageResource(imageResources[i]);
                }
            }
        

    }
        else if (destination_1 == "South America")
        {
            destination_text.TextSize = 20;
            text1.Text = "Bolivia";
            text2.Text = "Brazil";
            text3.Text = "Argentina";
            text4.Text = "Chile";
            text5.Visibility = ViewStates.Gone;
            text6.Visibility = ViewStates.Gone;
            image5.Visibility = ViewStates.Gone;
            image6.Visibility = ViewStates.Gone;

            ImageView[] targetImages = new ImageView[]
{
    FindViewById<ImageView>(Resource.Id.image1),
    FindViewById<ImageView>(Resource.Id.image2),
    FindViewById<ImageView>(Resource.Id.image3),
    FindViewById<ImageView>(Resource.Id.image4),
};
            int[] imageResources = new int[]
{
    Resource.Drawable.bolivia,
    Resource.Drawable.brazil,
    Resource.Drawable.argentina,
    Resource.Drawable.chile,
};
            for (int i = 0; i < targetImages.Length; i++)
            {
                if (targetImages[i] != null)
                {
                    targetImages[i].SetImageResource(imageResources[i]);
                }
            }
        }
        else if (destination_1 == "Oceania")
        {
            text1.Text = "Australia";
            text2.Text = "New Zeland";
            text3.Visibility = ViewStates.Gone;
            text4.Visibility = ViewStates.Gone;
            text5.Visibility = ViewStates.Gone;
            text6.Visibility = ViewStates.Gone;
            image3.Visibility = ViewStates.Gone;
            image4.Visibility = ViewStates.Gone;
            image5.Visibility = ViewStates.Gone;
            image6.Visibility = ViewStates.Gone;

            ImageView[] targetImages = new ImageView[]
{
    FindViewById<ImageView>(Resource.Id.image1),
    FindViewById<ImageView>(Resource.Id.image2),
};

            int[] imageResources = new int[]
{
    Resource.Drawable.australia,
    Resource.Drawable.newzeland,
};
            for (int i = 0; i < targetImages.Length; i++)
            {
                if (targetImages[i] != null)
                {
                    targetImages[i].SetImageResource(imageResources[i]);
                }
            }
        }

        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Destinations));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
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
