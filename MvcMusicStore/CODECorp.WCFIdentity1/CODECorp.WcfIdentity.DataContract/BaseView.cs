using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CODECorp.WcfIdentity.DataContract
{
    [DataContract]
    public abstract class BaseView
    {
        //[NonSerialized]
        private readonly DateTime _ObjectCreationTime;

        public BaseView()
        {
            this._ObjectCreationTime = DateTime.UtcNow;
        }


        public DateTime ObjectCreationTime
        {
            get
            {
                return this._ObjectCreationTime;
            }

        }
    }
}
