namespace DiplomaProject.Utilities.Helpers;

public static class TestDataHelper
{
    public static Milestone AddTestMilestone(string fileName)
    {
        var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var json = File.ReadAllText(basePath + Path.DirectorySeparatorChar + "TestData"
                                    + Path.DirectorySeparatorChar + fileName);
        var jsonObject = JObject.Parse(json);

        var milestone = new Milestone()
        {
            Name = (string)jsonObject["name"],
            Description = (string?)jsonObject["description"]
        };

        return milestone;
    }

    public static Suite AddTestSuite(string fileName)
    {
        var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var json = File.ReadAllText(basePath + Path.DirectorySeparatorChar + "TestData"
                                    + Path.DirectorySeparatorChar + fileName);
        var jsonObject = JObject.Parse(json);

        var suite = new Suite
        {
            Id = (int)jsonObject["id"],
            Description = (string)jsonObject["project_id"],
            Name = (string)jsonObject["name"]
        };

        return suite;
    }
}