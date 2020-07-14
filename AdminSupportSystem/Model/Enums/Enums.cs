using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enums
{
    public enum EmployeeStatusType
    {
        Active = 1,
        Terminated = 2,
        Retired = 3

    };

    public enum CredentialType
    {
        HRSup = 1,
        RegSup = 2,
        HREmp = 3,
        RegEmp = 4
    }
    public enum ApprovalStatus
    {
        Pending = 1,
        UnderReview = 2,
        Closed = 3
    }
    public enum ItemStatusType
    {
        Pending = 1,
        Approved = 2,
        Denied = 3
    }

    public enum ReviewRatingType
    {
        Above = 1,
        Meets = 2,
        Below = 3
    }
}
