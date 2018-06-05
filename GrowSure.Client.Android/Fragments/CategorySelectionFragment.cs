using Android.App;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
using GrowSure.Cleint.Android;
using GrowSure.Cleint.Android.Helpers;
using GrowSure.Client.Android.Activities;
using GrowSure.Client.Android.Adapters;
using GrowSure.Client.Android.Helpers;
using GrowSure.Client.Android.Models;

namespace GrowSure.Client.Android.Fragments
{
    public class CategorySelectionFragment : Fragment
	{
		CategoryAdapter categoryAdapter;

		public static CategorySelectionFragment Create ()
		{
			return new CategorySelectionFragment ();
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			return inflater.Inflate (Resource.Layout.fragment_categories, container, false);
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			SetUpQuizGrid (view.FindViewById<GridView> (Resource.Id.categories));
			base.OnViewCreated (view, savedInstanceState);
		}

		void SetUpQuizGrid (GridView categoriesView)
		{
			categoriesView.ItemClick += (sender, e) => { 
				var activity = Activity;
				StartCategoryActivityWithTransition (activity, e.View.FindViewById (Resource.Id.category_title), (Category)categoryAdapter.GetItem (e.Position));
			};
			categoryAdapter = new CategoryAdapter (Activity);
			categoriesView.Adapter = categoryAdapter;
		}

		public override void OnResume ()
		{
			categoryAdapter.NotifyDataSetChanged ();
			base.OnResume ();
		}

        void StartCategoryActivityWithTransition(Activity activity, View toolbar, Category category)
        {
            var pairs = TransitionHelper.CreateSafeTransitionParticipants(activity, false, new Pair(toolbar, activity.GetString(Resource.String.transition_toolbar)));
            var sceneTransitionAnimation = ActivityOptions.MakeSceneTransitionAnimation(activity, pairs);

            // Start the activity with the participants, animating from one to the other.
            var transitionBundle = sceneTransitionAnimation.ToBundle();
            activity.StartActivity(IntentHelper.GetStartIntent(activity, category), transitionBundle);
        }
    }
}

