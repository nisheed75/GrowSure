using System;
using GrowSure.Client.Common.DataServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GrowSure.Client.Common.Test
{
    [TestClass]
    public class DataServicesTests
    {
        [TestMethod]
        public void TestGetUiCategory()
        {
            GrowSureDataService data = new GrowSureDataService();

            var catagories = data.GetUiCategories();
        }

        [TestMethod]
        public void TestGetActiveTasks()
        {
            GrowSureDataService data = new GrowSureDataService();

            //var taaks = data.GetActiveTasks();
        }
    }
}
