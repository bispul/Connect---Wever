using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    class WeverEntityClass : TableEntity
    {

        //public WeverEntityClass(string category, string sku) : base(sku,category)
        //{

        //}

        public WeverEntityClass() { }

        public string deviceId{ get;set;}
        public string pumpControl { get; set; }
        public string time { get; set; }
        public string waterlevel { get; set; }
    
        public string waterRes { get; set; }

    }
}
