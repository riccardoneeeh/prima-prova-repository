
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_TPSIT

class Program
{
    static void Main(string[] args)
    {
        // Istanza della classe Veicolo
        Veicolo auto = new Veicolo("Fiat", "Panda", 2020, "Rosso");
        Console.WriteLine("Informazioni sull'auto:");
        auto.Descrivi();

        Console.WriteLine();

        // Istanza della classe Moto
        Moto moto = new Moto("Ducati", "Monster", 2022, "Nero", 937, false);
        Console.WriteLine("Informazioni sulla moto:");
        moto.Descrivi();

        Console.WriteLine();

        // Esempio di polimorfismo
        Veicolo[] veicoli = new Veicolo[] { auto, moto };
        Console.WriteLine("Descrizione di tutti i veicoli:");
        foreach (var v in veicoli)
        {
            v.Descrivi(); // Chiama il metodo base, anche per Moto
        }
    }
}

