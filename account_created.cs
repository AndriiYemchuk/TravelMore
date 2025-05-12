using Android.Content;
using Android.Views;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class account_created : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SetContentView(Resource.Layout.created_account);

        Button next_page = FindViewById<Button>(Resource.Id.next_page);
        next_page.Click += (sender, e) =>
        {
            string userName = Intent.GetStringExtra("username");
            Intent intent = new Intent(this, typeof(Home));
            intent.PutExtra("username", userName);
            StartActivity(intent);
        };
        }
}
