using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofnouCommon
{
    public class OpenApiDefaultLogLayout : PatternLayout
    {
        public OpenApiDefaultLogLayout()
        {
            this.AddConverter("autoObj", typeof(OpenApiDefaultPatternLayoutConverter));
        }
    }
}
