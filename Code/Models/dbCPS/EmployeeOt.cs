using System;
using System.Collections.Generic;

namespace HR_Management.Models.dbCPS
{
    public partial class EmployeeOt
    {
        public int EmployeeId { get; set; }
        public string? EmployeeUserId { get; set; }
        public string? EmployeeUserName { get; set; }
        public string? EmployeePassword { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeEditDate { get; set; }
        public string? EmployeeEditBy { get; set; }
        public string? EmployeeStatus { get; set; }
        public string? EmployeeRemark { get; set; }
        public string? EmployeePlant { get; set; }
        public string? EmployeeDep { get; set; }
        public string? EmployeeNamePlant { get; set; }
    }
}
