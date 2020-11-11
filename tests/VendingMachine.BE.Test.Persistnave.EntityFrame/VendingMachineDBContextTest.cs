using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using VendingMachine.Domain.Models.Enums;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;
using Xunit;

namespace VendingMachine.BE.Test.Persistnave.EntityFrame
{
    public class VendingMachineDBContextTest
    {
        [Fact]
        public void ShouldReturnAllStatuses()
        {
            var option = new DbContextOptionsBuilder<VendingMachineDbContext>()
                .UseInMemoryDatabase(databaseName: "VendingMachineDb")
                .Options;

            var context = new VendingMachineDbContext(option);

            EnsureDatabaseSeeded(context);

            var query = context.Set<Status>().ToList();

            Assert.Equal(13, query.Count);
        }

        private void EnsureDatabaseSeeded(VendingMachineDbContext context)
        {
            if (!context.Statuses.Any())
            {
                context.Statuses.AddRange
                (
                    new Status { StatusCode = StatusCode.Active, StatusName = "Active" },
                    new Status { StatusCode = StatusCode.Draft, StatusName = "Draft" },
                    new Status { StatusCode = StatusCode.Published, StatusName = "Published" },
                    new Status { StatusCode = StatusCode.AwaitingApproval, StatusName = "Awaiting Approval" },
                    new Status { StatusCode = StatusCode.Approved, StatusName = "Approved" },
                    new Status { StatusCode = StatusCode.InComplete, StatusName = "Incomplete" },
                    new Status { StatusCode = StatusCode.Complete, StatusName = "Complete" },
                    new Status { StatusCode = StatusCode.Pending, StatusName = "Pending" },
                    new Status { StatusCode = StatusCode.Archived, StatusName = "Archived" },
                    new Status { StatusCode = StatusCode.DeActivated, StatusName = "De-Activated" },
                    new Status { StatusCode = StatusCode.Suspended, StatusName = "Suspended" },
                    new Status { StatusCode = StatusCode.Disputed, StatusName = "Dispute" },
                    new Status { StatusCode = StatusCode.UnderInvestigation, StatusName = "Under Investigation" }
                );

                context.SaveChanges();
            }
        }
    }
}
