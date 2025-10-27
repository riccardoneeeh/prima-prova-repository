
using system;
public class Veicolo
{
    // Proprietà
    public string Marca { get; set; }
    public string Modello { get; set; }
    public int Anno { get; set; }
    public string Colore { get; set; }

    // Costruttore
    public Veicolo(string marca, string modello, int anno, string colore)
    {
        Marca = marca;
        Modello = modello;
        Anno = anno;
        Colore = colore;
    }

    // Metodo per descrivere il veicolo
    public void Descrivi()
    {
        Console.WriteLine($"Veicolo: {Marca} {Modello}, Anno: {Anno}, Colore: {Colore}");
    }
}

