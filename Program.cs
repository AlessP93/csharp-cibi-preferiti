// See https://aka.ms/new-console-template for more information

//creo un array 
string[] food = { "pizza", "lasagna", "gelato", "tiramisù" , "carne", "patatine"};

//lunghezza array 4
int arraylength = food.Length;

System.Console.WriteLine(arraylength);

//cibi preferiti in oridine 
var first = food[1]; //lasagna
var middle1 = food[2]; //gelato
var middle2 = food[3]; //tiramisu
var last = food[4]; //carne

for (int i = 0; i < food.Length; i++)

System.Console.WriteLine(food[i]);
System.Console.WriteLine(first);
System.Console.WriteLine(middle1);
System.Console.WriteLine(middle2);
System.Console.WriteLine(last);


//stringArray.First() and stringArray.Last()