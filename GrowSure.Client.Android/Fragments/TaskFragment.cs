using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using GrowSure.Client.Android;
using GrowSure.Client.Android.Helpers;
using GrowSure.Client.Android.Models;
using GrowSure.Client.Android.Persistence;

namespace GrowSure.Cleint.Android.Fragments
{
    public class TaskFragment : Fragment
    {
        const string KeyUserInput = "USER_INPUT";

        Toolbar toolbar;
        Category category;
        AdapterViewAnimator taskView;
       

        public event EventHandler<EventArgs> CategorySolved;


        public static TaskFragment Create(string categoryId)
        {
            if (string.IsNullOrEmpty(categoryId))
                throw new InvalidOperationException("The category can not be null");

            var args = new Bundle();
            args.PutString(Category.TAG, categoryId);
            return new TaskFragment { Arguments = args };
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            var categoryId = Arguments.GetString(Category.TAG);
            category = GrowSureDatabaseHelper.GetCategoryWith(Activity, categoryId);
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var theme = category.Theme;
            var context = new ContextThemeWrapper(Activity, theme.StyleId);
            var themedInflater = LayoutInflater.From(context);
            return themedInflater.Inflate(Resource.Layout.fragment_tasks, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            taskView = view.FindViewById<AdapterViewAnimator>(Resource.Id.task_view);
            taskView.SetInAnimation(Activity, Resource.Animator.slide_in_bottom);
            taskView.SetOutAnimation(Activity, Resource.Animator.slide_out_top);
                        
            base.OnViewCreated(view, savedInstanceState);
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            var focusedChild = taskView.FocusedChild;
            var viewGroup = focusedChild as ViewGroup;
            if (viewGroup != null)
            {
                var currentView = viewGroup.GetChildAt(0);
                
            }
            base.OnSaveInstanceState(outState);
        }

        public override void OnViewStateRestored(Bundle savedInstanceState)
        {
            base.OnViewStateRestored(savedInstanceState);
        }

        public bool ShowNextPage()
        {
            if (taskView == null)
                return false;

            var nextItem = taskView.DisplayedChild + 1;
            var count = taskView.Adapter.Count;
            if (nextItem < count)
            {
                taskView.ShowNext();
                //GrowSureDatabaseHelper.UpdateCategory(Activity, category);
                return true;
            }
            return false;
        }

       
        protected virtual void OnCategorySolved(EventArgs e)
        {
            CategorySolved?.Invoke(this, e);
        }

        void SetAvatarDrawable(AvatarView avatarView)
        {
            var player = PreferencesHelper.GetPlayer(Activity);
            avatarView.SetImageResource((int)player.Avatar);
        }
    }
}