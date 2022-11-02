using Xunit;



public class XUnitTestClass
{
    public XUnitTestClass()
    {

    }


    [Fact]
    public void Test_One()
    {
        //do stuff;
    }


    [Theory]
    [InlineData("hello")]
    public void Test_Two(string testValue)
    {
        //do stuff
    }
}