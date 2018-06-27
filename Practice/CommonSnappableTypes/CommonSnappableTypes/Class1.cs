using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSnappableTypes
{
    public interface IAppFunctionality
    {
        void Doit();
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CompanyInfo2Attribute : System.Attribute
    {
        public string CommpanyNmae { get; set; }

        public string CommpanyUrl { get; set; }
    }

}
