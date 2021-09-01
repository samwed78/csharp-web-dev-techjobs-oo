using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{

   [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job jobOne = new();
            Job jobTwo = new();

            Assert.IsTrue(jobOne.Id == (jobTwo.Id - 1));
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job jobThree = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(jobThree.Name == "Product tester");
            Assert.IsTrue(jobThree.EmployerName.Value == "ACME");
            Assert.IsTrue(jobThree.EmployerLocation.Value == "Desert");
            Assert.IsTrue(jobThree.JobType.Value == "Quality control");
            Assert.IsTrue(jobThree.JobCoreCompetency.Value == "Persistence");
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobOne = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job jobTwo = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));


            Assert.IsFalse(jobOne.Equals(jobTwo));

        }
        [TestMethod]
        public void TestToString()
        {
            Job jobfour = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            {
                string run = $"\nID: {jobfour.Id} \n Name: {jobfour.Name} \n Employer: {jobfour.EmployerName.Value } \n " +
                     $"Location: {jobfour.EmployerLocation.Value} \n PositionType: {jobfour.JobType.Value} \n " +
                     $"CoreCompetency: {jobfour.JobCoreCompetency.Value}\n";
                Assert.AreEqual(run, jobfour.ToString());
            }
        }
    }
}



            
                 
                

       
       




