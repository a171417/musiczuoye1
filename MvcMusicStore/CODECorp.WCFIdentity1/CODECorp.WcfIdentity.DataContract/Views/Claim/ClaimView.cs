using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CODECorp.WcfIdentity.DataContract.Views.Claim
{
    [DataContract]
    public class ClaimView
    {

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public string ValueType { get; set; }

    }
}
