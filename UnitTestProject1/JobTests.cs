using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace UnitTestProject1
{
    [TestClass]
    public class JobTests
    {
        //Created Object to run with test.
        Job test_job;
        [TestInitialize]
        public void CreateJobObject()
        {
            test_job = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        }
        
        //Test to run.
        [TestMethod]
        public void TestSettingJobId()
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();

            Assert.AreEqual(1, jobTwo.Id - jobOne.Id, 0.01);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product Tester", test_job.Name);
            Assert.AreEqual("ACME", test_job.EmployerName.Value);
            Assert.AreEqual("Desert", test_job.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", test_job.JobType.Value);
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobOne = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(Equals(test_job, jobOne));
        }
    }
}
