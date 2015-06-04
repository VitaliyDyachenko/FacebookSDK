using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IX;

namespace FacebookSDK
{
    public enum PagePermissionTypes
    {
        [Description("ADMINISTER")]
        Admin,

        [Description("EDIT_PROFILE")]
        EditProfile,

        [Description("CREATE_CONTENT")]
        CreateContent,

        [Description("MODERATE_CONTENT")]
        UpdateContent,

        [Description("CREATE_ADS")]
        CreateAds,

        [Description("BASIC_ADMIN")]
        BasicAdmin,
    }
}
