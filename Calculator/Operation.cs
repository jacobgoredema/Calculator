using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operation
    {
        public string LeftSide { get; set; }

        public string RightSide { get; set; }

        public OperationType OperationType { get; set; }

        public Operation InnerOperation { get; set; }

        public Operation()
        {
            LeftSide = string.Empty;
            RightSide = string.Empty;
        }

    }
}
