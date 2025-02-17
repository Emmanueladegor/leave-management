﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace leave_management.Models
{
    public class LeaveAllocationVM
    {
        
        public int Id { get; set; }


        public int NumberOfDays { get; set; }


        public DateTime DateCreated { get; set; }


        public EmployeeVM Employee { get; set; }


        public string EmployeeId { get; set; }

       
        public DetailsLeaveTypeVM LeaveType { get; set; }


        public int LeaveTypeId { get; set; }

        public IEnumerable<SelectListItem> Employees { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes  { get; set; }
    }
}
