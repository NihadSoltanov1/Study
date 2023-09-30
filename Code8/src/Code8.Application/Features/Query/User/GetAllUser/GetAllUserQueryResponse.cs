using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code8.Application.Features.Query.User.GetAllUser
{
    public class GetAllUserQueryResponse
    {
        public List<GetAllUser>? AllUsers { get; set; }
    }
    public class GetAllUser
    {
        public string? Name { get; set; }
        public string? EduName { get; set; }
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
    }
}
