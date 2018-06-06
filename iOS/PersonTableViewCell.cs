using System;

using Foundation;
using UIKit;

namespace CorinneTest.iOS
{
    public partial class PersonTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PersonTableViewCell");
        public static readonly UINib Nib;
      

        // gcf: dont define these.  theyre already defined in the designer.cs and are
        // available if you do this.Name


        static PersonTableViewCell()
        {
            Nib = UINib.FromName("PersonTableViewCell", NSBundle.MainBundle);
        }

        protected PersonTableViewCell(IntPtr handle) : base(handle)
        {
            
        }

        public void Bind(Person person, int index){
            this.Name.Text = person.Name;
            this.Age.Text = person.Age.ToString();
            //this..Text = person.Gender.ToString();
            this.Index.Text = index.ToString();
            this.DaysAlive.Text = "Days Alive: " + person.BirthDate.DaysAlive().ToString();
            this.MonthsAlive.Text = "Months Alive: " + person.BirthDate.MonthsAlive().ToString();
            this.ZodiacSign.Text = "Zodiac Sign: " + person.BirthDate.ZodaicSign();

        }
    }
}
