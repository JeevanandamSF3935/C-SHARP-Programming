using System;
namespace DictionaryMethod;
public class KeyValue<TKey,TValue>
{
    public TKey Key{ get; set; }
    public TValue Value{ get; set; }
}