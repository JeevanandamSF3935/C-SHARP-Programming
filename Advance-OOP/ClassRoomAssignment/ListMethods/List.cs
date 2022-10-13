using System;
namespace ListMethods;
public partial class List<Type>
{
    Type[] Array{ get; set; }
    private int _count;
    private int _capacity;
    public int Count { get{return _count;} }
    public int Capacity { get{return _capacity;} }

    public Type this[int i]{
        get{return Array[i];}
        set{Array[i] = value;}
    }

    public List(){
        _count = 0;
        _capacity = 4;
        Array = new Type[_capacity];
    }

    public List(int size){
        _count = 0;
        _capacity = size;
        Array = new Type[_capacity];
    }

    public void AddElement(Type a){
        if(_capacity == _count){
            Grow();
        }
        Array[_count] = a;
        _count++;
    }

    public void Grow(){
        _capacity = _capacity * 2;
        Type[] temp = new Type[_capacity];
        for(int itreator = 0;itreator < _capacity/2;itreator++){
            temp[itreator] = Array[itreator];
        }
        Array = temp;
    }

}