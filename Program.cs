// See https://aka.ms/new-console-template for more information

//creo un array 
string[] food = { "pizza", "lasagna", "gelato", "tiramisù" };

var first = food[1]; //lasagna
var middle = food[2]; //gelato
var last = food[3]; //tiramisù

for (int i = 0; i < food.Length; i++)

System.Console.WriteLine(food[i]);
System.Console.WriteLine(first);
System.Console.WriteLine(middle);
System.Console.WriteLine(last);


//stringArray.First() and stringArray.Last()