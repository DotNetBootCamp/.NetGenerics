using System;
using System.Collections;

namespace Source
{
    public class StringList
    {
        private readonly Hashtable _underlyingDataStructure;
        public int Length { get; private set; }
        public StringList()
        {
            _underlyingDataStructure = new Hashtable();
            Length = 0;
        }

        public void Add(string input)
        {
            _underlyingDataStructure.Add(Length, input);
            Length++;
        }

        public string Get(int index)
        {
            return (string)_underlyingDataStructure[index];
        }

        public void Remove(int index)
        {
            _underlyingDataStructure.Remove(index);
            MoveItemsDownByOneIndex(index);
            Length--;
        }

        private void MoveItemsDownByOneIndex(int startindex)
        {
            for (int i = startindex ; i < _underlyingDataStructure.Count; i++)
            {
                var itemToMoveDown = _underlyingDataStructure[i+1];
                _underlyingDataStructure[i] = itemToMoveDown;
                _underlyingDataStructure.Remove(i+1);
            }
        }
    }
}
