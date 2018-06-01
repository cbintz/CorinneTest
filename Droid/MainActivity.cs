using Android.App;
using Android.Widget;
using Android.OS;

namespace CorinneTest.Droid
{
    [Activity(Label = "CorinneTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        #region Variables
        TextView PersonName;
        Button ChangePersonButton;

        int Index = 0;
        #endregion

        #region Life Cycle
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            this.PersonName = FindViewById<TextView>(Resource.Id.name);

            this.ChangePersonButton = FindViewById<Button>(Resource.Id.change_button);
            this.ChangePersonButton.Click += ChangePersonButton_Click;

            loadPerson(this.Index);
        }
        #endregion

        #region Callback
        void ChangePersonButton_Click(object sender, System.EventArgs e)
        {
            loadPerson(this.Index + 1);
        }

        void loadPerson(int index) {
            // do stuff.
            this.PersonName.Text = "something?";
        }
        #endregion
    }
}

