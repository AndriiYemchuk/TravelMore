using Android.Content;
using static Android.Content.ClipData;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class PersonalInfo : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.personal_inforamtion_page);
        string userName = Intent.GetStringExtra("username");
        string destination = Intent.GetStringExtra("des");
        int price = Intent.GetIntExtra("price",0);

        TextView star1 = FindViewById<TextView>(Resource.Id.star1);
        TextView star2 = FindViewById<TextView>(Resource.Id.star2);
        TextView star3 = FindViewById<TextView>(Resource.Id.star3);
        TextView star4 = FindViewById<TextView>(Resource.Id.star4);
        TextView star5 = FindViewById<TextView>(Resource.Id.star5);

        star1.Visibility = Android.Views.ViewStates.Gone;
        star2.Visibility = Android.Views.ViewStates.Gone;
        star3.Visibility = Android.Views.ViewStates.Gone;
        star4.Visibility = Android.Views.ViewStates.Gone;
        star5.Visibility = Android.Views.ViewStates.Gone;

        ImageView back = FindViewById<ImageView>(Resource.Id.back);

        back.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(Tour));
            intent.PutExtra("username", userName);
            intent.PutExtra("price", price);
            intent.PutExtra("des", destination);
            StartActivity(intent);
        };

        Spinner mySpinner = FindViewById<Spinner>(Resource.Id.travelers);
        var items3 = new List<string> { "1", "2", "3", "4", "5" };

        var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items3);
        adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

        mySpinner.Adapter = adapter;

        mySpinner.ItemSelected += (s, e) =>
        {
            string selected = items3[e.Position];
            string selectedValue = mySpinner.GetItemAtPosition(e.Position).ToString();
            if (selectedValue == "2")
            {
                TextView text2 = FindViewById<TextView>(Resource.Id.text2);
                EditText name2 = FindViewById<EditText>(Resource.Id.nameinput2);
                EditText surname2 = FindViewById<EditText>(Resource.Id.surnameinput2);
                TextView text3 = FindViewById<TextView>(Resource.Id.text3);
                EditText name3 = FindViewById<EditText>(Resource.Id.nameinput3);
                EditText surname3 = FindViewById<EditText>(Resource.Id.surnameinput3);
                TextView text4 = FindViewById<TextView>(Resource.Id.text4);
                EditText name4 = FindViewById<EditText>(Resource.Id.nameinput4);
                EditText surname4 = FindViewById<EditText>(Resource.Id.surnameinput4);
                TextView text5 = FindViewById<TextView>(Resource.Id.text5);
                EditText name5 = FindViewById<EditText>(Resource.Id.nameinput5);
                EditText surname5 = FindViewById<EditText>(Resource.Id.surnameinput5);
                text2.Visibility = Android.Views.ViewStates.Visible;
                name2.Visibility = Android.Views.ViewStates.Visible;
                surname2.Visibility = Android.Views.ViewStates.Visible;
                text3.Visibility = Android.Views.ViewStates.Gone;
                name3.Visibility = Android.Views.ViewStates.Gone;
                surname3.Visibility = Android.Views.ViewStates.Gone;
                text4.Visibility = Android.Views.ViewStates.Gone;
                name4.Visibility = Android.Views.ViewStates.Gone;
                surname4.Visibility = Android.Views.ViewStates.Gone;
                text5.Visibility = Android.Views.ViewStates.Gone;
                name5.Visibility = Android.Views.ViewStates.Gone;
                surname5.Visibility = Android.Views.ViewStates.Gone;
                valuefinal = 2;
                star3.Visibility = Android.Views.ViewStates.Gone;
                star4.Visibility = Android.Views.ViewStates.Gone;
                star5.Visibility = Android.Views.ViewStates.Gone;
            }
            if(selectedValue == "3")
            {
                TextView text2 = FindViewById<TextView>(Resource.Id.text2);
                EditText name2 = FindViewById<EditText>(Resource.Id.nameinput2);
                EditText surname2 = FindViewById<EditText>(Resource.Id.surnameinput2);
                TextView text3 = FindViewById<TextView>(Resource.Id.text3);
                EditText name3 = FindViewById<EditText>(Resource.Id.nameinput3);
                EditText surname3 = FindViewById<EditText>(Resource.Id.surnameinput3);
                TextView text4 = FindViewById<TextView>(Resource.Id.text4);
                EditText name4 = FindViewById<EditText>(Resource.Id.nameinput4);
                EditText surname4 = FindViewById<EditText>(Resource.Id.surnameinput4);
                TextView text5 = FindViewById<TextView>(Resource.Id.text5);
                EditText name5 = FindViewById<EditText>(Resource.Id.nameinput5);
                EditText surname5 = FindViewById<EditText>(Resource.Id.surnameinput5);
                text2.Visibility = Android.Views.ViewStates.Visible;
                name2.Visibility = Android.Views.ViewStates.Visible;
                surname2.Visibility = Android.Views.ViewStates.Visible;
                text3.Visibility = Android.Views.ViewStates.Visible;
                name3.Visibility = Android.Views.ViewStates.Visible;
                surname3.Visibility = Android.Views.ViewStates.Visible;
                text4.Visibility = Android.Views.ViewStates.Gone;
                name4.Visibility = Android.Views.ViewStates.Gone;
                surname4.Visibility = Android.Views.ViewStates.Gone;
                text5.Visibility = Android.Views.ViewStates.Gone;
                name5.Visibility = Android.Views.ViewStates.Gone;
                surname5.Visibility = Android.Views.ViewStates.Gone;
                valuefinal = 3;
                star4.Visibility = Android.Views.ViewStates.Gone;
                star5.Visibility = Android.Views.ViewStates.Gone;
            }
            if(selectedValue == "4")
            {
                TextView text2 = FindViewById<TextView>(Resource.Id.text2);
                EditText name2 = FindViewById<EditText>(Resource.Id.nameinput2);
                EditText surname2 = FindViewById<EditText>(Resource.Id.surnameinput2);
                TextView text3 = FindViewById<TextView>(Resource.Id.text3);
                EditText name3 = FindViewById<EditText>(Resource.Id.nameinput3);
                EditText surname3 = FindViewById<EditText>(Resource.Id.surnameinput3);
                TextView text4 = FindViewById<TextView>(Resource.Id.text4);
                EditText name4 = FindViewById<EditText>(Resource.Id.nameinput4);
                EditText surname4 = FindViewById<EditText>(Resource.Id.surnameinput4);
                TextView text5 = FindViewById<TextView>(Resource.Id.text5);
                EditText name5 = FindViewById<EditText>(Resource.Id.nameinput5);
                EditText surname5 = FindViewById<EditText>(Resource.Id.surnameinput5);
                text2.Visibility = Android.Views.ViewStates.Visible;
                name2.Visibility = Android.Views.ViewStates.Visible;
                surname2.Visibility = Android.Views.ViewStates.Visible;
                text3.Visibility = Android.Views.ViewStates.Visible;
                name3.Visibility = Android.Views.ViewStates.Visible;
                surname3.Visibility = Android.Views.ViewStates.Visible;
                text4.Visibility = Android.Views.ViewStates.Visible;
                name4.Visibility = Android.Views.ViewStates.Visible;
                surname4.Visibility = Android.Views.ViewStates.Visible;
                text5.Visibility = Android.Views.ViewStates.Gone;
                name5.Visibility = Android.Views.ViewStates.Gone;
                surname5.Visibility = Android.Views.ViewStates.Gone;
                valuefinal = 4;
                star5.Visibility = Android.Views.ViewStates.Gone;
            }
            if (selectedValue == "5")
            {
                TextView text2 = FindViewById<TextView>(Resource.Id.text2);
                EditText name2 = FindViewById<EditText>(Resource.Id.nameinput2);
                EditText surname2 = FindViewById<EditText>(Resource.Id.surnameinput2);
                TextView text3 = FindViewById<TextView>(Resource.Id.text3);
                EditText name3 = FindViewById<EditText>(Resource.Id.nameinput3);
                EditText surname3 = FindViewById<EditText>(Resource.Id.surnameinput3);
                TextView text4 = FindViewById<TextView>(Resource.Id.text4);
                EditText name4 = FindViewById<EditText>(Resource.Id.nameinput4);
                EditText surname4 = FindViewById<EditText>(Resource.Id.surnameinput4);
                TextView text5 = FindViewById<TextView>(Resource.Id.text5);
                EditText name5 = FindViewById<EditText>(Resource.Id.nameinput5);
                EditText surname5 = FindViewById<EditText>(Resource.Id.surnameinput5);
                text2.Visibility = Android.Views.ViewStates.Visible;
                name2.Visibility = Android.Views.ViewStates.Visible;
                surname2.Visibility = Android.Views.ViewStates.Visible;
                text3.Visibility = Android.Views.ViewStates.Visible;
                name3.Visibility = Android.Views.ViewStates.Visible;
                surname3.Visibility = Android.Views.ViewStates.Visible;
                text4.Visibility = Android.Views.ViewStates.Visible;
                name4.Visibility = Android.Views.ViewStates.Visible;
                surname4.Visibility = Android.Views.ViewStates.Visible;
                text5.Visibility = Android.Views.ViewStates.Visible;
                name5.Visibility = Android.Views.ViewStates.Visible;
                surname5.Visibility = Android.Views.ViewStates.Visible;
                valuefinal = 5;
            }
            if (selectedValue == "1")
            {
                TextView text2 = FindViewById<TextView>(Resource.Id.text2);
                EditText name2 = FindViewById<EditText>(Resource.Id.nameinput2);
                EditText surname2 = FindViewById<EditText>(Resource.Id.surnameinput2);
                TextView text3 = FindViewById<TextView>(Resource.Id.text3);
                EditText name3 = FindViewById<EditText>(Resource.Id.nameinput3);
                EditText surname3 = FindViewById<EditText>(Resource.Id.surnameinput3);
                TextView text4 = FindViewById<TextView>(Resource.Id.text4);
                EditText name4 = FindViewById<EditText>(Resource.Id.nameinput4);
                EditText surname4 = FindViewById<EditText>(Resource.Id.surnameinput4);
                TextView text5 = FindViewById<TextView>(Resource.Id.text5);
                EditText name5 = FindViewById<EditText>(Resource.Id.nameinput5);
                EditText surname5 = FindViewById<EditText>(Resource.Id.surnameinput5);
                text2.Visibility = Android.Views.ViewStates.Gone;
                name2.Visibility = Android.Views.ViewStates.Gone;
                surname2.Visibility = Android.Views.ViewStates.Gone;
                text3.Visibility = Android.Views.ViewStates.Gone;
                name3.Visibility = Android.Views.ViewStates.Gone;
                surname3.Visibility = Android.Views.ViewStates.Gone;
                text4.Visibility = Android.Views.ViewStates.Gone;
                name4.Visibility = Android.Views.ViewStates.Gone;
                surname4.Visibility = Android.Views.ViewStates.Gone;
                text5.Visibility = Android.Views.ViewStates.Gone;
                name5.Visibility = Android.Views.ViewStates.Gone;
                surname5.Visibility = Android.Views.ViewStates.Gone;
                valuefinal = 1;
                star2.Visibility = Android.Views.ViewStates.Gone;
                star3.Visibility = Android.Views.ViewStates.Gone;
                star4.Visibility = Android.Views.ViewStates.Gone;
                star5.Visibility = Android.Views.ViewStates.Gone;
            }
        };

        EditText name = FindViewById<EditText>(Resource.Id.nameinput);
        EditText surname = FindViewById<EditText>(Resource.Id.surnameinput);
        EditText name2 = FindViewById<EditText>(Resource.Id.nameinput2);
        EditText surname2 = FindViewById<EditText>(Resource.Id.surnameinput2);
        EditText name3 = FindViewById<EditText>(Resource.Id.nameinput3);
        EditText surname3 = FindViewById<EditText>(Resource.Id.surnameinput3);
        EditText name4 = FindViewById<EditText>(Resource.Id.nameinput4);
        EditText surname4 = FindViewById<EditText>(Resource.Id.surnameinput4);
        EditText name5 = FindViewById<EditText>(Resource.Id.nameinput5);
        EditText surname5 = FindViewById<EditText>(Resource.Id.surnameinput5);

        Button next = FindViewById<Button>(Resource.Id.next_page);
        next.Click += (sender, e) =>
        {
            if (valuefinal == 1&& string.IsNullOrWhiteSpace(name.Text)|string.IsNullOrWhiteSpace(surname.Text))
            {
                star1.Visibility = Android.Views.ViewStates.Visible;
            }
            else if (valuefinal == 2 && string.IsNullOrWhiteSpace(name.Text)|string.IsNullOrWhiteSpace(surname.Text)|string.IsNullOrWhiteSpace(name2.Text)|string.IsNullOrWhiteSpace(surname2.Text))
            {
                if (string.IsNullOrWhiteSpace(name.Text)||string.IsNullOrWhiteSpace(surname.Text))
                {
                    star1.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star1.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name2.Text) || string.IsNullOrWhiteSpace(surname2.Text))
                {
                    star2.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star2.Visibility = Android.Views.ViewStates.Gone;
                }
            }
            else if (valuefinal == 3 && string.IsNullOrWhiteSpace(name.Text) | string.IsNullOrWhiteSpace(surname.Text) | string.IsNullOrWhiteSpace(name2.Text) | string.IsNullOrWhiteSpace(surname2.Text) | string.IsNullOrWhiteSpace(name3.Text) | string.IsNullOrWhiteSpace(surname3.Text))
            {
                if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(surname.Text))
                {
                    star1.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star1.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name2.Text) || string.IsNullOrWhiteSpace(surname2.Text))
                {
                    star2.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star2.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name3.Text) || string.IsNullOrWhiteSpace(surname3.Text))
                {
                    star3.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star3.Visibility = Android.Views.ViewStates.Gone;
                }
            }
            else if (valuefinal == 4 && string.IsNullOrWhiteSpace(name.Text) | string.IsNullOrWhiteSpace(surname.Text) | string.IsNullOrWhiteSpace(name2.Text) | string.IsNullOrWhiteSpace(surname2.Text) | string.IsNullOrWhiteSpace(name3.Text) | string.IsNullOrWhiteSpace(surname3.Text) | string.IsNullOrWhiteSpace(name4.Text) | string.IsNullOrWhiteSpace(surname4.Text))
            {
                if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(surname.Text))
                {
                    star1.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star1.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name2.Text) || string.IsNullOrWhiteSpace(surname2.Text))
                {
                    star2.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star2.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name3.Text) || string.IsNullOrWhiteSpace(surname3.Text))
                {
                    star3.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star3.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name4.Text) || string.IsNullOrWhiteSpace(surname4.Text))
                {
                    star4.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star4.Visibility = Android.Views.ViewStates.Gone;
                }
            }
            else if (valuefinal == 5 && string.IsNullOrWhiteSpace(name.Text) | string.IsNullOrWhiteSpace(surname.Text) | string.IsNullOrWhiteSpace(name2.Text) | string.IsNullOrWhiteSpace(surname2.Text) | string.IsNullOrWhiteSpace(name3.Text) | string.IsNullOrWhiteSpace(surname3.Text) | string.IsNullOrWhiteSpace(name4.Text) | string.IsNullOrWhiteSpace(surname4.Text) | string.IsNullOrWhiteSpace(name5.Text) | string.IsNullOrWhiteSpace(surname5.Text))
            {
                if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(surname.Text))
                {
                    star1.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star1.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name2.Text) || string.IsNullOrWhiteSpace(surname2.Text))
                {
                    star2.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star2.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name3.Text) || string.IsNullOrWhiteSpace(surname3.Text))
                {
                    star3.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star3.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name4.Text) || string.IsNullOrWhiteSpace(surname4.Text))
                {
                    star4.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star4.Visibility = Android.Views.ViewStates.Gone;
                }
                if (string.IsNullOrWhiteSpace(name5.Text) || string.IsNullOrWhiteSpace(surname5.Text))
                {
                    star5.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    star5.Visibility = Android.Views.ViewStates.Gone;
                }
            }
            else
            {
                Intent intent = new Intent(this, typeof(Pay));
                intent.PutExtra("username", userName);
                intent.PutExtra("price", price);
                intent.PutExtra("des", destination);
                intent.PutExtra("people", valuefinal);
                StartActivity(intent);
            }

        };
    }
    int valuefinal;
}
