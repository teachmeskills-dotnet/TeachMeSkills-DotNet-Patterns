namespace TeachMeSkills.DotNet.Patterns.Structural.Flyweight
{
    // UNDONE: get XML comment to class

    /// <summary>
    /// Flyweight factory interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="V"></typeparam>
    public interface IFlyweightFactory<T, V>
    {
        public IList<Tuple<IFlyweight<T>, V>> Flyweights { get; }

        public string GetKey(T key);

        public IFlyweight<T> GetFlyweight(T sharedState);

        public void ListFlyweights();
    }
}
