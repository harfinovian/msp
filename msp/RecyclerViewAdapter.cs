using Android.App;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Android.Views;
using System;
using System.Linq;

namespace msp
{
    class RecyclerViewAdapter: RecyclerView.Adapter
    {
        private Activity activity;
        private List<TransactionData> mData;

        public RecyclerViewAdapter(Activity activity, List<TransactionData> mData)
        {
            this.activity = activity;
            this.mData = mData;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var id = Resource.Layout.item;
            var itemView = LayoutInflater.From(parent.Context).Inflate(id, parent, false);

            return new RecyclerViewHolder(itemView);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = mData.ElementAt(position);
            var holder = viewHolder as RecyclerViewHolder;
            
        }

        public override int ItemCount => mData.Count;
    }
}