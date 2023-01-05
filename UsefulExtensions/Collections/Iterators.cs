namespace UsefulExtensions.Collections
{
    public static class Iterators
    {
        /// <summary>
        /// Iterates through the collection and fires the provided action on every element
        /// </summary>
        /// <typeparam name="T">Type that the IEnumerable holds</typeparam>
        /// <param name="collection">The given collection that is being iterated</param>
        /// <param name="action">The Action that will be executed for every element</param>
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }

        /// <summary>
        /// Iterates through the collection and fires the provided action on every element
        /// </summary>
        /// <typeparam name="T">Type that the IList holds</typeparam>
        /// <param name="collection">The given collection that is being iterated</param>
        /// <param name="action">The Action that will be executed for every element</param>
        public static void ForEach<T>(this IList<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }

        /// <summary>
        /// Iterates through the collection and fires the provided action on the element range
        /// </summary>
        /// <typeparam name="T">Type that the IList holds</typeparam>
        /// <param name="collection">The given collection that is being iterated</param>
        /// <param name="action">The Action that will be executed for every element</param>
        /// <param name="firstIndex">Index on which the iteration starts</param>
        /// <param name="lastIndex">Index on which the iteration ends (+1)</param>
        public static void For<T>(this IList<T> collection, Action<T> action, int firstIndex, int lastIndex)
        {
            for (int i = firstIndex; i < lastIndex + 1; i++)
            {
                action(collection[i]);
            }
        }
    }
}
