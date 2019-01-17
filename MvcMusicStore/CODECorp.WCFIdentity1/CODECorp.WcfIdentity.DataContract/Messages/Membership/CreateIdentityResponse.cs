using CODECorp.WcfIdentity.DataContract.Views.ClaimIdentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace CODECorp.WcfIdentity.DataContract.Messages.Membership
{
    [DataContract]
    public class CreateIdentityResponse : BaseResponse
    {
        [DataMember]
        public ClaimIdentityView ClaimIdentityView { get; set; }
    }
}
