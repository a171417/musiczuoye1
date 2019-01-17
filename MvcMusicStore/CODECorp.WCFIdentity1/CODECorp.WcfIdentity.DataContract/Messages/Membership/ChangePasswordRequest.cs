using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace CODECorp.WcfIdentity.DataContract.Messages.Membership
{
    [DataContract]
    public class ChangePasswordRequest : BaseRequest
    {
        [DataMember]
        public Guid UserId { get; set; }

        [DataMember]
        public string OldPassword { get; set; }

        [DataMember]
        public string NewPassword { get; set; }
    }
}
