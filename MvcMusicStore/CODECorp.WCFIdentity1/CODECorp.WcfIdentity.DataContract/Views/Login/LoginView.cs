using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CODECorp.WcfIdentity.DataContract.Views.Login
{
    [DataContract]
    public class LoginView
    {

        [Required]
        [DataMember]
        public string LoginProvider { get; set; }

        [Required]
        [DataMember]
        public string ProviderKey { get; set; }

    }
}
