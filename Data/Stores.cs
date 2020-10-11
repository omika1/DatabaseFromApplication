using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseFromApplication.Data
{
    public class Stores
    {

        public int Application { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }



    }
}