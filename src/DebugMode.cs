using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;

namespace FacebookSDK
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Values that represent debug modes. </summary>
    ///
    /// <author>    Anwar Javed. </author>
    /// <date>  6:41 PM 06 May 2015. </date>
    ///-------------------------------------------------------------------------------------------------

    public enum DebugMode
    {
        /// <summary>   All available debug messages. </summary>
        [Description("all")]
        All = 0,


        /// <summary>   Debug messages with type "info" and "warning" (currently this is equal to all). </summary>
        [Description("all")]
        Info = 1,


        /// <summary>   Only debug messages with type "warning". </summary>
        [Description("all")]
        Warning = 2
    }
}
