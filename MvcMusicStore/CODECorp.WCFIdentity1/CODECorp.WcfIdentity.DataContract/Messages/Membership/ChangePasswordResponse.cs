﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace CODECorp.WcfIdentity.DataContract.Messages.Membership
{
    [DataContract]
    public class ChangePasswordResponse : BaseResponse
    {
        [DataMember]
        public bool PasswordChanged { get; set; }
    }
}