using System.ComponentModel;

namespace VendingMachine.Domain.Models.Enums
{
    public enum StatusCode
    {
        [Description("active")]
        Active = 1,

        [Description("draft")]
        Draft,

        [Description("published")]
        Published,

        [Description("awaiting Approval")]
        AwaitingApproval,

        [Description("approval")]
        Approved,

        [Description("in-Complete")]
        InComplete,

        [Description("complete")]
        Complete,

        [Description("pending")]
        Pending,

        [Description("archived")]
        Archived,

        [Description("de-Activated")]
        DeActivated,

        [Description("suspended")]
        Suspended,

        [Description("disputed")]
        Disputed,

        [Description("under Investigation")]
        UnderInvestigation
    }
}
