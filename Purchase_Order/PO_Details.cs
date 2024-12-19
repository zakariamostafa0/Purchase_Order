using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_Order
{
    public class PO_Details
    {
        public int PR_Month { get; set; }
        public int PR_Year { get; set; }
        public int PR_Type { get; set; }
        public string PR_Name { get; set; }
        public string PO_Name { get; set; }
        public DateTime PO_Date { get; set; }
        public string PO_Department { get; set; }
        public string PO_Supplier { get; set; }
        public int PO_PIN { get; set; }
        public string PO_Article { get; set; }
        public string PO_Unit { get; set; }
        public double PO_Quantity { get; set; }
        public double PO_Recived_Quantity { get; set; }
        public double PO_Due_Quantity { get; set; }
        public DateTime PO_Due_Date { get; set; }
        public string PO_FileName { get; set; }
    }
}
