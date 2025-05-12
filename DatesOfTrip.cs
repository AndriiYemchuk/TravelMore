using Android.Content;
using Android.Views;
using Google.Android.Material.DatePicker;
using Java.Lang;
using AndroidX.Fragment.App;
using AndroidX.AppCompat.App;
using AndroidX.Core.Util;
using Android.Util;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class DatesOfTrip : FragmentActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.dates_of_trip);
        string userName = Intent.GetStringExtra("username");
        string destination_1 = Intent.GetStringExtra("destination");

        TextView startdate = FindViewById<TextView>(Resource.Id.dateofstart);
        TextView enddate = FindViewById<TextView>(Resource.Id.dateofreturn);

        Spinner mySpinner = FindViewById<Spinner>(Resource.Id.from);
        var items = new List<string> { "Choose your departure..", "Kyiv", "Lviv", "Kharkiv", "Odesa" };
        Spinner mySpinner2 = FindViewById<Spinner>(Resource.Id.to);
        var items2 = new List<string> { "Choose your destination..", "Berlin", "Munich", "Frankfurt", "Duesseldorf" };


        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Countries));
            intent.PutExtra("username", userName);
            intent.PutExtra("destination", destination_1);
            StartActivity(intent);
        };


        Button next_page = FindViewById<Button>(Resource.Id.next_page);
        next_page.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Connections));
            intent.PutExtra("username", userName);
            intent.PutExtra("destination", destination_1);
            intent.PutExtra("from", mySpinner.SelectedItemPosition);
            intent.PutExtra("to", mySpinner2.SelectedItemPosition);
            intent.PutExtra("startdate", startdate.Text);
            intent.PutExtra("enddate", enddate.Text);
            StartActivity(intent);
        };

        var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items);
        adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

        var adapter2 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items2);
        adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

        mySpinner.Adapter = adapter;
        mySpinner2.Adapter = adapter2;

        mySpinner.ItemSelected += (s, e) =>
        {
            string selected = items[e.Position];
        };
        mySpinner2.ItemSelected += (s, e) =>
        {
            string selected = items2[e.Position];
        };
        TextView dateSpinner = FindViewById<TextView>(Resource.Id.departure);
        dateSpinner.Click += (sender, e) =>
        {
            ShowStartDatePicker();
        };

        TextView dateSpinner2 = FindViewById<TextView>(Resource.Id.arrival);
        dateSpinner2.Click += (sender, e) =>
        {
            ShowEndDatePicker();
        };

    }
    DateTime startDate;
    DateTime endDate;

    private void ShowStartDatePicker()
    {
        var today = DateTime.Today;
        var dialog = new DatePickerDialog(this, OnStartDateSet, today.Year, today.Month - 1, today.Day);
        dialog.Show();
    }

    private void ShowEndDatePicker()
    {
        var today = DateTime.Today;
        var dialog = new DatePickerDialog(this, OnEndDateSet, today.Year, today.Month - 1, today.Day);
        dialog.Show();
    }
    private void OnStartDateSet(object sender, DatePickerDialog.DateSetEventArgs e)
    {
        startDate = e.Date;
        TextView startdate = FindViewById<TextView>(Resource.Id.dateofstart);
        startdate.Text = ($"{startDate:yyyy-MM-dd}");
    }

    private void OnEndDateSet(object sender, DatePickerDialog.DateSetEventArgs e)
    {
        endDate = e.Date;
        TextView enddate = FindViewById<TextView>(Resource.Id.dateofreturn);
        enddate.Text = ($"{endDate:yyyy-MM-dd}");
    }
}
