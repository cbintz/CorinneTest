// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CorinneTest.iOS
{
    [Register ("PersonTableViewCell")]
    partial class PersonTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Age { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Birthdate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DaysAlive { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Index { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MonthsAlive { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Name { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ZodiacSign { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Age != null) {
                Age.Dispose ();
                Age = null;
            }

            if (Birthdate != null) {
                Birthdate.Dispose ();
                Birthdate = null;
            }

            if (DaysAlive != null) {
                DaysAlive.Dispose ();
                DaysAlive = null;
            }

            if (Index != null) {
                Index.Dispose ();
                Index = null;
            }

            if (MonthsAlive != null) {
                MonthsAlive.Dispose ();
                MonthsAlive = null;
            }

            if (Name != null) {
                Name.Dispose ();
                Name = null;
            }

            if (ZodiacSign != null) {
                ZodiacSign.Dispose ();
                ZodiacSign = null;
            }
        }
    }
}