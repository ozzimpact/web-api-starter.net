using Jil;

namespace Api
{
    public class JilSerializer : IJsonSerializer
    {
        public T DeserializeObject<T>(string json)
        {
            return JSON.Deserialize<T>(json);
        }

        public string SerializeObject<T>(T value)
        {
            return JSON.Serialize(value);
        }
    }
}