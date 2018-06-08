using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace CorinneTest.Droid
{
    public class PersonViewHolder : RecyclerView.ViewHolder
    {
        public TextView Name { get; private set; }
        public TextView Age { get; private set; }
        public TextView Birthdate { get; private set; }
        public TextView Gender { get; private set; }
        public TextView Index { get; private set; }
        public TextView DaysAlive { get; private set; }
        public TextView MonthsAlive { get; private set; }
        public TextView AgeType { get; private set; }
        public TextView ZodiacSign { get; private set; }


        public PersonViewHolder(View itemView) : base(itemView)
        {
            this.Name = itemView.FindViewById<TextView>(Resource.Id.name);
            this.Age = itemView.FindViewById<TextView>(Resource.Id.age);
            this.Birthdate = itemView.FindViewById<TextView>(Resource.Id.birthdatepretty);
            this.Gender = itemView.FindViewById<TextView>(Resource.Id.gender);
            this.Index = itemView.FindViewById<TextView>(Resource.Id.index);
            this.DaysAlive = itemView.FindViewById<TextView>(Resource.Id.daysalive);
            this.MonthsAlive = itemView.FindViewById<TextView>(Resource.Id.monthsalive);
            this.AgeType = itemView.FindViewById<TextView>(Resource.Id.agetype);
            this.ZodiacSign = itemView.FindViewById<TextView>(Resource.Id.zodiac);
        }

        public void Bind(Person person, int index) {
            this.Name.Text = person.Name;
            this.Age.Text = person.Age.ToString();
            this.Gender.Text = person.Gender.ToString();
            this.Index.Text = "Index: " + index.ToString();
            this.DaysAlive.Text = "Days Alive: " + person.BirthDate.DaysAlive().ToString();
            this.MonthsAlive.Text = "Months Alive: " + person.BirthDate.MonthsAlive().ToString();
            this.AgeType.Text = "Age Type: " + person.BirthDate.AgeType();
            this.ZodiacSign.Text = "Zodiac Sign: " + person.BirthDate.ZodaicSign();
            //this.Birthdate.Text = "Birthdate: " + person.BirthDate.PrintPretty();

            switch (index % 3)
            {
                case 0:
                    this.Birthdate.Text = "Birthdate: " + person.BirthDate.PrintPretty();
                    break;
                case 1:
                    this.Birthdate.Text = "Birthdate: " + person.BirthDate.PrintStandardUS();
                    break;
                default:
                    this.Birthdate.Text = "Birthdate: " + person.BirthDate.PrintStandardNotUS();
                    break;

            }
        }
    }
}
