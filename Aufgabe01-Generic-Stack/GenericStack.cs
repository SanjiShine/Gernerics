using System;
using System.Xml.Linq;
using System.Collections;

namespace Aufgabe01_Generic_Stack
{
	public class GenericStack<T> : IEnumerable<T> where T:IComparable<T>  // IEnumberable -> Iterator-Schnittstelle für generische Datenstrukturen /" where" ist der Schlüsselwort (Constraint)
    {
		public StackItem head;

		public class StackItem
		{
			public T Value { get; set; }
			public StackItem Successor { get; set; }

			public StackItem(T value)
			{
				this.Value = value;
			}
		}
		
		public void Push(T value)
			{
                StackItem newStackItem = new StackItem(value);
                newStackItem.Successor = head;
                head = newStackItem;
            }

		public bool IsEmpty()
			{
				return head == null;
			}

		public T Pop()
		{
			if (IsEmpty())
			{
				throw new Exception("Der Stack ist leer!");
			}
			else
			{
				T ret = head.Value; // speicher die Value bevor die Entfernung 
				head = head.Successor; // Entfernen
				return ret; // return den Wert
			}
		}
		public bool Contains(T value)
			{
                StackItem current = head;
                while (current != null)
                {
                    if (value.CompareTo(current.Value) == 0) return true;
                    current = current.Successor;
                }
                return false;
            }

		public IEnumerator<T> GetEnumerator()
			{
				StackItem start = head;
				while(start != null)
				{
					yield return start.Value;
					start = start.Successor;
				}
            }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}

