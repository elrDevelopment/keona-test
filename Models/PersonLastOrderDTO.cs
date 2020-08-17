using System;

namespace WebApplication.Models
{
    
    public class PersonLastOrderDTO
    {
        public int PersonId { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public int? LastOrderId { get; set; }
        public DateTime? LastOrderDateTime { get; set; }
    }
}