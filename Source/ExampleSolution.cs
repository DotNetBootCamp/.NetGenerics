using System;
using System.Collections.Generic;

namespace Source
{
    public class ExampleSolution
    {
        private readonly Queue<string> _stringQueue;
        private readonly Queue<IMediaItemQuery> _mediaItemQuery;
        private readonly Queue<object> _objectQueue;

        public ExampleSolution()
        {
            _stringQueue = new Queue<string>();
            _mediaItemQuery = new Queue<IMediaItemQuery>();
            _objectQueue = new Queue<Object>();
        }

        public void Push<TItemToPush>(TItemToPush item)
            where TItemToPush: class 
        {
            var mediaItemQuery = item as IMediaItemQuery;
            if (mediaItemQuery != null)
            {
                PushIMediaItemQuery(mediaItemQuery);
                return;
            }
            var stringObject = item as string;
            if (stringObject != null)
            {
                PushString(stringObject);
                return;
            }
            PushObject(item);
        }

        public void PushString(string input)
        {
            _stringQueue.Enqueue(input);
        }

        public void PushObject(object theObject)
        {
            _objectQueue.Enqueue(theObject);
        }

        public void PushIMediaItemQuery(IMediaItemQuery item)
        {
            _mediaItemQuery.Enqueue(item);
        }

        public string GetNextStringItem()
        {
            return _stringQueue.Dequeue();
        }

        public IMediaItemQuery GetNextMediaItemItem()
        {
            return _mediaItemQuery.Dequeue();
        }

        public object GetNextObjectItem()
        {
            return _objectQueue.Dequeue();
        }
    }
}
