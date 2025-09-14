using Tyuiu.UsoltsevGP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.UsoltsevGP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Глеб";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Глеб", res);
        }
    }
}
