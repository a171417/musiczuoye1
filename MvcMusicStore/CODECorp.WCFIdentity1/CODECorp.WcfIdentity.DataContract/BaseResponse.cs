using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CODECorp.WcfIdentity.DataContract
{
    [DataContract]
    public abstract class BaseResponse
    {
        public BaseResponse()
        {
            this.Errors = new List<string>();
        }

        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public IList<string> Errors { get; set; }

        public void AddErrors(IEnumerable<string> ErrorList)
        {
            if (this.Errors != null)
            {
                foreach (string error in ErrorList)
                    this.Errors.Add(error);
            }
        }
    }
}
