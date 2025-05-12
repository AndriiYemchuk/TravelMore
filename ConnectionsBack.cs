using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using TravelMore;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class ConnectionsBack : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.connection_back);
        string userName = Intent.GetStringExtra("username");
        string destination_1 = Intent.GetStringExtra("destination");
        string from = Intent.GetStringExtra("from");
        string to = Intent.GetStringExtra("to");
        string startdate = Intent.GetStringExtra("startdate");
        string enddate = Intent.GetStringExtra("enddate");

        Button myButton = FindViewById<Button>(Resource.Id.train_button);

        Button myButton2 = FindViewById<Button>(Resource.Id.bus_button);

        Button myButton3 = FindViewById<Button>(Resource.Id.plane_button);


        TextView dates = FindViewById<TextView>(Resource.Id.datesoftrip);

        DateTime parsedDate = DateTime.Parse(enddate);
        string formattedDate = parsedDate.ToString("dd MMMM");

        dates.Text = formattedDate;
    }
}
