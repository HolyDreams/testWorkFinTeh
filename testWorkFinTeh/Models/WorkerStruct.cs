using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWorkFinTeh.Models
{
    public class IdGuidNameStruct
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
    public class WorkerStruct : IdGuidNameStruct
    {
        public string MiddleName { get; set; }
        public string? LastName { get; set; }
        public Guid RoleID { get; set; }
        public string RoleName { get; set; }
        public Guid DepartID { get; set; }
        public string DepartName { get; set; }
        public DateTime? VacationStart { get; set; }
        public DateTime? VacationEnd { get; set; }
    }
}
