using UnitTestCSharp;

namespace xUnitTest
{
    public class UnitTest1
    {
        [Fact] //���i���ǤJ�Ѽ�
        public void Test1()
        {
            //Arrange ��l��
            HelloWorld hw = new HelloWorld();
            string temp = "Hello";
            //Act �����k�B�欰�B�ާ@��������G

            //Assert ����
            Assert.Equal(temp, HelloWorld.StringTest());
        }

        [Theory] //�ǤJ�Ѽ�
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