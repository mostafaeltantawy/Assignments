using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignADV03
{


    internal class ImplementedList<T>
    {
        private List<T> _list;

        public ImplementedList(List<T> list)
        {
            if (list is not null)
            {
                _list = list;
            }
            else
            {
                throw new ArgumentNullException("list");
            }
        }


        public void Add(T item)
        {

            _list.Add(item);

        }

        public T? Find(Predicate<T> FindConditionFucntion)

        {
            if (FindConditionFucntion == null)
            {
                throw new NullReferenceException("FindConditionFucntion shouldn't be null");
            }
            foreach (var item in _list)
            {
                if (FindConditionFucntion(item)) return item;
            }
            return default;

        }

        public List<T> FindAll(Predicate<T> FindConditionFucntion)
        {
            if (FindConditionFucntion == null)
            {
                throw new NullReferenceException("FindConditionFucntion shouldn't be null");
            }
            List<T> result = new List<T>();
            foreach (var item in _list)
            {
                if (FindConditionFucntion(item))
                {
                    result.Add(item);
                }
            }
            return result;

        }

        public int FindIndex(int startIndex, int count, Predicate<T> FindConditionFucntion)
        {
            if (startIndex > _list.Count)
            {
                throw new IndexOutOfRangeException("Start Index");
            }

            if (count < 0 || startIndex > _list.Count - count)
            {
                throw new IndexOutOfRangeException("Count");
            }

            if (FindConditionFucntion == null)
            {
                throw new NullReferenceException("FindConditionFucntion shouldn't be null");
            }

            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (FindConditionFucntion(_list[i])) return i;
            }
            return -1;
        }
        public int FindIndex(Predicate<T> FindConditionFucntion)
       => FindIndex(0, _list.Count, FindConditionFucntion);

        public int FindIndex(int startIndex, Predicate<T> match)
           => FindIndex(startIndex, _list.Count - startIndex, match);

        public int FindLast(Predicate<T> FindConditionFucntion)
        {
            for (int i = _list.Count - 1; i >= 0; i--)
            {
                if (FindConditionFucntion(_list[i])) return i;
            }
            return default;
        }

        public int FindLastIndex(int startIndex, int count, Predicate<T> FindConditionFucntion)
        {
            if (startIndex > _list.Count)
            {
                throw new IndexOutOfRangeException("Start Index");
            }

            if (count < 0 || startIndex > _list.Count - count)
            {
                throw new IndexOutOfRangeException("Count");
            }

            if (FindConditionFucntion == null)
            {
                throw new NullReferenceException("FindConditionFucntion shouldn't be null");
            }
            int endIndex = startIndex - count;
            for (int i = startIndex; i > endIndex; i--)
            {
                if (FindConditionFucntion(_list[i]))
                {
                    return i;
                }
            }
            return -1;

        }

        public int FindLastIndex(Predicate<T> FindConditionFucntion)
           => FindLastIndex(_list.Count - 1, _list.Count, FindConditionFucntion);

        public int FindLastIndex(int startIndex, Predicate<T> FindConditionFucntion)
            => FindLastIndex(startIndex, startIndex + 1, FindConditionFucntion);

        public void ForEach(Action<T> ActionConditionFucntion)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                ActionConditionFucntion(_list[i]); 
               
            }
        }

        public bool TrueForAll(Predicate<T> FindConditionFucntion)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (!FindConditionFucntion(_list[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
