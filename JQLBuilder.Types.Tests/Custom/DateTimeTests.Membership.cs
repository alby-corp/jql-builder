﻿namespace JQLBuilder.Types.Tests.Custom;

using Fields.BuildIn;
using Primitive;
using Types.Custom;
using Types.Support;

public partial class DateTimeTests
{
    [TestMethod]
    public void Should_Parses_In_Params_When_Are_Heterogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" in ("{dateString}", "{dateString}", now())
                        """;

        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].In(dateString, dateTime, f.DateTime.Now))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Should_Parses_In_Params_When_Are_Homogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" in ("{dateString}", "{dateString}", "{dateString}")
                        """;

        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].In(dateString, dateString, dateString))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Should_Parses_Not_In_Params_When_Are_Heterogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" not in ("{dateString}", "{dateString}", now())
                        """;

        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].NotIn(dateString, dateTime, f.DateTime.Now))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Should_Parses_Not_In_Params_When_Are_Homogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" not in ("{dateString}", "{dateString}", "{dateString}")
                        """;

        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].NotIn(dateString, dateString, dateString))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Should_Parses_In_Collection_When_Are_Homogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" in ("{dateString}", "{dateString}", "{dateString}")
                        """;

        var filters = new JqlCollection<DateTimeExpression> { dateString, dateString, dateString };

        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].In(filters))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Should_Parses_In_Collection_When_Are_Heterogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" in ("{dateString}", "{dateString}", now())
                        """;

        var filters = new JqlCollection<DateTimeExpression> { dateString, dateTime, Date.DateTime.Now  };
        
        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].In(filters))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Should_Parses_NotIn_Collection_When_Are_Homogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" not in ("{dateString}", "{dateString}", "{dateString}")
                        """;

        var filters = new JqlCollection<DateTimeExpression> { dateString, dateString, dateString };

        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].NotIn(filters))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Should_Parses_NotIn_Collection_When_Are_Heterogeneous()
    {
        var expected = $"""
                        "{CustomFieldName}" not in ("{dateString}", "{dateString}", now())
                        """;

        // var filters = new List<DateTimeExpression> { dateString, dateTime, Date.DateTime.Now }.ToJqlCollection();
        var filters = new JqlCollection<DateTimeExpression> { dateString, dateTime, Date.DateTime.Now };

        var actual = JqlBuilder.Query
            .Where(f => f.Custom.DateTime[CustomFieldName].NotIn(filters))
            .ToString();

        Assert.AreEqual(expected, actual);
    }
}