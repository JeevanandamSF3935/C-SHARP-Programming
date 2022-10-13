using System;

namespace ListMethods;
public partial class List<Type>
{
    public void Insert(int index,Type data){
        Type[] temp = new Type[_capacity + 1];
        for(int itreator = 0;itreator<_capacity;itreator++ ){
            if(itreator < index){
                temp[itreator] = Array[itreator];
            }
            else if(itreator == index){
                temp[itreator] = data;
            }
            else{
                temp[itreator] = Array[itreator-1];
            }
        }
        temp[_capacity] = Array[_capacity-1];
        Array = temp;
    }

    public void RemoveAt(int index){
        for(int itreator = 0;itreator < _capacity-1;itreator++){
            if(itreator < index){
            }
            else if(itreator >= index){
                Array[itreator] = Array[itreator+1];
            }
        }
        _count--;
    }

    public void Remove(Type value){
        int itreator1 = 0;
        for(int itreator = 0;itreator < _capacity;itreator++){
            if(Array[itreator].Equals(value)){
                Array[itreator] = Array[itreator+1];
                itreator1 = itreator;
            }
            if(itreator > itreator1){
                Array[itreator] = Array[itreator+1];
            }
        }
        _count--;
    }
}