using System.Collections.Generic;
using System.Linq;


namespace MyUnityKit.KitUtils {
    public delegate T SelectionStrategy<T>(IEnumerable<T> items);
    public static class Registry<T> where T : class{
        static readonly HashSet<T> Items = new HashSet<T>();

        public static bool TryAdd(T item) {
            return item != null && Items.Add(item);
        }
        
        public static bool Remove(T item) {
            return Items.Remove(item);
        }

        public static T GetFirst() {
            return Items.FirstOrDefault();
        }
        
        public static T Get(SelectionStrategy<T> strategy) => strategy(Items);
        
        public static IEnumerable<T> All => Items;
    }
}