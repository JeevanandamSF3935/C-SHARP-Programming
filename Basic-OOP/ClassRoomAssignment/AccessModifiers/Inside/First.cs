using Outside;

namespace Inside
{
    public class First:Third
    {
        public int PublicNumber = 10;
        private int PrivateNumber = 20;
        public int PrivateProperty { get{return PrivateNumber;} }
        public int PrivateMethod(){
            return PrivateNumber;
        }
        internal int InternalNumber = 30;
        protected int ProtectedNumber = 40;
        public int ProtectedMethod(){
            return ProtectedNumber;
        }
        public int ProtectedInternalProperty { get{return ProtectedInternalNumber;} }
        public int ProtectedInternalMethod(){
            return ProtectedInternalNumber;
        }
    }
}