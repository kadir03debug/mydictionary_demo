using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class mydictionary<T, V>  {
    V []value;
       T [] keys;
        public mydictionary ()
        {
            value = new V [0];
            keys = new T [0];
        }
       V []temp_value;
        T []temp_keys;
       public void Add(V val,T ke) { temp_value = value; temp_keys = keys; keys = new T[keys.Length + 1]; value = new V [value.Length + 1];for (int i = 0; i < value.Length; i++) { for (int j = 0; j < keys.Length; j++) {     value[i] = temp_value[i]; keys[j] = temp_keys[j]; } }value[value.Length - 1] = val;keys[keys.Length - 1] = ke; }



    }
}
