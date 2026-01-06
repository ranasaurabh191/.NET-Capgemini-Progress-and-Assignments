using System;
public class AddGenericClass<T>
{
    T n1;
    T n2;
    T result;
    public AddGenericClass(T n1, T n2)   //generic constructor
    {
        this.n1 = n1;
        this.n2 = n2;
    }
    public T AddAllType(T num1, T num2)  //generic method
    {
        dynamic a = num1;
        dynamic b = num2;
        result = a + b;
        return result;
    }
}