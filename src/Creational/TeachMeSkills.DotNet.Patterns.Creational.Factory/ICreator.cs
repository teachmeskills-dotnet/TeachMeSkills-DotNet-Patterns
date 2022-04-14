﻿namespace TeachMeSkills.DotNet.Patterns.Creational.Factory
{
    /// <summary>
    /// Creator.
    /// </summary>
    /// <typeparam name="T">Generic result type from method.</typeparam>
    public interface ICreator<T>
    {
        /// <summary>
        /// Create.
        /// </summary>
        public T Create();
    }
}
