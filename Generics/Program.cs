using System;

class Program
{
    //define a generic clas( type parameter 'T')
    class Generics<T>
    { 
        private T myField;

        public Generics(T value)
        {
            myField = value;
        }

        //return the value 
        public T GetMyField()
        {
            return myField;
        }
    }

    static void Main()
    {
        //create an instance with string 
        Generics<string> myStringClass = new Generics<string>("Ka-pi-ba-ra! KAPIRABA KAPIRABA KAPARABA!!!");

        //create an instance wiht int
        Generics<int> myIntClass = new Generics<int>(11052005);

        //call
        Console.WriteLine(myStringClass.GetMyField());
        Console.WriteLine(myIntClass.GetMyField());
    }
}
