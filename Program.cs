using static System.Console;
using ProjetoRPG.src.Entities;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 1, "Knight");
            Wizard jenica = new Wizard("Jenica", 10, "White Wizard");
            Ninja musashi = new Ninja("Musashi", 10, "Ninja");
            
            WriteLine(arus);
            WriteLine(jenica);
            WriteLine(musashi);
            WriteLine();
            WriteLine(arus.Attack());
            WriteLine(jenica.Attack(20));
            WriteLine(musashi.Attack(22, 30));
        }
    }
}