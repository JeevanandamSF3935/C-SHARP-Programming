using System;

namespace OnlineMedicalStore;
public partial class List<Type>
{
    private Type[] Array{get;set;}
    private int _count;
    private int _capacity;
    public int Count{ get{return _count;} }

    public Type this[int i]{
        get{return Array[i];}
        set{Array[i] = value;}
    }

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
    public void Add(Type data){
        if(_capacity == _count){
            Grow();
        }
        else{
            Array[_count] = data;
            _count++;
        }
    }

    public void Grow(){
        _capacity *= 2;
        Type[] temp = new Type[_capacity];
        for(int i = 0; i<_count;i++){
            temp[i] = Array[i];
        }
        Array = temp;
    }
}