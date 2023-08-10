using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FormDesign
    {
        public string FormDesignName { get; private set; }

        public FormDesign(string i_FormDesignName)
        {
            FormDesignName = i_FormDesignName;
        }
    }

}
