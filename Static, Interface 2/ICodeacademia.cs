using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface_2
{
    internal interface ICodeacademia
    {
        string CodeEmail { get; set; }
        void GenerateEmail();
    }
}
