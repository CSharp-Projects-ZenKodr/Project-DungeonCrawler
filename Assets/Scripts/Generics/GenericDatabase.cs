using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace CaptainSly.Generics
{
	public class GenericDatabase<T> : ScriptableObject
	{
		public List<T> database = new List<T>();

		public void Add(T item)
		{
			database.Add(item);
		}

		public void Insert(int index, T item)
		{
			database.Insert(index, item);
		}

		public void Remove(T item)
		{
			database.Remove(item);
		}

		public void Remove(int index)
		{
			database.RemoveAt(index);
		}

		public int Count { get { return database.Count; } }

		public T Get(int index)
		{
			return database.ElementAt<T>(index);
		}

		public void Replace(int index, T item)
		{
			database[index] = item;
		}

	}
}