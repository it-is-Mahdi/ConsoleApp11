namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class ValueTypeForTest2<T> where T : struct
    {
        private List<T> valueList;

        public ValueTypeForTest2()
        {
            valueList = new List<T>();
        }

        public void AddItem(T item)
        {
            valueList.Add(item);
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < valueList.Count)
            {
                return valueList[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }

        public IEnumerable<T> GetSortedDescending()
        {
            return valueList.OrderByDescending(x => x);
        }
    }
}