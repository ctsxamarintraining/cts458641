using System;
using System.Collections.Generic;
using System.Collections;

namespace IListDemo
{
	public class Mylist: IList
	{
		private object[] array = new object[8];
		private int count;

		public Mylist ()
		{
			count = 0;
		}

		// IList Members
		public int Add (object value)
		{
			if (count < array.Length) {
				array [count] = value;
				count++;

				return (count - 1);
			} else {
				return -1;
			}
		}

		public void Clear ()
		{
			count = 0;
		}

		public bool Contains (object value)
		{
			bool inList = false;
			for (int i = 0; i < Count; i++) {
				if (array [i] == value) {
					inList = true;
					break;
				}
			}
			return inList;
		}

		public int IndexOf (object value)
		{
			int itemIndex = -1;
			for (int i = 0; i < Count; i++) {
				if (array [i] == value) {
					itemIndex = i;
					break;
				}
			}
			return itemIndex;
		}

		public void Insert (int index, object value)
		{
			if ((count + 1 <= array.Length) && (index < Count) && (index >= 0)) {
				count++;

				for (int i = Count - 1; i > index; i--) {
					array [i] = array [i - 1];
				}
				array [index] = value;
			}
		}

		public bool IsFixedSize {
			get {
				return true;
			}
		}

		public bool IsReadOnly {
			get {
				return false;
			}
		}

		public void Remove (object value)
		{
			RemoveAt (IndexOf (value));
		}

		public void RemoveAt (int index)
		{
			if ((index >= 0) && (index < Count)) {
				for (int i = index; i < Count - 1; i++) {
					array [i] = array [i + 1];
				}
				count--;
			}
		}

		public object this [int index] {
			get {
				return array [index];
			}
			set {
				array [index] = value;
			}
		}

		// ICollection Members

		public void CopyTo (Array array1, int index)
		{
			int j = index;
			for (int i = 0; i < Count; i++) {
				array1.SetValue (array [i], j);
				j++;
			}
		}

		public int Count {
			get {
				return count;
			}
		}

//		public bool IsSynchronized {
//			get {
//				return false;
//			}
//		}

		// Return the current instance since the underlying store is not
		// publicly available.
		public object SyncRoot {
			get {
				return this;
			}
		}

		// IEnumerable Members

		public IEnumerator GetEnumerator ()
		{
			// Refer to the IEnumerator documentation for an example of
			// implementing an enumerator.
			throw new Exception ("The method or operation is not implemented.");
		}

		public void Printarray ()
		{
			Console.WriteLine ("List has a capacity of {0} and currently has {1} elements.", array.Length, count);
			Console.Write ("List array:");
			for (int i = 0; i < Count; i++) {
				Console.Write (" {0}", array [i]);
			}
			Console.WriteLine ();
		}
	}




}