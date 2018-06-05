using System;
using System.Collections.Generic;
using System.Linq;

using Android.Content;
using GrowSure.Client.Android.Models;
using GrowSure.Client.Common.Models;
using GrowSure.Client.Common.DataServices;
using Android.App;
using GrowSure.Cleint.Android;
using System.Text;
using System.IO;

namespace GrowSure.Client.Android.Persistence
{
    public class GrowSureDatabaseHelper
	{
		const string Tag = "GrowSureDatabaseHelper";
		const string DbName = "growSure";
		const string DbSuffix = ".db";
		const int DbVersion = 1;

		static List<Category> categories;
        static List<Task> tasks;
        static GrowSureDatabaseHelper instance;

        


        static GrowSureDatabaseHelper GetInstance (Context context)
		{
			return instance = instance ?? new GrowSureDatabaseHelper (context);
		}

		GrowSureDatabaseHelper (Context context)
		{
            
		}

		public static List<Category> GetCategories (Context context, bool fromDatabase)
		{
			if (categories == null || fromDatabase)
				categories = LoadCategories (context).ToList ();
			return categories;
		}

        public static List<Task> LoadActiveTasks(Context context, bool fromDatabase)
        {
            if (tasks == null || fromDatabase)
                tasks = GetTasks(context).ToList();
            return tasks;
        }

        static IEnumerable<Category> LoadCategories (Context context)
		{

            GrowSureDataService readableDatabase = new GrowSureDataService();
            var query = readableDatabase.GetUiCategories();
			foreach (var category in query) {
                yield return new Category(
                    category.Name,
                    category.Id,
                    Theme.FromString(category.Theme)
                );
			}
		}

        static IEnumerable<Task> GetTasks(Context context)
        {

            GrowSureDataService readableDatabase = new GrowSureDataService();

            var dataStream = context.Resources.OpenRawResource(Resource.Raw.tasks);
            string data = "";
            using (var reader = new StreamReader(dataStream))
            {
                data = reader.ReadToEnd();
            }
            var query = readableDatabase.GetActiveTasks(data.ToString());
            foreach (var task in query)
            {
                yield return new Task(
                    task.Type,
                    task.TaskName,
                    task.Assignee,
                    task.DueOn,
                    task.Tags,
                    task.Location,
                    task.QuantityUnit,
                    task.Quantity
                );
            }
        }

        static bool GetBooleanFromDatabase (string isSolved)
		{
			return !string.IsNullOrEmpty (isSolved) && Convert.ToBoolean (isSolved);
		}

		static int[] GetScoresFromString (string scores)
		{
			return scores.Trim (new[] { '[', ']', '{', '}' }).Split (',').Select (x => int.Parse (x)).ToArray ();
		}

        internal static Category GetCategoryWith(Activity activity, string categoryId)
        {
            GrowSureDataService readableDatabase = new GrowSureDataService();
            List<UICategory> categories = readableDatabase.GetUiCategories();
            var cat = categories.Single<UICategory>(q => q.Id == categoryId);

            return new Category(cat.Name, cat.Id, Theme.FromString(cat.Theme));

        }

        /*public static Category GetCategoryWith (Context context, string categoryId)
		{
			
			//var category = readableDatabase.Get<CategoryTable> (categoryId);
            //return new Category(
              //  category.Name,
                //category.Id,
                //Theme.FromString(category.Theme));
		}*/
    }
}