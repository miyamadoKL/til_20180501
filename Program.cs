using System;
using System.Collections.Generic;
using System.Linq;

namespace til_20180501
{
    public class Fibonacci
    {
        public static IEnumerable<long> Enumerate()
        {
            yield return 0;
            yield return 1;
            long[] array = new long[] { 0, 1 };
            while (true)
            {
                var arrayN = array[0] + array[1];
                array[0] = array[1];
                array[1] = arrayN;
                yield return arrayN;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // TakeWhile : 指定した条件が true の場合、残りの要素をスキップする限り、シーケンスから要素を返します。
            var fibonacci = Fibonacci.Enumerate()
                .Select((Value, Key) => new { Key, Value }).TakeWhile(x => x.Key <= 50);
                
            foreach (var f in fibonacci)
            {
                Console.WriteLine($"f({f.Key}) = {f.Value}");
            }
        }
    }
}
