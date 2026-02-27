using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System.Collections.Generic;

public static class TestDataHelper
{
    private static readonly JsonSettingsFile testData = new("TestData.json");

    public static User GetUser(string userType)
    {
        return new User
        {
            Username = testData.GetValue<string>($"{userType}.username"),
            Password = testData.GetValue<string>($"{userType}.password")
        };
    }
    public static User GetPersonalInfo()
    {
        return new User
        {
            FirstName = testData.GetValue<string>("PersonalInfo.firstName"),
            LastName = testData.GetValue<string>("PersonalInfo.lastName"),
            PostalCode = testData.GetValue<string>("PersonalInfo.postalCode")
        };
    }
}