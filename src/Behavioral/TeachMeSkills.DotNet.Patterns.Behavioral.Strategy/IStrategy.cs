namespace TeachMeSkills.DotNet.Patterns.Behavioral.Stategy
{
    /// <summary>
    /// Stategy interface.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Do.
        /// </summary>
        /// <param name="data">Data.</param>
        object Do(object data);
    }
}
