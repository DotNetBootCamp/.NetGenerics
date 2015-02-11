using System.Collections.Generic;

namespace Source
{
    public class GenericList<TListItem>
        where TListItem : class
    {
        private readonly List<TListItem> _cheatingUnderlyingList;

        public GenericList()
        {
            _cheatingUnderlyingList= new List<TListItem>();
        }

        public void Add(TListItem input)
        {
            _cheatingUnderlyingList.Add(input);
        }

        public TListItem Get(int index)
        {
            return _cheatingUnderlyingList[index];
        }

        public void InsertAt(int index, TListItem input)
        {
            _cheatingUnderlyingList.Insert(index, input);
        }

        public void Remove(int index)
        {
            _cheatingUnderlyingList.RemoveAt(index);
        }
    }
}