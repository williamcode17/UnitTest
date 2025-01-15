using UnitTestCSharp;

namespace xUnitTest
{
    public class UnitTest1
    {
        [Fact] //不可有傳入參數
        public void Test1()
        {
            //Arrange 初始化
            HelloWorld hw = new HelloWorld();
            string temp = "Hello";
            //Act 執行方法、行為、操作並獲取結果

            //Assert 驗證
            Assert.Equal(temp, HelloWorld.StringTest());
        }

        [Theory] //傳入參數
        [InlineData(3, 4, 7)]
        public void Test2(int a, int b, int expected)
        {
            //Arrange
            //Act
            int result = a + b;
            //Assert
            Assert.Equal(expected, result);
        }
    }
}