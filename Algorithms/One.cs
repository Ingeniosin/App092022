using App092022.Utils;

namespace App092022.Algorithms; 

public class One : Algorithm {

    public One() : base("Primero", "Realizar un programa que permita simular un carrusel de cadenas de arte ascii") {
    }

    protected override void Execute() {
        var text = File.ReadAllText(@"D:\Escritorio\Work\UCC\App092022\Algorithms\figures.txt");
        var list = new CircularList<string>();
        var figures = text.Split("?|?");
        list.AddRange(figures);


        var enumerator = list.GetEnumerator();

        while (true) {
            Console.Clear();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            Thread.Sleep(1000);
        }
    }
}