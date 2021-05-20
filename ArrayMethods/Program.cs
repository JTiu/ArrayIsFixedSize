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

        //The Array.Lenth property in C# is used to find the length of the array.
        Array arr = Array.CreateInstance(typeof(String), 3);
        arr.SetValue("Electronics", 0);
        arr.SetValue("Clothing", 1);
        arr.SetValue("Appliances", 2);

        Console.WriteLine("Length: {0}", arr.Length.ToString());

        Console.ReadLine();

        //Creates and initializes a new integer array and a new Object array.

    }
}



