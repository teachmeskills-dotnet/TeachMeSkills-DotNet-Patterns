namespace TeachMeSkills.DotNet.Patterns.Behavioral.Memento
{
    /// <summary>
    /// Memento caretaker interface.
    /// </summary>
    /// <typeparam name="T">State generic type.</typeparam>
    /// <typeparam name="V">Method return generic type.</typeparam>
    /// <typeparam name="Z">Originator generic type.</typeparam>
    public interface IMementoCaretaker<T, V, Z>
    {
        /// <summary>
        /// Mementos.
        /// </summary>
        public List<IMemento<T, V>> Mementos { get; }

        /// <summary>
        /// Originator.
        /// </summary>
        public Z Originator { get; }

        /// <summary>
        /// Backup.
        /// </summary>
        public void Backup();

        /// <summary>
        /// Undo.
        /// </summary>
        public void Undo();

        /// <summary>
        /// ShowHistory.
        /// </summary>
        public void ShowHistory();
    }
}
