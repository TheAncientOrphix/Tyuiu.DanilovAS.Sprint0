using Tyuiu.DanilovAS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.DanilovAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CkeckGetMessageValid()
        {
            var name = "Aлександр";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Aлександр", res);
        }
    }
}
