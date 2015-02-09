using System.Collections.Generic;

namespace Source
{
    public class GenericList<T>
        where T : class
    {
        private readonly List<T> _cheatingUnderlyingList;

        public GenericList()
        {
            _cheatingUnderlyingList= new List<T>();
        }

        public void Add(T input)
        {
            _cheatingUnderlyingList.Add(input);
        }

        public T Get(int index)
        {
            return _cheatingUnderlyingList[index];
        }

        public void InsertAt(int index, T input)
        {
            _cheatingUnderlyingList.Insert(index, input);
        }

        public void Remove(int index)
        {
            _cheatingUnderlyingList.RemoveAt(index);
        }
    }
}