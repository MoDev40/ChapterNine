using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterNine
{
    class Order : Register
    {

        private string ordId;
        private string ordName;

        public string OrdId
        {
            get;set;
        }
        public string OrdName
        {
            get;set;    
        }
    }
}
