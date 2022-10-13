using System;
namespace StackMethods;
    class Stack<Type>
    {
        private Type[] Array{get; set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}

        public Stack(){
            _count = 0;
            _capacity = 4;
            Array = new Type[_capacity];
        }
        public Stack(int value){
            _count = 0;
            _capacity = value;
            Array = new Type[_capacity];
        }

        public void Push(Type value){
            if(_count == _capacity){
                Grow();
            }
            Array[_count] = value;
            _count++;
        }

        public void Grow(){
            _capacity = 2 * _capacity;
            Type[] temp = new Type[_capacity];
            for(int i = 0; i < _count;i++){
                temp[i] = Array[i];
            }
            Array = temp;
        }

        public Type Pop(){
            Type value = default(Type);
            if(_count < 0){
                System.Console.WriteLine("Empty Stack");
            }
            else{
                value = Array[_count];             
                _count--;
            }
            return value;
        }

        public bool Contains(Type value){
            bool check = true;
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

        public Type Peak(){
            Type value = default(Type);
            if(_count < 0){
                System.Console.WriteLine("Empty Stack");
            }
            else if(_count >= 0){
                value = Array[_count];
            }
            return value;
        }

    }