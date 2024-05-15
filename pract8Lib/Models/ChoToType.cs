using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace pract8Lib
{
    internal class ChoToType
    {
        public string tip {  get; set; }
        public string name { get; set; }
        public string napol { get; set; }

        public ChoToType(string tip, string name, string napol)
        {
            this.tip=tip;
            this.name=name;
            this.napol=napol;
        }
    }
}
