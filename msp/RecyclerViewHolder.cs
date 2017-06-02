using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace msp
{
    internal class RecyclerViewHolder : RecyclerView.ViewHolder
    {
        public TextView txtName { get; private set; }
        public TextView txtNumber { get; private set; }

        public RecyclerViewHolder(View itemView) : base(itemView)
        {
            txtName = itemView.FindViewById<TextView>(Resource.Id.txt_name);
            txtNumber = itemView.FindViewById<TextView>(Resource.Id.txt_number);
        }
    }
}