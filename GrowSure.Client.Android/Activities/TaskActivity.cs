using System;

using Android.Animation;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Transitions;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using GrowSure.Cleint.Android;
using GrowSure.Cleint.Android.Adapters.GrowSure.Client.Android.Adapters;
using GrowSure.Cleint.Android.Fragments;
using GrowSure.Cleint.Android.Helpers;
using GrowSure.Client.Android.Adapters;
using GrowSure.Client.Android.Helpers;
using GrowSure.Client.Android.Models;
using GrowSure.Client.Android.Persistence;
using GrowSure.Client.Android.Widgets.Fab;
using GrowSure.Client.Common.Models;

namespace GrowSure.Client.Android.Activities
{
    [Activity(WindowSoftInputMode = SoftInput.AdjustPan)]
    public class TaskActivity : Activity
    {
        const string Tag = "TaskActivity";
        const string ImageCategory = "image_category_";
        const string StateIsPlaying = "isPlaying";
        const int Undefined = -1;
        const string FragmentTag = "Catagory";

        TaskFragment categoryFragment;
        Toolbar toolbar;
        ImageView categoryFab;
        IInterpolator interpolator;
        ImageView icon;
        Animator circularReveal;

        string categoryId;
        bool savedStateIsPlaying;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            var sharedElementEnterTransition = TransitionInflater.From(this).InflateTransition(Resource.Transition.category_enter);
            Window.SharedElementEnterTransition = sharedElementEnterTransition;

            categoryId = Intent.GetStringExtra(Category.TAG);
            interpolator = AnimationUtils.LoadInterpolator(this, global::Android.Resource.Interpolator.FastOutSlowIn);
            if (savedInstanceState != null)
                savedStateIsPlaying = savedInstanceState.GetBoolean(StateIsPlaying);
            Populate(categoryId);
            base.OnCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            if (savedStateIsPlaying)
            {
                categoryFragment = (TaskFragment)FragmentManager.FindFragmentByTag(FragmentTag);
                FindViewById(Resource.Id.category_fragment_container).Visibility = ViewStates.Visible;
            }
            base.OnResume();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutBoolean(StateIsPlaying, categoryFab.Visibility == ViewStates.Gone);
            base.OnSaveInstanceState(outState);
        }

        public override void OnBackPressed()
        {
            if (categoryFab == null)
            {
                base.OnBackPressed();
                return;
            }
            else if(FindViewById(Resource.Id.task_view) != null)
            {
                
                Intent.AddFlags(ActivityFlags.ClearTop);
                StartActivity(Intent);

            }

           
            var listener = new AnimatorListener(this);
            listener.AnimationEnd += (sender, e) => {
                if (IsFinishing || IsDestroyed)
                    return;
                base.OnBackPressed();
            };

            categoryFab.Animate()
                .ScaleX(0f)
                .ScaleY(0f)
                .SetInterpolator(interpolator)
                .SetStartDelay(100)
                .SetListener(listener)
                .Start();
        }

        void StartCategoryFromClickOn(View view)
        {
            InitCategoryFragment();
            FragmentManager.BeginTransaction().Replace(Resource.Id.category_fragment_container, categoryFragment, FragmentTag).Commit();
            View fragmentContainer = FindViewById(Resource.Id.category_fragment_container);
            int centerX = (view.Left + view.Right) / 2;
            int centerY = (view.Top + view.Bottom) / 2;
            int finalRadius = Math.Max(fragmentContainer.Width, fragmentContainer.Height);
            circularReveal = ViewAnimationUtils.CreateCircularReveal(
                fragmentContainer, centerX, centerY, 0, finalRadius);
            fragmentContainer.Visibility = ViewStates.Visible;
            view.Visibility = ViewStates.Gone;

            EventHandler handler = null;
            handler += (sender, e) => {
                //icon.Visibility = ViewStates.Gone;
                circularReveal.AnimationEnd -= handler;
            };
            circularReveal.AnimationEnd += handler;

            circularReveal.Start();

            toolbar.Elevation = 0;
        }

        public void ElevateToolbar()
        {
            toolbar.Elevation = Resources.GetDimension(Resource.Dimension.elevation_header);
        }

        void InitCategoryFragment()
        {
            categoryFragment = TaskFragment.Create(categoryId);
            toolbar.Elevation = 0;
        }

        public void Proceed()
        {
            SubmitAnswer();
        }

        void SubmitAnswer()
        {
            ElevateToolbar();
            if (!categoryFragment.ShowNextPage())
            {
                //categoryFragment.ShowSummary();
                return;
            }
            toolbar.Elevation = 0;
        }

        void Populate(string categoryId)
        {
            if (string.IsNullOrEmpty(categoryId))
            {
                Log.Warn(Tag, "Didn't find a category. Finishing");
                Finish();
            }
            var category = GrowSureDatabaseHelper.GetCategoryWith(this, categoryId);
            SetTheme(category.Theme.StyleId);
            InitLayout(category.Id);
            InitToolbar(category);
        }

        void InitLayout(string categoryId)
        {
            SetContentView(Resource.Layout.activity_tasks);
           
            categoryFab = FindViewById<FloatingActionButton>(Resource.Id.fab_category);
            categoryFab.SetImageResource(Resource.Drawable.ic_play);
            categoryFab.Visibility = savedStateIsPlaying ? ViewStates.Gone : ViewStates.Visible;
            categoryFab.Click += (sender, e) => {
                var view = (View)sender;
                StartCategoryFromClickOn(view);
                toolbar = FindViewById<Toolbar>(Resource.Id.toolbar_activity_category);
            };
            categoryFab.Animate()
                .ScaleX(1)
                .ScaleY(1)
                .SetInterpolator(interpolator)
                .SetStartDelay(400)
                .Start();
            PopulateTaskList();
        }

        private void PopulateTaskList()
        {
            var tasks = GrowSureDatabaseHelper.LoadActiveTasks(this, true);
            ListView view = new ListView(this);
            var listView = FindViewById<ListView>(Resource.Id.lv_task_list);
            listView.Adapter = new TaskListAdapter(this, tasks);
        }

        void InitToolbar(Category category)
        {
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar_activity_category);
            toolbar.Title = category.Name;
            toolbar.NavigationOnClick += (sender, e) => {
                var view = (View)sender;
                OnBackPressed();

            };

            if (savedStateIsPlaying)
                toolbar.Elevation = 0;
        }
    }

}


