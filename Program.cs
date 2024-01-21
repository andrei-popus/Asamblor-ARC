class Program
{
    static void Main()
    {
        //ex1();


        static void ex1()
        {
            Console.WriteLine("Introduceți codul sursă în limbaj de asamblare ARC:");
            string codSursa = Console.ReadLine();

            // Procesăm codul sursă și generăm codul mașină
            string codMasina = Asambleaza(codSursa);

            // Salvăm codul mașină într-un fișier
            File.WriteAllText("cod_masina.hex", codMasina);

            Console.WriteLine("Asamblare completă. Codul mașină a fost salvat în fișierul 'cod_masina.hex'.");
        }

        static string Asambleaza(string codSursa)
        {
            // Implementați procesul de asamblare aici
            // Aceasta poate implica parsarea codului sursă, generarea instrucțiunilor mașină, etc.

            // În această implementare simplificată, doar afișăm codul sursă pentru exemplificare.
            Console.WriteLine("Codul sursă introdus:");
            Console.WriteLine(codSursa);

            // Simulăm generarea unui cod mașină
            return "03004000\n0A000000\n";
        }

    }
}

