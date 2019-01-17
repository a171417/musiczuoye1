using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CODECorp.WcfIdentity.DataContract;

namespace CODECorp.WcfIdentity.DataContract.Messages.Membership
{
    [DataContract]
    public class AddPasswordRequest : BaseRequest
    {

        [Required]
        [DataMember]
        public Guid UserId { get; set; }

        [Required]
        [DataMember]
        public string NewPassword { get; set; }

    }
}
