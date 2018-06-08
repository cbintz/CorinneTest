using System;
using Android.Support.V7;
using Android.Support.V7.Widget;
using Android.Views;


namespace CorinneTest.Droid
{
    public class PersonListAdapter : RecyclerView.Adapter 
    {

        public PersonListAdapter()
        {

        }


        public override RecyclerView.ViewHolder
            OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.RowPerson, parent, false);
            PersonViewHolder vh = new PersonViewHolder(itemView);
            return vh;
        }

        public override void
            OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            PersonViewHolder vh = holder as PersonViewHolder;
            var person = PersonDataSource.Instance.People[position];
            vh.Bind(person, position);
        }

        public override int ItemCount
        {
            get { return PersonDataSource.Instance.People.Count; }
        }
    }
}