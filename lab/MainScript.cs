// ------------------------------- Variant 3.2 ------------------------------- // 


using System;
using System.Numerics;

namespace Lab
{
    class MainScript
    {
        static void Main()
        {
            V3MainCollection mainCollection = new V3MainCollection();
            mainCollection.DataChanged += DataChangesCollector;
            mainCollection.AddDefaults();
            V3DataCollection collection1 = new V3DataCollection("test1.txt");
            mainCollection.Add(collection1);

            //Console.WriteLine(mainCollection.ToString("F3"));

            mainCollection[2].Info = "--- CHANGED INFO ---";
            mainCollection[4].Time = DateTime.Now;
            mainCollection[1] = new V3DataCollection("test2.txt");

            V3Data temp = mainCollection[3];
            mainCollection.Remove(3);
            temp.Info = "REMOVED OBJECT";                            // Это изменение не вызывает событие

            //Console.WriteLine(mainCollection.ToString("F3"));
        }

        static void DataChangesCollector(object sender, DataChangedEventArgs args)
        {
            Console.WriteLine($"{args.Type}: {args.Info}");
        }

        static void MainCollectionNearest(V3MainCollection mainCollection, Vector2 point, string number)
        {
            Console.WriteLine($"{number} point: {point}");
            foreach (V3Data item in mainCollection)
            {
                foreach (Vector2 coord in item.Nearest(point))
                {
                    Console.Write(coord + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
