using System;
using System.Collections.Generic;
using System.Text;

namespace GetProperties
{
    public class Test
    {
        public string Name => "Name";

        public string Max => "Max";

        public decimal Dec { get; }

        public int Inter { get; }
    }
}
