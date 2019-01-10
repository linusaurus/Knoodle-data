using System;
using Xunit;
using Xunit.Extensions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Weaselware.Knoodle.Data.Models;
using Weaselware.Knoodle.Data.Services;
using System.Threading.Tasks;

namespace KnoodleTestProject
{
    public class AssemblyCalculationsTest
    {
        //[Fact]
        //public void TestProduct()
        //{
        //    Assembly assembly = new Assembly
        //    {
        //        ProductID = 1,
        //        ProductName = "Door 122",
        //        JobID = 1223,
        //        ProductionGroupID = 12,
        //        ProductionDate = DateTime.Today,
        //        ArchRef = "Bernies Office",
        //        Width = 102.5m,
        //        Height = 96.0m,
        //        Depth = 6.0m,
        //        Note = "Lots of Notes"
        //    };

        //    Assert.True( assembly.AssemblyID == 1);
            

        //}

        [Fact]
        public void TestAssemblyPerimeter()
        {
            Assembly assembly = new Assembly
            {
                AssemblyID = 1,
                AssemblyName = "DoorThree",
                Width = 4.0m,
                Height = 4.0m
            };

            Assert.Equal(16.0m, assembly.Perimeter());
        }

        [Fact]
        public void TestAssemblyArea()
        {
            Assembly assembly = new Assembly
            {
                AssemblyID = 1,
                AssemblyName = "DoorThree",
                Width = 2.0m,
                Height = 4.0m
            };

            Assert.Equal(8.0m, assembly.Area());
        }

        [Fact]
        public async Task GetAllPart()
        {
            PartService partService = new PartService(new Weaselware.Knoodle.Data.EFCode.KnoodleContext());
            var parts = await partService.GetAllParts();
            Assert.True(parts.Count > 5400);
            var k = parts[2].ItemDescription;
            
        }

        [Fact]
        public async Task Findpart()
        {
            PartService partService = new PartService(new Weaselware.Knoodle.Data.EFCode.KnoodleContext());
            var parts = await partService.Find(1);
            Assert.True(parts[1].PartID == 1);

        }
    }

    public class JobsServiceTest
    {

        [Fact]
        public async Task FindGetAllJobs()
        {
            JobService jobService = new JobService(new Weaselware.Knoodle.Data.EFCode.KnoodleContext());
            var jobs = await jobService.GetAllJobs();
            Assert.True(jobs.Count() > 100);
        }

        [Fact]
        public async Task FindJob()
        {
            JobService jobService = new JobService(new Weaselware.Knoodle.Data.EFCode.KnoodleContext());
            var job = await jobService.Find(1277);
            Assert.True(job.Job_id == 1277);
        }

    }

    public class SubAssemblyServiceTest
    {

        [Fact]
        public async Task GetAllSubAssemblies()
        {
            AssemblyService assemblyService = new AssemblyService(new Weaselware.Knoodle.Data.EFCode.KnoodleContext());
            var assemblies = await assemblyService.GetAll();
            Assert.True(assemblies.Count() > 1);
        }

        [Fact]
        public async Task FindSubAssembly()
        {
            JobService jobService = new JobService(new Weaselware.Knoodle.Data.EFCode.KnoodleContext());
            var job = await jobService.Find(1277);
            Assert.True(job.Job_id == 1277);
        }

    }
}
