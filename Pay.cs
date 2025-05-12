using System.Text.RegularExpressions;
using Android.Content;
using Android.Text;
using Android.Text.Method;
using Android.Widget;
using Java.Lang;
using System.Text.RegularExpressions;
using TravelMore;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class Pay : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.payment_page);
        string userName = Intent.GetStringExtra("username");
        int price = Intent.GetIntExtra("price", 0);
        string destination = Intent.GetStringExtra("des");
        int people = Intent.GetIntExtra("people", 1);


        TextView star1 = FindViewById<TextView>(Resource.Id.star1);
        TextView star2 = FindViewById<TextView>(Resource.Id.star2);
        TextView star3 = FindViewById<TextView>(Resource.Id.star3);
        TextView star4 = FindViewById<TextView>(Resource.Id.star4);

        star1.Visibility = Android.Views.ViewStates.Gone;
        star2.Visibility = Android.Views.ViewStates.Gone;
        star3.Visibility = Android.Views.ViewStates.Gone;
        star4.Visibility = Android.Views.ViewStates.Gone;



        int finalprice = price * people;

        TextView total = FindViewById<TextView>(Resource.Id.total);
        total.Text = $"Total: {finalprice}$";

        EditText cardInput = FindViewById<EditText>(Resource.Id.cardnumberinput);

        cardInput.AddTextChangedListener(new CardNumberTextWatcher(cardInput));
        EditText expiration = FindViewById<EditText>(Resource.Id.expitationdate);

        expiration.AddTextChangedListener(new ExpDateTextWatcher(expiration));


        EditText cvv = FindViewById<EditText>(Resource.Id.CVV);
        EditText cardholdername = FindViewById<EditText>(Resource.Id.cardholdername);

        ImageView back = FindViewById<ImageView>(Resource.Id.back);
        back.Click += (sender, e) =>
        {

            Intent intent = new Intent(this, typeof(PersonalInfo));
            intent.PutExtra("username", userName);
            intent.PutExtra("price", price);
            StartActivity(intent);
        };
        Button next = FindViewById<Button>(Resource.Id.next_page);
        next.Click += (sender, e) =>
        {
            if (cardInput.Text.Length<19||(expiration.Text.Length<5)||(cvv.Text.Length<3)||(string.IsNullOrWhiteSpace(cardholdername.Text)))
            {
                if (cardInput.Text.Length < 19)
                {
                    star1.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star1.Visibility = Android.Views.ViewStates.Gone;
                }
                if (expiration.Text.Length < 5)
                {
                    star2.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star2.Visibility = Android.Views.ViewStates.Gone;
                }
                if (cvv.Text.Length < 3)
                {
                    star3.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star3.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(cardholdername.Text))
                {
                    star4.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star4.Visibility = Android.Views.ViewStates.Gone;
                }
            }
            else
            {
                Intent intent = new Intent(this, typeof(Booked));
                intent.PutExtra("username", userName);
                StartActivity(intent);

                if (destination == "Have a perfect time in India")
                {
                    Ticket list = new Ticket();
                    TicketManager.Tickets.Add(new Ticket { destination = "Warsaw", departure = "7:00", duration = "15hrs", transport = "flixbus", arrival = "22:00", place = "Kyiv", date = "Wed.11.06.2025" });
                    TicketManager.Tickets.Add(new Ticket { destination = "Dehli", departure = "1:00", duration = "9hrs", transport = "indian", arrival = "10:00", place = "Warsaw", date = "Thu.12.06.2025" });
                }
                else if (destination == "Have a perfect time in Egypt")
                {
                    Ticket list = new Ticket();
                    TicketManager.Tickets.Add(new Ticket { destination = "Warsaw", departure = "9:00", duration = "16hrs", transport = "flixbus", arrival = "1:00", place = "Kyiv", date = "Mon.23.06.2025" });
                    TicketManager.Tickets.Add(new Ticket { destination = "Cairo", departure = "5:00", duration = "2:30hrs", transport = "skyup", arrival = "7:30", place = "Warsaw", date = "Tue.24.06.2025" });
                }
                else if (destination == "Have a perfect time in Europe")
                {
                    Ticket list = new Ticket();
                    TicketManager.Tickets.Add(new Ticket { destination = "Krakow", departure = "12:00", duration = "8hrs", transport = "flixbus", arrival = "20:00", place = "Lviv", date = "Fr.30.05.2025" });
                }
                else if (destination == "WineTour")
                {
                    Ticket list = new Ticket();
                    TicketManager.Tickets.Add(new Ticket { destination = "Berlin", departure = "7:00", duration = "23hrs", transport = "flixbus", arrival = "6:00", place = "Kyiv", date = "Wed.04.06.2025" });
                    TicketManager.Tickets.Add(new Ticket { destination = "Bordeaux", departure = "9:00", duration = "2hrs", transport = "WizzAir", arrival = "11:00", place = "Berlin", date = "Thu.05.06.2025" });
                }
                else if (destination == "Mountains")
                {
                    Ticket list = new Ticket();
                    TicketManager.Tickets.Add(new Ticket { destination = "Poznan", departure = "6:00", duration = "19hrs", transport = "flixbus", arrival = "1:00", place = "Kyiv", date = "Sat.14.06.2025" });
                    TicketManager.Tickets.Add(new Ticket { destination = "Murcia", departure = "5:00", duration = "2hrs", transport = "Ryanair", arrival = "7:00", place = "Berlin", date = "Sun.15.06.2025" });
                }
                else if (destination == "Holiday")
                {
                    Ticket list = new Ticket();
                    TicketManager.Tickets.Add(new Ticket { destination = "Warsaw", departure = "10:00", duration = "10hrs", transport = "flixbus", arrival = "20:00", place = "Lviv", date = "Tue.01.07.2025" });
                    TicketManager.Tickets.Add(new Ticket { destination = "Acapulco", departure = "22:00", duration = "16hrs", transport = "Ryanair", arrival = "14:00", place = "Warsaw", date = "Tue.01.07.2025" });
                }
            }
        };
    }
    public class CardNumberTextWatcher : Java.Lang.Object, ITextWatcher
    {
        private readonly EditText editText;
        private bool isEditing;

        public CardNumberTextWatcher(EditText editText)
        {
            this.editText = editText;
        }

        public void AfterTextChanged(IEditable s)
        {
            if (isEditing) return;

            isEditing = true;

            string clean = Regex.Replace(s.ToString(), @"\D", "");

            if (clean.Length > 16)
                clean = clean.Substring(0, 16);

            var formatted = new System.Text.StringBuilder();
            for (int i = 0; i < clean.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                    formatted.Append(" ");
                formatted.Append(clean[i]);
            }

            string newText = formatted.ToString();
            if (!newText.Equals(editText.Text))
            {
                int cursorPosition = newText.Length;
                editText.RemoveTextChangedListener(this);
                editText.Text = newText;
                editText.SetSelection(cursorPosition);
                editText.AddTextChangedListener(this);
            }

            isEditing = false;

        }

        public void BeforeTextChanged(ICharSequence s, int start, int count, int after) { }

        public void OnTextChanged(ICharSequence s, int start, int before, int count) { }
    }


    public class ExpDateTextWatcher : Java.Lang.Object, ITextWatcher
    {
        private readonly EditText editText;
        private bool isEditing;

        public ExpDateTextWatcher(EditText editText)
        {
            this.editText = editText;
        }

        public void AfterTextChanged(IEditable s)
        {
            if (isEditing) return;
            isEditing = true;

            string clean = Regex.Replace(s.ToString(), @"\D", "");

            if (clean.Length > 4)
                clean = clean.Substring(0, 4);

            var formatted = new System.Text.StringBuilder();
            for (int i = 0; i < clean.Length; i++)
            {
                if (i == 2)
                    formatted.Append('/');
                formatted.Append(clean[i]);
            }

            string newText = formatted.ToString();
            if (!newText.Equals(editText.Text))
            {
                int cursorPosition = newText.Length;
                editText.RemoveTextChangedListener(this);
                editText.Text = newText;
                editText.SetSelection(cursorPosition);
                editText.AddTextChangedListener(this);
            }
            if (clean.Length >= 4)
            {
                int month = int.Parse(clean.Substring(0, 2));
                int year = int.Parse(clean.Substring(2, 2));

                if (month < 1 || month > 12)
                {
                    editText.Error = "Invalid data";
                }
                else
                {
                    var now = DateTime.Now;
                    int currentYear = now.Year % 100;
                    int currentMonth = now.Month;

                    if (year < currentYear || (year == currentYear && month < currentMonth))
                    {
                        editText.Error = "Date expired";
                    }
                    else
                    {
                        editText.Error = null;
                    }
                }
            }

            isEditing = false;
        }

        public void BeforeTextChanged(ICharSequence s, int start, int count, int after) { }

        public void OnTextChanged(ICharSequence s, int start, int before, int count) { }
    }
}