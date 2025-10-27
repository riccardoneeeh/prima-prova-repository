
using System;
public class Moto : Veicolo
{
    // Proprietà specifiche della moto
    public bool HaSidecar { get; set; }
    public int Cilindrata { get; set; }

    // Costruttore
    public Moto(string marca, string modello, int anno, string colore, int cilindrata, bool haSidecar)
        : base(marca, modello, anno, colore)
    {
        Cilindrata = cilindrata;
        HaSidecar = haSidecar;
    }

    // Metodo per descrivere la moto
    public new void Descrivi()
    {
        base.Descrivi();
        Console.WriteLine($"Cilindrata: {Cilindrata}cc, Sidecar: {(HaSidecar ? "Sì" : "No")}");
    }
}


