using System;

namespace OnlineGrocery;
public partial class List<Type>
{
    private int _count;
    private int _capacity;
    public Type[] Array{ get; set; }
    public int Count { get{return _count;} }
    public int Capacity { get{return _capacity;} }


    public List(){
        _capacity = 4;
        _count = 0;
        Array = new Type[_capacity];
    }

    public List(int data){
        _capacity = data;
        _count = 0;
        Array = new Type[_capacity];
    }

    public Type this[int i]{
        get{return Array[i];}
        set{Array[i] = value;}
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
        for(int i = 0;i < _count;i++){
            temp[i] = Array[i];
        }
        Array = temp;
    }

    public void AddRange(List<Type> list){
        int j = 0;
        if(_capacity <= (_count+list.Count)){
            _capacity += list.Count;
        }
        for(int i = _count;i < _count+list.Count;i++){
            Array[i] = list[j];
            j++;
        }
        _count += list.Count;
    }
}