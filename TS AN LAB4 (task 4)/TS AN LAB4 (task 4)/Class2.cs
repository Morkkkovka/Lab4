using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB4__task_4_
{
    public class AppLicense
    {
        public LicenseType License
        {
            get;
            private set;
        } = LicenseType.Common;

        private const string TrialKey = "gt453-754";
        private const string ProKey = "ey12-hr632";

        public LicenseType ChangeLicense(string key)
        {
            if (key == TrialKey)
                AllowTrial();
            else if (key == ProKey)
                AllowPro();
            else
                AllowCommon();

            return License;
        }

        private void AllowCommon()
        {
            License = LicenseType.Common;
        }
        private void AllowTrial()
        {
            License = LicenseType.Trial;
        }
        private void AllowPro()
        {
            License = LicenseType.Pro;
        }
        
    }
      public enum LicenseType
    {
        Common = 0,
        Trial,
        Pro
    }
}
