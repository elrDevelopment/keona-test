using System;
using System.Collections.Generic;

namespace WebApplication.DataAccess
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int PersonId { get; set; }
        public DateTime? OrderDateTime { get; set; }
    }
}
