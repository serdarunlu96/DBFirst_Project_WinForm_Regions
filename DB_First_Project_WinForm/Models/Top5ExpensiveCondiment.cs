using System;
using System.Collections.Generic;

namespace DB_First_Project_WinForm.Models
{
    public partial class Top5ExpensiveCondiment
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
    }
}
