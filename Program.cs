//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091,
//mentre codice 123445567 resta come è)

Prodotto prod = new Prodotto();
prod.Nome = "Borsa";
prod.Descrizione = "Borsa di vera pelle";
prod.Prezzo = 80.30;

prod.Iva = 22;
prod.Stampa();

Prodotto prod2 = new Prodotto();
prod2.Nome = "Occhiali";
prod2.Descrizione = "Da vista";
prod2.Prezzo = 330.99;

prod2.Iva = 18;
prod2.Stampa();

public class Prodotto
{
    public int Codice { get; }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public double Iva { get; set; }

    public Prodotto()
    {
        Codice = new Random().Next(1, 999);
        
    }

    //public int GetCodice()
    //{
    //    return codice;
    //}

    //public string GetNome()
    //{
    //    return nome;
    //}

    //public string SetNome(string nome)
    //{
    //    return this.nome = nome;
    //}

    //public string GetDescrizione()
    //{
    //    return descrizione;
    //}

    //public string SetDescrizione(string descrizione)
    //{
    //    return this.descrizione  = descrizione;
    //}
    //public double GetPrezzo()
    //{
    //    return prezzo;
    //}

    //public double SetPrezzo(double prezzo)
    //{
    //    return this.prezzo = prezzo;
    //}
    //public double GetIva()
    //{
    //    return iva;
    //}
    //public void SetIva(double iva)
    //{
    //    this.iva = iva;
    // }

    public string fullName()
    {
        return Codice + Nome;
    }
    public double GetPrezzoConIva()
    {
        return  (Prezzo / 100 * Iva) + Prezzo;
    }
    public string codiceFinito()
    {
        string codice = Convert.ToString(Codice);
        for(int i = 0; codice.Length <8; i++)
        {
            codice = '0' + codice;
        }
        
        return codice;
    }

    public void Stampa()
    {

        Console.WriteLine("nome:" + Nome );
        Console.WriteLine("codice:" + Codice);
        Console.WriteLine("descrizione:" + Descrizione);
        Console.WriteLine("prezzo:" + Prezzo);
        Console.WriteLine("iva:" + Iva);
        Console.WriteLine("iva+prezzo:" + GetPrezzoConIva());

        Console.WriteLine("nome concatenato:" + fullName());
        Console.WriteLine("codice pad left:" + codiceFinito());

    }
}

