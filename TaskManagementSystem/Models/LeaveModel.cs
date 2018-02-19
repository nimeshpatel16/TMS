using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace TaskManagementSystem.Models
{
    public class LeaveModel
    {
        public Int32 LeaveId { get; set; }
        public Int32 ResourceID { get; set; }
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }
        public bool IsStartHalf { get; set; }
        public bool IsEndHalf { get; set; }
        [Required(ErrorMessage = "Reason text cannot be blank")]
        public string Reason { get; set; }
    }
}