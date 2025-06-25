using System.Collections;
using System.Security.Cryptography;
//PRACTICAL 1
//ArrayList Studentname = new ArrayList();
//Studentname.Add("Mishri");
//Studentname.Add("Jinkal");
//Studentname.Add("Dharmi");
//Studentname.Add("Utsav");
//Studentname.Add("Krisha");

//Console.WriteLine("Student name after Add()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}


//Studentname.RemoveAt(1);
//Console.WriteLine("\nAfter Remove()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}


//Studentname.RemoveRange(3,1);
//Console.WriteLine("\nAfter Remove range()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}

//Studentname.Clear();
//Console.WriteLine("\nAfter clear()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}




//PRACTICAL 2
//List<string> Studentname= new List<string>();
//Studentname.Add("Mishri");
//Studentname.Add("Jinkal");
//Studentname.Add("Dharmi");
//Studentname.Add("Utsav");
//Studentname.Add("Krisha");

//Console.WriteLine("Student name after Add()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}


//Studentname.RemoveAt(1);
//Console.WriteLine("\nAfter Remove()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}


//Studentname.RemoveRange(3, 1);
//Console.WriteLine("\nAfter Remove range()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}

//Studentname.Clear();
//Console.WriteLine("\nAfter clear()");
//foreach (var i in Studentname)
//{
//    Console.WriteLine(i);
//}






//practical3
// Stack <int> numberStack = new Stack<int>();
// numberStack.Push (1);
// numberStack.Push (2);
// numberStack.Push (3);
// numberStack.Push (4);
// numberStack.Push (5);

// Console.WriteLine ("Stack after push()");
// foreach (int i in numberStack)
// {
//     Console.WriteLine(i);
// }

// int removedItem= numberStack.Pop();
// Console.WriteLine (removedItem);
// Console.WriteLine("stack after pop");
// foreach(int i in numberStack)
// {
//     Console.WriteLine(i);
// }

// int topItem = numberStack.Peek();
// Console.WriteLine (topItem);


//bool exists= numberStack.Contains(2);
//Console.WriteLine ($"does it exist? {2}:{ exists}");


// numberStack.Clear();
// Console.WriteLine("STACK AFTER CLEAR");
// foreach(var i in numberStack)
// {
//     Console.WriteLine(i);
// }






////PRACTICAL 4
//Queue<int> intQueue = new Queue<int>();
//intQueue.Enqueue(0);
//intQueue.Enqueue(1);
//intQueue.Enqueue(2);
//intQueue.Enqueue(3);
//intQueue.Enqueue(4);
//Console.WriteLine("Queue after Enqueue()");
//foreach (var i in intQueue)
//{
//    Console.WriteLine(i);
//}
//intQueue.Dequeue();
//Console.WriteLine("Queue after Dequeue()");
//foreach (var i in intQueue)
//{
//    Console.WriteLine(i);
//}
//intQueue.Peek();
//Console.WriteLine("Queue after peek()");
//foreach (var i in intQueue)
//{
//    Console.WriteLine(i);
//}
//bool contains1 = intQueue.Contains(1);
//Console.WriteLine($"Queue contains '1': {contains1}");

//intQueue.Clear();
//Console.WriteLine("Stack after Clear()");
//foreach (var i in intQueue)
//{
//    Console.WriteLine(i);
//}



//Practical 5
Dictionary<string, int> stuMarks = new Dictionary<string, int>();
stuMarks.Add("Jinkal", 95);
stuMarks.Add("Mishri", 97);
stuMarks.Add("Dharmi", 91);
foreach (var entry in stuMarks)
{
    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
}
stuMarks.Remove("Dharmi");
Console.WriteLine("After Remove:");
foreach (var entry in stuMarks)
{
    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
}
Console.WriteLine();

Console.WriteLine(" Checks if a key exists :");
Console.WriteLine($"Does 'Jinkal' exist? {stuMarks.ContainsKey("Jinkal")}");
Console.WriteLine($"Does 'Dharmi' exist? {stuMarks.ContainsKey("Dharmi")}");
Console.WriteLine();


Console.WriteLine(" Checks if a value exists ");
Console.WriteLine($"Does value 97 exist? {stuMarks.ContainsValue(97)}");
Console.WriteLine($"Does value 40 exist? {stuMarks.ContainsValue(40)}");
Console.WriteLine();

Console.WriteLine(" Removes all key-value pairs.");
stuMarks.Clear();
Console.WriteLine($"Count after clearing: {stuMarks.Count}");
































































































