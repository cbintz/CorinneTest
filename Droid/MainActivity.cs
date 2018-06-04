using Android.App;
using Android.Widget;
using Android.OS;
using CorinneTest;
using System;

namespace CorinneTest.Droid
{
    
    [Activity(Label = "CorinneTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        static Random rnd = new Random();
        #region Variables
        TextView PersonName;
        TextView PersonAge;
        TextView PersonGender;
        TextView PersonIndex;
        TextView DaysAlive;
        TextView MonthsAlive;
        TextView AgeType;
        TextView ZodiacSign;
        TextView BirthDatePretty;
        //bool isWoman;
        Button ChangePersonButton;
        Button NewListButton;

        int Index = 0;
        #endregion

        #region Life Cycle
        #region Randomize Ages and Size
        int GenLowAge(){
            int lowAge = rnd.Next(1, 17);
            return lowAge;

        }

        int GenHighAge(){
            int highAge = 50 + rnd.Next(1, 50);
            return highAge;
        }

        int GenNumPeople(){
            int numPeople = rnd.Next(1, 100);
            return numPeople;
        }
        #endregion
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            PersonDataSource.Instance.SetList(GenLowAge(), GenHighAge(),  GenNumPeople());
            this.PersonName = FindViewById<TextView>(Resource.Id.name);
            this.PersonAge = FindViewById<TextView>(Resource.Id.age);
            this.PersonGender = FindViewById<TextView>(Resource.Id.gender);
            this.PersonIndex = FindViewById<TextView>(Resource.Id.index);
            this.DaysAlive = FindViewById<TextView>(Resource.Id.daysalive);
            this.MonthsAlive = FindViewById<TextView>(Resource.Id.monthsalive);
            this.AgeType = FindViewById<TextView>(Resource.Id.agetype);
            this.ZodiacSign = FindViewById<TextView>(Resource.Id.zodiac);
            this.BirthDatePretty = FindViewById<TextView>(Resource.Id.birthdatepretty);
            this.ChangePersonButton = FindViewById<Button>(Resource.Id.change_button);
            this.ChangePersonButton.Click += ChangePersonButton_Click;
            this.NewListButton = FindViewById<Button>(Resource.Id.newlist_button);
            this.NewListButton.Click += NewListButton_Click;
            loadPerson(this.Index);



        }
        #endregion

        #region Callback
        void ChangePersonButton_Click(object sender, System.EventArgs e)
        {
            if (this.Index < PersonDataSource.Instance.People.Count) { loadPerson(this.Index + 1); }
            else { loadPerson(this.Index); }
            
        }

        void NewListButton_Click(object sender, System.EventArgs e)
        {
            PersonDataSource.Instance.SetList(GenLowAge(), GenHighAge(), GenNumPeople());
            this.Index = 0;
            loadPerson(this.Index);

        }


        void loadPerson(int index) {
            int birthDateType = rnd.Next(0, 2);
            this.Index = index;
            var person = PersonDataSource.Instance.GetPerson(index);
            //if (person.Gender == Gender.Woman) { isWoman = true; }
            this.PersonName.Text = person.Name;
            this.PersonAge.Text = person.Age.ToString();
            this.PersonGender.Text = person.Gender.ToString();
            this.PersonIndex.Text = "Index: " + this.Index.ToString();
            this.DaysAlive.Text = "Days Alive: " + person.BirthDate.DaysAlive().ToString();
            this.MonthsAlive.Text = "Months Alive: " + person.BirthDate.MonthsAlive().ToString();
            this.AgeType.Text = "Age Type: " + person.BirthDate.AgeType();
            this.ZodiacSign.Text = "Zodiac Sign: " + person.BirthDate.ZodaicSign();
            this.BirthDatePretty.Text = "Birthdate: "  + person.BirthDate.PrintPretty();
            switch (birthDateType)
            {
                case 0: 
                    this.BirthDatePretty.Text = "Birthdate: " + person.BirthDate.PrintPretty();
                    break;
                case 1:
                    this.BirthDatePretty.Text = "Birthdate: " + person.BirthDate.PrintStandardUS();
                    break;
                default:
                    this.BirthDatePretty.Text = "Birthdate: " + person.BirthDate.PrintStandardNotUS();
                    break;

            }
        }
        #endregion
    }
}

