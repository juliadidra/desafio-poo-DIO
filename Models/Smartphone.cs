namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Imei { get; set; }
        public string Modelo { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria;

            if (!ValidarNumeroTelefone(numero)) 
            {
                throw new Exception("Número de telefone inválido.");
            }

            if(memoria <= 0){
                throw new Exception("Memoria inválida.");
            }
        }

        public void Ligar()
        {
            Console.WriteLine($"{Modelo}: Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo}: Recebendo ligação...");
        }

        public bool ValidarNumeroTelefone(string numero)
        {
            return !string.IsNullOrEmpty(numero) && numero.Length == 11; // DDD + 9 + numero(8 digitos)
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}