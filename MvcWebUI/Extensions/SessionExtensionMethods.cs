using Newtonsoft.Json;

namespace MvcWebUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, string key, Object value)
        {
            string onjectString = JsonConvert.SerializeObject(value);
            session.SetString(key, onjectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }
            else
            {
                T value = JsonConvert.DeserializeObject<T>(objectString);
                return value;
            }
        }
    }
}
