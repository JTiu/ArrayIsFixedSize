using System;
using System.Collections;

class Demo
{
    public static void Main()
    {     //The IsFixedSize property of ArrayList class is used to get a value indicating whether the ArrayList has a fixed size.
          //The following is an example stating the usage of isFixedSize property −
        ArrayList arrList = new ArrayList();

        Console.WriteLine("Adding some numbers:");
        arrList.Add(45);
        arrList.Add(78);
        arrList.Add(45);
        arrList.Add(78);
        arrList.Add(45);
        arrList.Add(78);
        arrList.Add(45);
        arrList.Add(78);
        arrList.Add(45);
        arrList.Add(78);
        arrList.Add(45);
        arrList.Add(78);
        Console.WriteLine(arrList.Count);

        Console.WriteLine("myArrayList.IsFixedSize = " + arrList.IsFixedSize);
        Console.ReadLine();
        //Creates and initializes a new integer array and a new Object array.

    }
}



