namespace Set3Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector: ");
            string input = Console.ReadLine();
            uint[] v = Array.ConvertAll(input.Split(" "), uint.Parse);

            uint valoareCMMDC = CalculCMMDC(v);
            Console.WriteLine("CMMDC al vectorului este " + valoareCMMDC);
        }

        static uint CMMDC(uint a, uint b)
        {
            while(b != 0)
            {
                uint temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static uint CalculCMMDC(uint[] v)
        {
            uint rezultat = v[0];

            for(int i = 1; i < v.Length; i++)
            {
                rezultat = CMMDC(rezultat, v[i]);
                if(rezultat == 1)
                {
                    break;
                }
            }
            return rezultat;
        }
    }
}
