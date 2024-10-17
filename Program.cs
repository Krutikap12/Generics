namespace Tuple_to_dictionary_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int,string,int> tuple = new Tuple<int,string,int>(22,"hello",65);
            Console.WriteLine("Element 1:" + tuple.Item1);
            Console.WriteLine("Element 2:" + tuple.Item2);
            Console.WriteLine("Element 3:" + tuple.Item3);

            Dictionary<int,string> dictionary = new Dictionary<int,string>();

            dictionary.Add(tuple.Item1, tuple.Item2);
            dictionary.Add(tuple.Item1,tuple.Item2);
            foreach(var i in dictionary)
            {
                Console.WriteLine($"{i.Key}:{i.Value}");
            }

        }
    }
}
