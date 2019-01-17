using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace CODECorp.WcfIdentity.DataContract.Utilities
{

    public class EnumStringValue : System.Attribute
    {
        private readonly string _Value;
        public EnumStringValue(string Value)
        {
            this._Value = Value;
        }

        public string Value
        {
            get { return this._Value; }
        }

        public static Enum Parse(Type EnumType, string Value)
        {
            IList<KeyValuePair<string, int>> enumValues = EnumStringValue.ToList(EnumType);

            return (Enum)Enum.ToObject(EnumType, enumValues.Where(o => o.Key == Value).First().Value);
        }

        public static string GetStringValue(Enum Value)
        {
            FieldInfo info = Value.GetType().GetFields()
                                            .Where(o => o.Name == Value.ToString())
                                            .FirstOrDefault();

            return EnumStringValue.GetStringValue(info);
        }

        public static string GetStringValue(FieldInfo value)
        {
            string output = null;

            EnumStringValue[] attrs = (EnumStringValue[])value.GetCustomAttributes(typeof(EnumStringValue), false);

            if (attrs.Length > 0)
                output = attrs[0].Value;

            return output;
        }

        public static IList<KeyValuePair<string, int>> ToList(Type EnumType)
        {
            if (EnumType == null)
                throw new ArgumentNullException("type");

            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();

            foreach (FieldInfo item in EnumType.GetFields().Where(o => o.Name != "value__"))
            {
                int value = Convert.ToInt32(Enum.Parse(EnumType, item.Name, true));
                string name = EnumStringValue.GetStringValue(item);
                list.Add(new KeyValuePair<string, int>(name, value));
            }

            return list;
        }


        public class KeyValuePair<TKey, TValue>
        {
            public KeyValuePair() { }
            public KeyValuePair(TKey Key, TValue Value)
            {
                this.Key = Key;
                this.Value = Value;
            }

            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }
    }
}
