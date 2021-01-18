using System;
using Hokemon_Challenge.Pokemon.Impl;

namespace Hokemon_Challenge.Util {
    public static class EnumUtil {

        public static T GetEnumValue<T>(string input) where T : struct, IComparable {

            T found;
            
            foreach (var i in Enum.GetNames(typeof(T))) {
                if (i.Equals(input, StringComparison.InvariantCultureIgnoreCase)) {
                    return Enum.Parse<T>(i);
                }
            }

            return default(T);
        }
        
    }
}