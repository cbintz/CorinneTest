using CorinneTest;
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;

namespace CorinneTest.Droid
{
    
    [Activity(Label = "CorinneTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        #region Variables
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        PersonListAdapter mAdapter;
        static Random rnd = new Random();
        Button ChangePersonButton;
        Button NewListButton;

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
            PersonDataSource.Instance.SetList(GenLowAge(), GenHighAge(), GenNumPeople());

            this.ChangePersonButton = FindViewById<Button>(Resource.Id.change_button);
            this.ChangePersonButton.Click += ChangePersonButton_Click;

            this.NewListButton = FindViewById<Button>(Resource.Id.newlist_button);
            this.NewListButton.Click += NewListButton_Click;

            // Get RecyclerView layout:
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            // Plug in the linear layout manager:
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            loadRecycler();
        }

        void loadRecycler() {
            // Plug in my adapter:
            mAdapter = new PersonListAdapter();
            mRecyclerView.SetAdapter(mAdapter);
        }
        #endregion

        #region Callback
        void ChangePersonButton_Click(object sender, System.EventArgs e)
        {
            // nothing here, let's change this to do something else down the line (or not sinc we ahve to move to iOS)
        }

        void NewListButton_Click(object sender, System.EventArgs e)
        {
            PersonDataSource.Instance.SetList(GenLowAge(), GenHighAge(), GenNumPeople());
            loadRecycler();
        }

        #endregion
    }
}

