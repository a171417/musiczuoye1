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
    public class CreateRequest : BaseRequest
    {

        [Required]
        [DataMember]
        public string FirstName { get; set; }

        [Required]
        [DataMember]
        public string LastName { get; set; }

        [Required]
        [DataMember]
        public string UserName { get; set; }

        [Required]
        [DataMember]
        public string Password { get; set; }

        [Required]
        [DataMember]
        public AuthenticationTypeEnum AuthenticationType { get; set; }

    }
}
