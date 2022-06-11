namespace ProcesareCaractere
{
    public class Program
    {
        static void Main (string[] args)
        {
            new StreamReader(Console.OpenStandardInput());
            string[] fisier = File.ReadAllLines(args[0]);

            ProcesareChar text = new ProcesareChar(fisier);
            int voc=text.NumarVocale();
            Console.WriteLine("In fisier sunt {0} caractere, {1} consoane, {2} vocale si {3} linii", 
                text.NumarCaractere(), text.NumarConsoane()-voc, voc, text.NumarLinii());
            Console.ReadKey();
        }
    }
    class ProcesareChar
    {
        private string[] fisier;
        private int nrCaractere = 0;
        private int nrConsoane = 0;
        private int nrLinii = 0;
        private int nrVocale = 0;

        private string vocale = "aeiouAEIOU";

        public ProcesareChar(string[] fisier)
        {
            this.fisier = fisier;
        }
        public int NumarLinii()
        {
            nrLinii = fisier.Length;
            return nrLinii;

        }
        public int NumarCaractere()
        {
            foreach (string line in fisier)
            {
                nrCaractere += line.Length;
            }

            return nrCaractere;
        }
        public int NumarVocale()
        {
            foreach (string line in fisier)
            {
                for (int i = 0; i < line.Length; i++)
                    for (int j = 0; j < vocale.Length; j++)
                        if (line[i] == vocale[j])
                            nrVocale++;
            }
            return nrVocale;
        }
        public int NumarConsoane()
        {
            foreach (string line in fisier)
            {

                for (int i = 0; i < line.Length; i++)
                {
                    char x = line[i];
                    if (Char.IsLetter(x))
                        nrConsoane++;
                }
            }
            return nrConsoane;
        }
    }
}