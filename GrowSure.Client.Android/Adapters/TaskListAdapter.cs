using System.Collections.Generic;

using Android.App;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Android.Support.V4.Content.Res;
using Android.Views;
using Android.Widget;
using GrowSure.Client.Android;
using GrowSure.Client.Android.Adapters;
using GrowSure.Client.Common.Models;

namespace GrowSure.Cleint.Android.Adapters
{
    namespace GrowSure.Client.Android.Adapters
    {
        public class TaskListAdapter : BaseAdapter<Task>
        {
            List<Task> items;
            Activity context;
            public TaskListAdapter(Activity context, List<Task> items)
                : base()
            {
                this.context = context;
                this.items = items;
            }
            public override long GetItemId(int position)
            {
                return position;
            }
            public override Task this[int position]
            {
                get { return items[position]; }
            }
            public override int Count
            {
                get { return items.Count; }
            }
            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var item = items[position];
                View view = convertView;
                if (view == null) // no view to re-use, create new
                    view = context.LayoutInflater.Inflate(Resource.Layout.task_item, null);
                view.FindViewById<TextView>(Resource.Id.tv_task_description).Text = item.Type.Name + " " +item.TaskName;
                view.FindViewById<TextView>(Resource.Id.tv_location).Text = item.Location;
                view.FindViewById<TextView>(Resource.Id.lbl_no_of_trays).Text = item.QuantityUnit;
                view.FindViewById<TextView>(Resource.Id.tv_no_of_trays).Text = item.Quantity.ToString();
                view.FindViewById<TextView>(Resource.Id.tv_due_date).Text = item.DueOn.ToShortDateString();

               
                if (item.Assignee == null) {
                    
                    
                    (view.FindViewById<AvatarView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(global::Android.Resource.Drawable.IcMenuGallery));
                }
                else if (item.Assignee.Avatar == "avatar_1")
                {
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_1));
                }
                else if (item.Assignee.Avatar == "avatar_2")
                {
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_2));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_3")                                         
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_3));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_4")                                         
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_4));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_5")                                         
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_5));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_6")                                         
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_6));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_7")                                         
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_7));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_8")                                         
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_8));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_9")                                         
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_9));
                }                                                                                    
                else if (item.Assignee.Avatar == "avatar_10")                                        
                {                                                                                    
                    (view.FindViewById<ImageView>(Resource.Id.img_assigned_person)).SetImageDrawable(parent.Context.GetDrawable(Resource.Drawable.avatar_10));
                }


                return view;
            }
        }
    }
}