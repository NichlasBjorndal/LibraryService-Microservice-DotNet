using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
    }
}
