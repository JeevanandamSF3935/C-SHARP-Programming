using System;
namespace DictionaryMethod;
public partial class Dictionary<TKey,TValue>
{


    private int _count = 0;
    private int _capacity = 0;
    private static TValue _value;
    private KeyValue<TKey,TValue>[] Array {get;set;}
    public int Count{get{return _count;}}
    public int Capacity{get{return _capacity;}}


    public TValue this[TKey key]{
        get{
            TValue output = default(TValue);
            int index = 0;
            bool temp = LinearSearch(key, out index);
            if(temp){
                output = Array[index].Value;
            }
            else{
                System.Console.WriteLine("Invalid Key");
            }
            return output;
        }
        set{
            int position = 0;
            bool temp = LinearSearch(key,out position);
            if(temp){
                Array[position].Value = value;
            }
            else{
                System.Console.WriteLine("Invalid Key");
            }
        }
    }

    public Dictionary(){
        _count = 0;
        _capacity = 4;
        Array = new KeyValue<TKey,TValue>[_capacity];
    }

    public Dictionary(int data){
        _count = 0;
        _capacity = data;
        Array = new KeyValue<TKey,TValue>[_capacity];
    }

    public void Add(TKey key, TValue value){
        bool check = LinearSearch(key,out int i);
        if(_capacity == _count){
            Grow();
        }
        if(!check){
            KeyValue<TKey,TValue> ValueKey = new KeyValue<TKey, TValue>();
            ValueKey.Key = key;
            ValueKey.Value = value;
            Array[_count] = ValueKey;
            _count++;
        }
        else{
            System.Console.WriteLine("Key Should be Unique\nEntered key is already Exists!");
        }
        
    }

    public void Grow(){
        _capacity = _capacity * 2;
        KeyValue<TKey,TValue>[] temp = new KeyValue<TKey,TValue>[_capacity];
        for(int i = 0; i<_count;i++){
            temp[i] = Array[i];
        }
        Array = temp;
    }

    public bool ContainsKey(TKey data){
        bool check = LinearSearch(data,out int i);
        return check;
    }

    public bool ContainsValue(TValue data){
        bool check = true;
        for(int i = 0; i < _count;i++){
            if(Array[i].Value.Equals(data)){
                check = true;
                break;
            }
            else{
                check = false;
            }
        }
        return check;
    }

    public bool TryGetValue(TKey key,out TValue data){
        bool check = true;
        data = default(TValue);
        for(int i = 0; i < _count;i++){
            if(Array[i].Key.Equals(key)){
                data = Array[i].Value;
                check = true;
            }
            else{
                check = false;
            }
        }
        if(!check){
            System.Console.WriteLine("Key Not Found!");
        }
        return check;
    }


    public TValue GetValue(TKey key){
        bool check = true;
        TValue temp1 = default(TValue);
        for(int i = 0;i < _count;i++){
            if(Array[i].Key.Equals(key)){
                temp1 = Array[i].Value;
                break;
            }
            else{
                check = false;
            }
        }
        if(!check){
            System.Console.WriteLine("Key Not Found!");
        }
        return temp1;
    }

    public void Remove(TKey key){
        int j = 0;
        bool check = LinearSearch(key,out j);
        if(check){
            for(int i = j;i<_count-1;i++){
                Array[i] = Array[i+1];
            }
            _count--;
        }
        else{
            System.Console.WriteLine("Invalid Key");
        }
    }
    public bool LinearSearch(TKey key,out int index){
        bool check = false;
        index = 0;
        for(int i = 0; i < _count;i++){
            if(Array[i].Key.Equals(key)){
                check = true;
                index = i;
                break;
            }
            else{
                check = false;
            }
        }
        return check;
    }

    public KeyValue<TKey,TValue> ElementAt(int index){
        KeyValue<TKey,TValue> temp= null;
        if(index > -1 && index < _count)
        {
            temp = Array[index];
        }
        else
        {
            System.Console.WriteLine("Index Out of Bound");
        }
        return temp;
    }

}