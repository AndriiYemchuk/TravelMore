using Android.Content;
using Android.Views;

namespace TravelMore;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);
        string userName = Intent.GetStringExtra("username");

        Button createButton = FindViewById<Button>(Resource.Id.createButton);
        createButton.Click += (sender, e) =>
        {
            Intent intent = new Intent(this, typeof(CreateProfile));
            StartActivity(intent);
        };

        Button loginButton = FindViewById<Button>(Resource.Id.loginButton);
        loginButton.Click += (sender, e) =>
        {
            EditText username = FindViewById<EditText>(Resource.Id.username);
            EditText password = FindViewById<EditText>(Resource.Id.password);
            TextView username_star = FindViewById<TextView>(Resource.Id.user_star);
            TextView password_star = FindViewById<TextView>(Resource.Id.password_star);

            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                if (string.IsNullOrWhiteSpace(username.Text))
                {
                    username_star.Visibility = ViewStates.Visible;
                    username_star.Text = "You must enter your login*";
                }
                else
                {
                    username_star.Visibility = ViewStates.Invisible;
                }
                if (string.IsNullOrWhiteSpace(password.Text))
                {
                    password_star.Visibility = ViewStates.Visible;
                    password_star.Text = "You must enter your password*";
                }
                else
                {
                    password_star.Visibility = ViewStates.Invisible;
                }

            }
            else
            {

            foreach (var user in UserManager.user1)
            {
                int count = UserManager.user1.Count;
                for (int i = 0; i < count; i++)
                {

                    if (username.Text == user.login)
                    {
                        passwordnext = user.password;
                        username_star.Visibility = ViewStates.Invisible;
                    }
                    else
                    {
                        username_star.Visibility = ViewStates.Visible;
                        username_star.Text = "Invalid login*";
                    }

                }
                if (password.Text != passwordnext)
                {
                    password_star.Visibility = ViewStates.Visible;
                    password_star.Text = "Incorrect password*";
                }
                else
                {
                    password_star.Visibility = ViewStates.Invisible;
                    string nameId = username.Text;
                    Intent intent = new Intent(this, typeof(Home));
                    intent.PutExtra("username", nameId);
                    StartActivity(intent);
                }
            };
            }
        };
      }
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
    }
    public static class UserManager
    {
        public static List<User> user1 { get; } = new List<User>();
    }
    public string passwordnext;
}
