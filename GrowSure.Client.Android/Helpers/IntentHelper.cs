using Android.Content;
using GrowSure.Client.Android.Activities;
using GrowSure.Client.Android.Models;

namespace GrowSure.Cleint.Android.Helpers
{
    class IntentHelper
    {
        public static Intent GetStartIntent(Context context, Category category)
        {
            Intent starter = null;
            switch (category.Name)
            {
                case "Tasks":
                    starter = new Intent(context, typeof(TaskActivity));
                    break;
            }

            starter.PutExtra(Category.TAG, category.Id);
            return starter;
        }
    }
}