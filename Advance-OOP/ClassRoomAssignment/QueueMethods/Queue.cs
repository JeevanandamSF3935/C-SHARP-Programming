using System;
namespace QueueMethods;
class Queue<Type>
{
    private Type[] Array{get; set;}
    private int _count;
    private int _head;
    private int _capacity;
    private int _tail;

    public int Count{get;set;}
    public int Capacity { get{return _capacity;}}

    public Queue(){
        _capacity = 4;
        _head = 0;
        _tail = 0;
        Array = new Type[_capacity];
    }
    public Queue(int value){
        _capacity = value;
        _head = 0;
        _tail = 0;
        Array = new Type[_capacity];
    }

    public void Enqueue(Type value){
        if(_capacity == _tail){
            Grow();
        }
        else{
            Array[_tail] = value;
            _tail++;
            _count++;
        }
    }

    public void Grow(){
        _capacity = _capacity*2;
        Type[] temp = new Type[_capacity];
        for(int i = 0; i < _tail;i++){
            temp[i] = Array[i];
        }
        Array = temp;
    }

    public Type Dequeue(){
        Type value = default(Type);
        if(_head > _tail){
            System.Console.WriteLine("Empty Queue");
        }
        else{
            value = Array[_head];
            _head++;
            _count--;
        }
        return value;
    }
    
    public Type Peak(){
        Type value = default(Type);
        if(_head > _tail){
            System.Console.WriteLine("Empty Queue");
        }
        else{
            value = Array[_head];
        }
        return value;
    }

    public bool Contains(Type value){
        bool check = false;
        for(int i = 0;i < _count;i++){
            if(Array[i].Equals(value)){
                check = true;
                break;
            }
            else{
                check = false;
            }
        }
        return check;
    }

}