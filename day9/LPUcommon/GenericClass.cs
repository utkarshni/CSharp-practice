using System;
using System.Collections.Generic;
using System.Text;

namespace LPU_Common
{ ///<summary>costum generic class 
  ///</summary>
    public class GenericClass<T> // t denotes that this is a eneric class
    {
        ///<summary>costum generic method, generic method can only be created in generic class
        ///</summary>
        ///<param name="obj1"></param>
        ///  ///<param name="obj2"></param>
        public void SwapMe(T obj1 , T obj2)
        {
            T temp;
            temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
    }
}
