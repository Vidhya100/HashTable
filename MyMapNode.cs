using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDemo
{
    public class MyMapNode<K,V>
    {
        public LinkedList<KeyValue<K, V>>[] item;
        public int size;
        public MyMapNode(int size)
        {
            this.size = size;
            this.item = new LinkedList<KeyValue<K, V>>[size];
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K,V>> linkedlist = GetLinkedlist(position);
            foreach(KeyValue<K,V> item in linkedlist)
            {
                if(item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedlist(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
           
        }
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public LinkedList<KeyValue<K, V>> GetLinkedlist(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                item[position] = linkedList;
            }
            return linkedList;
        }


    }
    public struct KeyValue<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }
    }
}

