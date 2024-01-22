using DesafioPOO.Models;



public class Program {
    public static void Main(){
        Iphone i1 = new("81985446184", "1008524c5xx", "iphone 12", 128);
        i1.Ligar();
        i1.ReceberLigacao();
        i1.InstalarAplicativo("whatsapp");

        Nokia a1 = new("81985446576", "1554c558x4v", "Nokia a1", 64);
        a1.Ligar();
        a1.ReceberLigacao();
        a1.InstalarAplicativo("telegram");

    }
}
