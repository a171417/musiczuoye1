using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CODECorp.WcfIdentity.DataContract.Views.Login;

namespace CODECorp.WcfIdentity.DataContract.Messages.Membership
{
    [DataContract]
    public class GetLoginsResponse : BaseResponse
    {
        [DataMember]
        public IList<LoginView> LinkedAccounts { get; set; }
    }
}
