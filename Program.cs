using System;

namespace KASDLab21
{
    internal class Program
    {
        static void Main()
        {
            MyTreeMap<int, int> treeMap = new MyTreeMap<int, int>();

            treeMap.Put(6, 6);
            treeMap.Put(1, 1);
            treeMap.Put(8, 8);
            treeMap.Put(11, 11);
            treeMap.Put(13, 13);
            treeMap.Put(17, 17);
            treeMap.Put(15, 15);
            treeMap.Put(25, 25);
            treeMap.Put(22, 22);
            treeMap.Put(27, 27);
            Console.WriteLine("Все пары ключ-значение:");
            foreach (var entry in treeMap.EntrySet())
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }

            Console.WriteLine($"ContainsValue(15): {treeMap.ContainsValue(15)}");

            Console.WriteLine($"Get(22): {treeMap.Get(22)}");

            Console.WriteLine($"IsEmpty(): { treeMap.IsEmpty()}");

            Console.WriteLine($"Remove(27): {treeMap.Remove(27)}" );

            Console.WriteLine($"Size(): {treeMap.Size()}");

            Console.WriteLine($"FirstKey(): { treeMap.FirstKey()}");

            Console.WriteLine($"LastKey(): { treeMap.LastKey()}");

            MyTreeMap<int, int> subMap = treeMap.SubMap(8, 15);

            Console.WriteLine("Пары клю-значение, у которых ключ >8 и <15:");
            foreach (var entry in subMap.EntrySet())
            {
                Console.WriteLine($"SubMap(8, 15) Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine("LowerEntry(15): {0}", treeMap.LowerEntry(15));

            Console.WriteLine("FloorEntry(15): {0}", treeMap.FloorEntry(15));

            Console.WriteLine("HigherEntry(15): {0}", treeMap.HigherEntry(15));

            Console.WriteLine("CeilingEntry(15): {0}", treeMap.CeilingEntry(15));

            Console.WriteLine("FirstEntry(): {0}", treeMap.FirstEntry());

            Console.WriteLine("LastEntry(): {0}", treeMap.LastEntry());

            Console.ReadKey();
        }
    }
}
