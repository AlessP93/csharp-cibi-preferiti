// See https://aka.ms/new-console-template for more information

//creo un array 
//string[] food = { "pizza", "lasagna", "gelato", "tiramisù" , "carne", "patatine"};

//lunghezza array 6
//int arraylength = food.Length;

//System.Console.WriteLine(arraylength);

//cibi preferiti in oridine 
//var first = food[1]; //lasagna
//var middle1 = food[2]; //gelato BONUS
//var middle2 = food[3]; //tiramisu BONUS
//var last = food[4]; //carne

//for (int i = 0; i < food.Length; i++)

//System.Console.WriteLine(food[i]);
//System.Console.WriteLine(first);
//System.Console.WriteLine(middle1); 
//System.Console.WriteLine(middle2);
//System.Console.WriteLine(last);


//ESERCIZIO CORRETTO

//lista dei cibi 
string[] foods = { "pizza", "lasagna", "gelato", "tiramisù", "carne", "patatine" };

//stampo la lunghezza dell array
Console.WriteLine("La classifica è lunga " + foods.Length);
Console.WriteLine();

Console.WriteLine("Classifica:");

for (int i = 0; i < foods.Length; i++)
{
    Console.Write(i + 1 + " - ");
    Console.WriteLine(foods[i]);
}

//fine classifica

Console.WriteLine("Cibo preferito: " + foods[0]);
Console.WriteLine("Cibo preferito ma non troppo: " + foods[foods.Length-1]);

//creo la mediana dividendo
int mediana = foods.Length / 2;

//creo un if per i pari e i dispari 
if (foods.Length % 2 == 0)
{
    //pari
    string mediana1 = foods[mediana]; //pari
    string mediana2 = foods[mediana - 1]; //dispari
    Console.WriteLine("Ci sono due mediane {0},{1}", mediana2, mediana1);
}
else
{
    //dispari
    string mediana1 = foods[(foods.Length - 1)/2]; //dispari
    Console.WriteLine("C'è una mediana {0}", mediana1);
}

// A                DISPARI 
// A B              PARI      
// A B C            DISPARI  
// A B C D          PARI
// A B C D E        DISPARI 
// A B C D E F      Pri