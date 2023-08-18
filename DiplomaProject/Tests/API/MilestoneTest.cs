namespace DiplomaProject.Tests.API;

public class MilestoneTest : BaseApiTest
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

    [Test(Description = "NFE POST api_test")]
    [Description("Add new Milestone using all required data")]
    [Category("API")]
    public void AddMilestoneTest()
    {
        var expectedMilestone = TestDataHelper.AddTestMilestone("MilestoneTestData.json");

        _logger.Info("Expected Milestone: " + expectedMilestone);

        var actualMilestone = _milestoneService.AddAsMilestone(expectedMilestone, 1);
        _logger.Info("Actual Milestone: " + actualMilestone.ToString());

        Console.WriteLine($"Milestone Id: {actualMilestone.Id}");

        Assert.That(actualMilestone.Name, Is.EqualTo(expectedMilestone.Name));
    }

    [Test(Description = "AFE GET api_test")]
    [Description("Get Milestone using incorrect data (Id)")]
    [Category("API")]
    public void GetInvalidMilestoneTest()
    {
        var actualMilestone = _milestoneService.GetMilestoneAsync(0);
        _logger.Info("Actual Milestone: " + actualMilestone.ToString());                        

        Assert.That(actualMilestone.Result.StatusCode.ToString(), Is.EqualTo(HttpStatusCode.BadRequest.ToString()));
    }
}