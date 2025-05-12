using Android.Content;
using Android.Views;
using static Android.Icu.Text.CaseMap;
using TravelMore;
using System.Reflection;
using Java.Util.Zip;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Tickets : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.tickets_page);
        string userName = Intent.GetStringExtra("username");

        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(Home));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };

        TextView ticketcounter = FindViewById<TextView>(Resource.Id.tickets_counter);
        TextView text1 = FindViewById<TextView>(Resource.Id.text1);
        ImageView icon = FindViewById<ImageView>(Resource.Id.ticketicon);
        int count = TicketManager.Tickets.Count;
        if (count <= 0)
        {
            ticketcounter.Visibility = ViewStates.Gone;
            text1.Visibility = ViewStates.Visible;
            icon.Visibility = ViewStates.Visible;
        }
        else if (count > 0)
        {
            ticketcounter.Visibility = ViewStates.Visible;
            ticketcounter.Text = ($"Your tickets: {count}");
            text1.Visibility = ViewStates.Gone;
            icon.Visibility = ViewStates.Gone;
        }

        foreach (var ticket in TicketManager.Tickets)
        {
            LinearLayout container = FindViewById<LinearLayout>(Resource.Id.ticketcontainer);
            LinearLayout container1 = FindViewById<LinearLayout>(Resource.Id.ticketcontainer);
            LayoutInflater inflater = this.LayoutInflater;

                View ticketView = inflater.Inflate(Resource.Layout.ticket_item, null);

                ImageView img = ticketView.FindViewById<ImageView>(Resource.Id.ticket_image);
                ImageView img1 = ticketView.FindViewById<ImageView>(Resource.Id.transport);
                TextView title = ticketView.FindViewById<TextView>(Resource.Id.ticket_title);
                TextView time = ticketView.FindViewById<TextView>(Resource.Id.ticket_time);
                TextView duration = ticketView.FindViewById<TextView>(Resource.Id.ticket_duration);
                TextView arrival = ticketView.FindViewById<TextView>(Resource.Id.ticket_arrival);
                TextView place = ticketView.FindViewById<TextView>(Resource.Id.ticket_place);
            TextView date = ticketView.FindViewById<TextView>(Resource.Id.date);
            ImageView showticket1 = ticketView.FindViewById<ImageView>(Resource.Id.showticket1);
            showticket1.Click += (sender, e) =>
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                LayoutInflater inflater = LayoutInflater.From(this);
                View dialogView = inflater.Inflate(Resource.Layout.fullTicket, null);
                builder.SetView(dialogView);

                AlertDialog dialog = builder.Create();

                ImageView closeButton = dialogView.FindViewById<ImageView>(Resource.Id.backButton);
                closeButton.Click += (s, args) => dialog.Dismiss();

                dialog.Show();
            };

            title.Text = ticket.destination;
                time.Text = ticket.departure;
                duration.Text = ticket.duration;
                arrival.Text = ticket.arrival;
                place.Text = ticket.place;
            date.Text = ticket.date;

                if (ticket.transport == "indian")
                {
                    img.SetImageResource(Resource.Drawable.indian);
                    img1.SetImageResource(Resource.Drawable.plane);
                }
                else if (ticket.transport == "skyup")
                {
                    img.SetImageResource(Resource.Drawable.skyup);
                    img1.SetImageResource(Resource.Drawable.plane);
                }
                else if (ticket.transport == "flixbus")
                {
                    img.SetImageResource(Resource.Drawable.flixbus);
                    img1.SetImageResource(Resource.Drawable.bus);
                }
                else if (ticket.transport == "WizzAir")
                {
                    img.SetImageResource(Resource.Drawable.wizzair);
                    img1.SetImageResource(Resource.Drawable.plane);
                }
                else if (ticket.transport == "Ryanair")
                {
                    img.SetImageResource(Resource.Drawable.Ryanair);
                    img1.SetImageResource(Resource.Drawable.plane);
                }

                container.AddView(ticketView);
           
        }
    }
}
public class Ticket
{
    public string destination { get; set; }
    public string departure { get; set; }
    public string duration { get; set; }
    public string transport { get; set; }
    public string arrival { get; set; }
    public string place { get; set; }
    public string date { get; set; }
}
public static class TicketManager
{
    public static List<Ticket> Tickets { get; } = new List<Ticket>();
}
