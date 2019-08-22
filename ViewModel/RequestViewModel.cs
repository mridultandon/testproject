using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.ViewModel
{
    public class RequestViewModel
    {
        public int RequestId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public bool IsApproved { get; set; }
        public string Comment { get; set; }
    }
}
