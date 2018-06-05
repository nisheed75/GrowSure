using GrowSure.Client.Common.Models;
using GrowSure.Client.Common.Properties;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrowSure.Client.Common.DataServices
{
    public class GrowSureDataService
    {
        public List<UICategory> GetUiCategories()
        {
            return ReadCategoriesFromfile();
        }

        private List<UICategory> ReadCategoriesFromfile()
        {
            //TODO: remove mock
            List<UICategory> categories = JsonConvert.DeserializeObject<List<UICategory>>(Resources.Categories);
            return categories;
        }

        public List<Task> GetActiveTasks(string data)
        {
            return JsonConvert.DeserializeObject<List<Task>>(data);
        }
    }
}
