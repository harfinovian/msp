using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;

namespace msp
{
    [Activity(Label = "msp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        RecyclerViewAdapter mAdapter;
        List<TransactionData> mData;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Prepare the data source:
            mData.Add(new TransactionData { Name = "James", Number = "09810982039" });
            mData.Add(new TransactionData { Name = "James", Number = "09810982039" });
            // Instantiate the adapter and pass in its data source:
            mAdapter = new RecyclerViewAdapter(this, mData);

            // Set our view from the "main" layout resource:
            SetContentView(Resource.Layout.Main);

            // Get our RecyclerView layout:
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.lst_item);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter(mAdapter);
        }
    }
}

