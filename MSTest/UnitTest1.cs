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
            Assert.AreEqual(str, HelloWorld.StringTest());  //�۵�=pass
            Assert.AreNotEqual(integrity, HelloWorld.IntTest()); //���۵�=pass
            Assert.AreSame(list, list); //�P����=pass
            Assert.AreNotSame(list, HelloWorld.ListTest()); //���P����=pass

            try
            {
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 1);
            }

            //Assert.Inconclusive(); //�@�ӨS���w�סA�����_�����\�P�S���_�����\�����A�S�աA�L���O�y���L�z
            Assert.IsTrue(1 == 1);
            Assert.IsFalse(1 == 2);
            Assert.IsInstanceOfType(1, typeof(int)); //�O�_���w���������������
            Assert.IsNotInstanceOfType(1, typeof(string)); //�O�_���O���w���������������
            Assert.IsNull(HelloWorld.StringTest2()); //�O�_�� null
            Assert.IsNotNull(HelloWorld.StringTest()); //�O�_���D null

        }
    }
}