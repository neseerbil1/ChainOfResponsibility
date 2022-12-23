using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsobolity.DAL.Entities
{
    public class CustomerProcess
    {
    
        public int CustomerProcessID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeTitle { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

    }
}
