﻿using CODECorp.WcfIdentity.DataContract.Views.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace CODECorp.WcfIdentity.DataContract.Messages.Membership
{
    [DataContract]
    public class FindByIdResponse : BaseResponse
    {
        [DataMember]
        public UserView UserView { get; set; }
    }
}
