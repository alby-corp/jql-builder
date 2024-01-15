﻿namespace JQLBuilder.Types.Tests.Types;

using Constants;
using Infrastructure.Constants;

public partial class IssueTests
{
    [TestMethod]
    public void Should_Order_By_ASC_Affected_Version()
    {
        const string expected = $"{Keywords.OrderBy} {Fields.Issue} {Keywords.Ascending}";

        var actual = JqlBuilder.Query
            .OrderBy(f => f.Issue)
            .ToString();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Should_Order_By_DESC_Affected_Version()
    {
        const string expected = $"{Keywords.OrderBy} {Fields.Issue} {Keywords.Descending}";

        var actual = JqlBuilder.Query
            .OrderByDescending(f => f.Issue)
            .ToString();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Should_Order_By_ASC_Fix_Version()
    {
        const string expected = $"{Keywords.OrderBy} {Fields.Issue} {Keywords.Ascending}";

        var actual = JqlBuilder.Query
            .OrderBy(f => f.Issue)
            .ToString();

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Should_Order_By_DESC_Fix_Version()
    {
        const string expected = $"{Keywords.OrderBy} {Fields.Issue} {Keywords.Descending}";

        var actual = JqlBuilder.Query
            .OrderByDescending(f => f.Issue)
            .ToString();

        Assert.AreEqual(expected, actual);
    }
}