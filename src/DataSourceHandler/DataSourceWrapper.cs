using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisplayFormApp.src;

namespace DisplayFormApp.DataSourceHandler
{
    public delegate List<Class> getClassesDelegate();
    public class DataSourceWrapper
    {
        public getClassesDelegate getClassesFunction { get; set; }

        public DataSourceWrapper() {}
    }
}
