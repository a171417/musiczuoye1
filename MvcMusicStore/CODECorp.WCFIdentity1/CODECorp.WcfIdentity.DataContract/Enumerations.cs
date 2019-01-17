using CODECorp.WcfIdentity.DataContract.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CODECorp.WcfIdentity.DataContract
{
    public enum GenderEnum
    {
        [EnumStringValue("Male")]
        Male = 0,
        [EnumStringValue("Female")]
        Female
    }

    public enum AuthenticationTypeEnum
    {
        [EnumStringValue("ApplicationCookie")]
        ApplicationCookie = 0,
        [EnumStringValue("ExternalCookie")]
        ExternalCookie,
        [EnumStringValue("ExternalBearer")]
        ExternalBearer
    }
}
