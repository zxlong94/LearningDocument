using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSnappableTypes;
using System.Reflection;

namespace _20180607ExtendableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void snapInModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Contains("CommonSnappableTypes"))
                {
                    MessageBox.Show("Common has no snap-ins!");
                }
                else if (!LoadExternalModule(dlg.FileName))
                    MessageBox.Show("nothing");
            }
        }

        private bool LoadExternalModule(string path)
        {
            bool rt = false;
            Assembly a = null;
            try
            {
                a = Assembly.LoadFrom(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return rt;
            }
            var classtype = from t in a.GetTypes() where t.IsClass && (t.GetInterface("IAppFunctionality") != null) select t;
            foreach(Type item in classtype)
            {
                rt = true;
                IAppFunctionality b = (IAppFunctionality)a.CreateInstance(item.FullName, true);
                b.Doit();
                loadsnapins.Items.Add(item.FullName);
                c(item);
            }
            return rt;
        }

        private void c(Type model)
        {
            var cominfo = from ci in model.GetCustomAttributes(false) where ci.GetType() == typeof(CompanyInfo2Attribute) select ci;
            foreach(CompanyInfo2Attribute item in cominfo)
            {
                MessageBox.Show(item.CommpanyUrl, "name:" + item.CommpanyNmae);
            }
        }
    }
}
