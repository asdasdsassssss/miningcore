using System.Diagnostics;
using System.Globalization;

namespace Miningcore.Extensions;

public static class DictionaryExtensions
{
    public static void StripValue<T>(this IDictionary<string, T> dict, string key)
    {
        key = key.ToLower(CultureInfo.InvariantCulture);

        var keyActual = dict.Keys.FirstOrDefault(x => x.ToLower(CultureInfo.InvariantCulture) == key);

        if(keyActual != null)
        {
            var result = dict.Remove(keyActual);
            Debug.Assert(result);
        }
    }
}
