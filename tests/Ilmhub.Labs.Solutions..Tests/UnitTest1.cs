using Xunit;

namespace Ilmhub.Labs.Solutions._Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(10,10,9,25)]
    [InlineData(0,30,23,45)]
    [InlineData(23,40,22,55)]
    public void CheckClock(int value1, int value2, int hour, int minut)
    {
        var clock = new Problems();

        var result = clock.GetClock(value1,value2);

        Assert.Equal(hour, result.Item1);
        Assert.Equal(minut,result.Item2);    
    }
}