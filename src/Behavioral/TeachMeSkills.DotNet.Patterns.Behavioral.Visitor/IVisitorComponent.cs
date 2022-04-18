namespace TeachMeSkills.DotNet.Patterns.Behavioral.Visitor
{
    /// <summary>
    /// Visitor component interface.
    /// </summary>
    /// <typeparam name="T">Use custom IVisitor interface.</typeparam>
    public interface IVisitorComponent<T>
    {
        /// <summary>
        /// Accept.
        /// </summary>
        /// <param name="visitor">Visitor.</param>
        public void Accept(T visitor);
    }
}
