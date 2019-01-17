﻿using CODECorp.WcfIdentity.DataContract.Views.ClaimIdentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace CODECorp.WcfIdentity.DataContract.Messages.Membership
{
    [DataContract]
    public class CreateResponse : BaseResponse
    {
        [DataMember]
        public Guid UserId { get; set; }

        [DataMember]
        public ClaimIdentityView ClaimIdentity { get; set; }
    }
}
