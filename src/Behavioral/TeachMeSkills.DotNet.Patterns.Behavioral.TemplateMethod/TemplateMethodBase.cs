namespace TeachMeSkills.DotNet.Patterns.Behavioral.TemplateMethod
{
    /// <summary>
    /// Template method base class.
    /// </summary>
    public abstract class TemplateMethodBase
    {
        /// <summary>
        /// Template method.
        /// </summary>
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperation1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        /// <summary>
        /// Base operation 1.
        /// </summary>
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        /// <summary>
        /// Base operation 2.
        /// </summary>
        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        /// <summary>
        /// Base operation 3.
        /// </summary>
        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        /// <summary>
        /// Required operation 1.
        /// </summary>
        protected abstract void RequiredOperation1();

        /// <summary>
        /// Required operation 2.
        /// </summary>
        protected abstract void RequiredOperation2();

        /// <summary>
        /// Hook 1.
        /// </summary>
        protected virtual void Hook1() { }

        /// <summary>
        /// Hook 2.
        /// </summary>
        protected virtual void Hook2() { }
    }
}