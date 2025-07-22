using AutoMovePipWindow.Configuration;
using NUnit.Framework;

namespace AutoMovePipWindowTests;

public class ConfigurationTests
{
    [Test]
    public void TestSizeConfiguration()
    {
        SizeConfiguration size = "40*16/9:8";
        Assert.That(size.Margin, Is.EqualTo(8));
        Assert.That(size.Width, Is.EqualTo(40 * 16));
        Assert.That(size.Height, Is.EqualTo(40 * 9));
    }
}