using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDK
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Determines the privacy settings of the post. If not supplied, this defaults to the
    ///     privacy level granted to the app in the Login Dialog. This field cannot be used to set a
    ///     more open privacy setting than the one granted.
    /// </summary>
    ///
    /// <author>    Anwar Javed. </author>
    /// <date>  5:25 PM 07 May 2015. </date>
    ///-------------------------------------------------------------------------------------------------

    public class Privacy
    {
        public PrivacyType? Type { get; set; }

        public string[] Allow { get; set; }

        public string[] Deny { get; set; }
    }
}
