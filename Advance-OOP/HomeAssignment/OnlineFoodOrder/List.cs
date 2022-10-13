using System;

namespace OnlineFoodOrder;
public partial class List<Type>
{
    private int _count;
    private int _capacity;
    private Type[] Array{ get; set; }
    public int Count { get{return _count;} }
    
    public Type this[int i]{
        get{
            return Array[i];
        }
        set{
            Array[i] = value;
        }
    }

    public List(){
        _count = 0;
        _capacity = 4;
        Array = new Type[_capacity];
    }

    public List(int data){
        _count = 0;
        _capacity = data;
        Array = new Type[_capacity];
    }

    public void Add(Type data){
        if(_capacity == _count){
            Grow();
        }
        Array[_count] = data;
        _count++;
    }

    public void Grow(){
        _capacity *= 2;
        Type[] temp = new Type[_capacity];
        for(int i = 0; i < _count;i++){
            temp[i] = Array[i];
        }
        Array = temp;
    }

    public void AddRange(List<Type> list){
        int j = 0;
        if(_count+list.Count >= _capacity){
            _capacity += list.Count;
            Type[] temp = new Type[_capacity];
            for(int i = 0; i < _count;i++){
                temp[i] = Array[i];
            }
            Array = temp;
        }
        for(int i = _count;i < _count+list.Count;i++){
            Array[i] = list[j];
            j++;
        }
        _count += list.Count;
    }

}