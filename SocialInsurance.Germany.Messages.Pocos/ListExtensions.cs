using System.Collections.Generic;

namespace SocialInsurance.Germany.Messages.Pocos
{
    internal static class ListExtensions
    {
        public static IList<T> Set<T>(this IList<T> list, T newValue)
        {
            if (list == null)
            {
                list = new List<T>();
            }
            else
            {
                list.Clear();
            }

            if (newValue != null)
                list.Add(newValue);
            return list;
        }
    }
}
