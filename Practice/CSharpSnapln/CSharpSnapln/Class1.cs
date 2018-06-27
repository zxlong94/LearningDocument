using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonSnappableTypes;
using System.Windows.Forms;

namespace CSharpSnapln
{
    public class Class1
    {
        [CompanyInfo2(CommpanyNmae = "My Company", CommpanyUrl = "www.nb.com")]
        public class CSh : IAppFunctionality
        {
            void IAppFunctionality.Doit()
            {
                MessageBox.Show("you have just used c# !");
            }
        }

    }
}
