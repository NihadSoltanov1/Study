using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Application.Features.Query.User.UserInform
{
    public class UserInformApplicantsQueryResponse
    {
        public List<MyApplicant>? MyApplicants { get; set; }
    }
    public class MyApplicant
    {
        public string? Name { get; set; }
        public string? Status { get; set; }
    }
}
