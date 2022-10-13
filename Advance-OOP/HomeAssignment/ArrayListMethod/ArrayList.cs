using System;
namespace ArrayListMethod;
public partial class ArrayList
{
    private int _count;
    private int _capacity;
    private dynamic[] Array{ get; set; }
    public int Count { get{return _count;} }
    public int Capacity { get{return _capacity;} }

    public dynamic this[int i]{
        get{return Array[i];}
        set{Array[i] = value;}
    }
    public ArrayList(){
        _capacity = 4;
        _count = 0;
        Array = new dynamic[_capacity];
    }

    public ArrayList(int data){
        _capacity = data;
        _count = 0;
        Array = new dynamic[_capacity];
    }
    

    public void Add(dynamic data){
        if(_capacity == _count){
            Grow();
            Array[_count] = data;
            _count++;
        }
        else{
            Array[_count] = data;
            _count++;
        }
    }
    public void Grow(){
        _capacity *= 2;
        dynamic[] temp = new dynamic[_capacity];
        for(int i=0;i<_count;i++){
            temp[i] = Array[i];
        }
        Array = temp;
    }

    public void Insert(int index,dynamic data){
        dynamic[] temp = new dynamic[_count+1];
        for(int i=0;i<=_count;i++){
            if(i < index){
                temp[i] = Array[i];
            }
            else if(i == index){
                temp[i] = data;
            }
            else if(i > index){
                temp[i] = Array[i-1];
            }
        }
        _count++;
        Array = temp;
    }

    public void Remove(dynamic data){
        int j = 0;
        bool check = false;
        for(int i = 0;i < _count;i++){
            if(Array[i].Equals(data)){
                Array[i] = Array[i+1];
                j = i;
                check = true;
            }
            if(i > j){
                Array[i] = Array[i+1];
            }
        }
        if(!check){
            System.Console.WriteLine("Element Not Found");
        }
        _count--;
    }

    public void RemoveAt(int index){
        for(int i = 0; i < _count;i++){
            if(i >= index){
                Array[i] = Array[i+1];
            }
        }
        _count--;
    }

    public int IndexOf(dynamic data){
        int index = 0;
        bool check = false;
        for(int i=0;i<_count;i++){
            if(Array[i].Equals(data)){
                check = true;
                index = i;
                break;
            }
            else{
                check = false;
            }
        }
        if(!check){
            System.Console.WriteLine("Element Not Found");
        }
        return index;
    }
}