//Geometria

using Geometria;

Rettangolo rettangolo;

Console.WriteLine("Inserisci la base e successivamente l'altezza: ");
int baseR = int.Parse( Console.ReadLine() );
int altezzaR = int.Parse( Console.ReadLine() );
rettangolo = new Rettangolo(baseR, altezzaR);
//testing tostring
Console.WriteLine(rettangolo.ToString());

//testing Disegno
Console.WriteLine(rettangolo.Disegna());