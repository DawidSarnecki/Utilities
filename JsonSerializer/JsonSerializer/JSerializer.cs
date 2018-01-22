
namespace JsonSerializer
{
    using Newtonsoft.Json;

    public class JSerializer
    {
        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
