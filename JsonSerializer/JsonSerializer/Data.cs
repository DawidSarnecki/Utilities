
namespace JsonSerializer
{
    using System.Collections.Generic;

    public class Data
    {
        public IList<Data> Datas { get; set; }
        public IList<string> Roles { get; set; }
        public IList<string> Names { get; set; }
        public IList<string> Persons { get; set; }
        public IList<string> Proffession { get; set; }
    }
}
