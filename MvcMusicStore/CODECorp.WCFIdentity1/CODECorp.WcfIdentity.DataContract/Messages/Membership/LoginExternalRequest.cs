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
    public class LoginExternalRequest : BaseRequest
    {

        [Required]
        [DataMember]
        public string ProviderKey { get; set; }

        [Required]
        [DataMember]
        public string LoginProvider { get; set; }

        [Required]
        [DataMember]
        public AuthenticationTypeEnum AuthenticationType { get; set; }
    }
}
