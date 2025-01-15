using UnitTestCSharp;

namespace MSTest

{
    [TestClass]
    public class UnitTest1
    {
        public const string str = "Hello";
        public int integrity = 200;
        public List<int> list = new List<int>();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(str, HelloWorld.StringTest());  //相等=pass
            Assert.AreNotEqual(integrity, HelloWorld.IntTest()); //不相等=pass
            Assert.AreSame(list, list); //同物件=pass
            Assert.AreNotSame(list, HelloWorld.ListTest()); //不同物件=pass

            try
            {
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 1);
            }

            //Assert.Inconclusive(); //一個沒有定論，介於有斷言成功與沒有斷言成功之間，沒啦，他其實是『跳過』
            Assert.IsTrue(1 == 1);
            Assert.IsFalse(1 == 2);
            Assert.IsInstanceOfType(1, typeof(int)); //是否為預期類型的執行個體
            Assert.IsNotInstanceOfType(1, typeof(string)); //是否不是為預期類型的執行個體
            Assert.IsNull(HelloWorld.StringTest2()); //是否為 null
            Assert.IsNotNull(HelloWorld.StringTest()); //是否為非 null

        }
    }
}