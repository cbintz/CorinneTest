using Android.App;
using Android.Widget;
using Android.OS;
using CorinneTest;

namespace CorinneTest.Droid
{
    [Activity(Label = "CorinneTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        #region Variables
        TextView PersonName;
        TextView PersonAge;
        TextView PersonBirthDate;
        TextView PersonGender;
        TextView PersonIndex;
        Button ChangePersonButton;

        int Index = 0;
        #endregion

        #region Life Cycle
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);


            PersonDataSource.Instance.SetList(11, 85, 10);
            this.PersonName = FindViewById<TextView>(Resource.Id.name);
            this.PersonAge = FindViewById<TextView>(Resource.Id.age);
            this.PersonGender = FindViewById<TextView>(Resource.Id.gender);
            this.PersonBirthDate = FindViewById<TextView>(Resource.Id.birthdate);
            this.PersonIndex = FindViewById<TextView>(Resource.Id.index);
            this.ChangePersonButton = FindViewById<Button>(Resource.Id.change_button);
            this.ChangePersonButton.Click += ChangePersonButton_Click;
            loadPerson(this.Index);



        }
        #endregion

        #region Callback
        void ChangePersonButton_Click(object sender, System.EventArgs e)
        {
            if (this.Index < PersonDataSource.Instance.People.Count) { loadPerson(this.Index + 1); }
            else { loadPerson(this.Index); }
            
        }

        void loadPerson(int index) {
            this.Index = index;
            // do stuff.
            var person = PersonDataSource.Instance.GetPerson(index);
            // keep track of index in singleton list
            this.PersonName.Text = person.Name;
            this.PersonAge.Text = person.Age.ToString();
            this.PersonGender.Text = person.Gender.ToString();
            this.PersonBirthDate.Text = person.BirthDate.ToString();
            this.PersonIndex.Text = "Index: " + this.Index.ToString();
        }
        #endregion
    }
}

