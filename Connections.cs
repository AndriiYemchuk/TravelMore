using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using TravelMore;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Connections : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.connections_list);
        string userName = Intent.GetStringExtra("username");
        string destination_1 = Intent.GetStringExtra("destination");
        int from = Intent.GetIntExtra("from",0);
        int to = Intent.GetIntExtra("to",0);
        string startdate = Intent.GetStringExtra("startdate");
        string enddate = Intent.GetStringExtra("enddate");

        Button myButton = FindViewById<Button>(Resource.Id.train_button);

        Button myButton2 = FindViewById<Button>(Resource.Id.bus_button);

        Button myButton3 = FindViewById<Button>(Resource.Id.plane_button);

        ImageView image = FindViewById<ImageView>(Resource.Id.image);
        TextView text = FindViewById<TextView>(Resource.Id.text);

        image.Visibility = ViewStates.Visible;
        text.Visibility = ViewStates.Visible;

        Tickets list = new Tickets();

        string from1;
        string to1;

        if (from == 1)
        {
            from1 = "Kyiv";
        }
        else if (from == 2)
        {
            from1 = "Lviv";
        }
        else if (from == 3)
        {
            from1 = "Kharkiv";
        }
        else if (from == 4)
        {
            from1 = "Odesa";
        }
        else
        {
            from1 = "Kyiv";
        }


        if (to == 1)
        {
            to1 = "Berlin";
        }
        else if (to == 2)
        {
            to1 = "Munich";
        }
        else if (to == 3)
        {
            to1 = "Frankfurt";
        }
        else if (to == 4)
        {
            to1 = "Duesseldorf";
        }
        else
        {
            to1 = "Berlin";
        }

        TextView dates = FindViewById<TextView>(Resource.Id.datesoftrip);

        DateTime parsedDate = DateTime.Parse(startdate);
        string formattedDate = parsedDate.ToString("dd MMMM");

        dates.Text = formattedDate;

        TicketManager1.tickets.Clear();
        TicketManager1.tickets.Add(new Tickets { destination = to1, departure = "7:00", duration = "24hrs", transport = "flixbus", arrival = "7:00", place = from1, date = startdate });
        TicketManager1.tickets.Add(new Tickets { destination = to1, departure = "10:00", duration = "22hrs", transport = "euroclub", arrival = "8:00", place = from1, date = startdate });

        LinearLayout container3 = FindViewById<LinearLayout>(Resource.Id.ticketcontainer);
        LinearLayout container1 = FindViewById<LinearLayout>(Resource.Id.ticketcontainer);
        LayoutInflater inflater = this.LayoutInflater;

        View ticketView = inflater.Inflate(Resource.Layout.ticket_item, null);

        myButton.Click += (sender, e) =>
        {
            myButton.SetBackgroundResource(Resource.Drawable.trainbutton_dark);
            myButton2.SetBackgroundResource(Resource.Drawable.busbutton);
            myButton3.SetBackgroundResource(Resource.Drawable.planebutton);

            ImageView image = FindViewById<ImageView>(Resource.Id.image);
            TextView text = FindViewById<TextView>(Resource.Id.text);

            image.Visibility = ViewStates.Visible;
            text.Visibility = ViewStates.Visible;

            foreach (var ticket in TicketManager1.tickets)
            {
                container3.RemoveView(ticketView);
            };


            };
        myButton2.Click += (sender, e) =>
        {
            myButton.SetBackgroundResource(Resource.Drawable.trainbutton);
            myButton2.SetBackgroundResource(Resource.Drawable.busbutton_dark);
            myButton3.SetBackgroundResource(Resource.Drawable.planebutton);

            ImageView image = FindViewById<ImageView>(Resource.Id.image);
            TextView text = FindViewById<TextView>(Resource.Id.text);

            image.Visibility = ViewStates.Gone;
            text.Visibility = ViewStates.Gone;

            foreach (var ticket in TicketManager1.tickets)
            {
                LinearLayout container3 = FindViewById<LinearLayout>(Resource.Id.ticketcontainer);
                LinearLayout container1 = FindViewById<LinearLayout>(Resource.Id.ticketcontainer);
                LayoutInflater inflater = this.LayoutInflater;

                View ticketView = inflater.Inflate(Resource.Layout.ticket_item, null);

                container3.RemoveView(ticketView);

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
                    Intent intent = new Intent(this, typeof(ConnectionsBack));
                    intent.PutExtra("username", userName);
                    intent.PutExtra("destination", destination_1);
                    intent.PutExtra("from", from);
                    intent.PutExtra("to", to);
                    intent.PutExtra("startdate", startdate);
                    intent.PutExtra("enddate", enddate);
                    StartActivity(intent);
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
                else if (ticket.transport == "euroclub")
                {
                    img.SetImageResource(Resource.Drawable.euroclub);
                    img1.SetImageResource(Resource.Drawable.bus);
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

                container3.AddView(ticketView);
            };

        };
        myButton3.Click += (sender, e) =>
        {
            myButton.SetBackgroundResource(Resource.Drawable.trainbutton);
            myButton2.SetBackgroundResource(Resource.Drawable.busbutton);
            myButton3.SetBackgroundResource(Resource.Drawable.planebutton_dark);

            ImageView image = FindViewById<ImageView>(Resource.Id.image);
            TextView text = FindViewById<TextView>(Resource.Id.text);

            image.Visibility = ViewStates.Visible;
            text.Visibility = ViewStates.Visible;

            foreach (var ticket in TicketManager1.tickets)
            {
                    container3.RemoveView(ticketView);

            };

            };

        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(DatesOfTrip));
            intent.PutExtra("username", userName);
            intent.PutExtra("destination", destination_1);
            intent.PutExtra("from", from);
            intent.PutExtra("to", to);
            intent.PutExtra("startdate", startdate);
            intent.PutExtra("enddate", enddate);
            StartActivity(intent);
        };
    }
    public class Tickets
    {
        public string destination { get; set; }
        public string departure { get; set; }
        public string duration { get; set; }
        public string transport { get; set; }
        public string arrival { get; set; }
        public string place { get; set; }
        public string date { get; set; }
        public string price { get; set; }
    }
    public static class TicketManager1
    {
        public static List<Tickets> tickets { get; } = new List<Tickets>();
    }
}

