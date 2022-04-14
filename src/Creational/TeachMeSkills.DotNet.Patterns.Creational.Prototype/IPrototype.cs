using System.Text.Json;

namespace TeachMeSkills.DotNet.Patterns.Creational.Prototype
{
    /// <summary>
    /// Prototype interface.
    /// </summary>
    /// <typeparam name="T">Generic result type from method.</typeparam>
    public interface IPrototype<T>
    {
        /// <summary>
        /// Deep copy by json serialization.
        /// </summary>
        public T DeepCopyByJson()
        {
            var jsonObject = JsonSerializer.Serialize(this);
            var result = JsonSerializer.Deserialize<T>(jsonObject);

            return result;
        }
    }
}
