using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueClass<T> : IEnumerable
    {

        private List<T> queue_list = new List<T>();
        private T dequeue_element;
        private T peek_element;
        private int index = -1;

        public void Enqueue(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }
            queue_list.Add(element);

        }
        public T Dequeue()
        {
            dequeue_element = queue_list.FirstOrDefault();
            if (dequeue_element == null)
            {
                throw new NullReferenceException("the queue is empty.");
            }
            queue_list.Remove(dequeue_element);
            return dequeue_element;
        }
        public T Peek()
        {
            peek_element = queue_list.FirstOrDefault();
            if (peek_element == null)
            {
                throw new NullReferenceException("the queue is empty.");
            }
            return peek_element;
        }
        public IEnumerator GetEnumerator()
        {
            return queue_list.GetEnumerator();
        }


        public bool MoveNext()
        {

            return index++ < queue_list.Count;

        }

        public void Reset()
        {
            index = -1;
        }

        public T Current
        {
            get
            {
                try
                {
                    return queue_list[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}



 