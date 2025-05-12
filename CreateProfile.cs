using Android.Content;
using Android.Views;
using Android.Widget;
using TravelMore;
using Java.Lang;
using static TravelMore.MainActivity;

namespace TravelMore;

[Activity(Label = "@string/app_name")]
public class CreateProfile : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.create_account);


        ImageView back = FindViewById<ImageView>(Resource.Id.backButton);
        back.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        };


            Button new_account = FindViewById<Button>(Resource.Id.new_account);
        new_account.Click += (sender, e) =>
        {
            EditText password = FindViewById<EditText>(Resource.Id.password);
            EditText username = FindViewById<EditText>(Resource.Id.username);
            EditText r_password = FindViewById<EditText>(Resource.Id.r_password);
            if (string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(username.Text)|| string.IsNullOrWhiteSpace(r_password.Text) ||  r_password.Text != password.Text)
            {
                if (string.IsNullOrWhiteSpace(password.Text))
                {
                    TextView password_star = FindViewById<TextView>(Resource.Id.password_star);
                    password_star.Visibility = ViewStates.Visible;
                }
                else
                {
                    TextView password_star = FindViewById<TextView>(Resource.Id.password_star);
                    password_star.Visibility = ViewStates.Invisible;
                }
                if (string.IsNullOrWhiteSpace(username.Text))
                {
                    TextView user_star = FindViewById<TextView>(Resource.Id.user_star);
                    user_star.Visibility = ViewStates.Visible;
                }
                else
                {
                    TextView user_star = FindViewById<TextView>(Resource.Id.user_star);
                    user_star.Visibility = ViewStates.Invisible;
                }
                if (string.IsNullOrWhiteSpace(r_password.Text))
                {
                    TextView r_password_star = FindViewById<TextView>(Resource.Id.r_password_star);
                    r_password_star.Visibility = ViewStates.Visible;
                }
                else
                {
                    TextView r_password_star = FindViewById<TextView>(Resource.Id.r_password_star);
                    r_password_star.Visibility = ViewStates.Invisible;
                }
                if(r_password.Text != password.Text & string.IsNullOrWhiteSpace(r_password.Text)|| string.IsNullOrWhiteSpace(password.Text))
                {
                    TextView passwrong = FindViewById<TextView>(Resource.Id.passwrong);
                   passwrong.Visibility = ViewStates.Invisible;
                }
                else if (r_password.Text != password.Text)
                {
                    TextView passwrong = FindViewById<TextView>(Resource.Id.passwrong);
                    passwrong.Visibility = ViewStates.Visible;
                }
                else
                {
                    TextView passwrong = FindViewById<TextView>(Resource.Id.passwrong);
                    passwrong.Visibility = ViewStates.Invisible;
                }
            }
            else
            {
                EditText name = FindViewById<EditText>(Resource.Id.username);
                EditText password1 = FindViewById<EditText>(Resource.Id.password);
                string nameId = name.Text;
                Intent intent = new Intent(this, typeof(account_created));
                intent.PutExtra("username", nameId);
                StartActivity(intent);
                User list = new User();
                UserManager.user1.Add(new User { login = name.Text, password = password1.Text});
            }
        };
    }
}
