using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSDK
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An URL post to attach to the post. . </summary>
    ///
    /// <author>    Anwar Javed. </author>
    /// <date>  5:31 PM 07 May 2015. </date>
    ///-------------------------------------------------------------------------------------------------

    public class UrlPost
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>  The URL of a link to attach to the post.  </summary>
        ///
        /// <value> The URL of a link to attach to the post.  </value>
        ///-------------------------------------------------------------------------------------------------

        public string Link { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Overwrites the title of the link preview. </summary>
        ///
        /// <value> The title of the link preview. </value>
        ///-------------------------------------------------------------------------------------------------

        public string Title { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the caption under the title in the link preview. </summary>
        ///
        /// <value> The caption under the title in the link preview. </value>
        ///-------------------------------------------------------------------------------------------------

        public string Caption { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the description in the link preview. </summary>
        ///
        /// <value> The description in the link preview. </value>
        ///-------------------------------------------------------------------------------------------------

        public string Description { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the preview image associated with the link. </summary>
        ///
        /// <value> The preview image associated with the link. </value>
        ///-------------------------------------------------------------------------------------------------

        public string Picture { get; set; }
    }
}
