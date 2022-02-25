namespace ProjetoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Ninja()
        {

        }
        public string Attack(int Bonus, int NewLevel){
            if (Bonus > 20)
            {
                return $"{this.Name} atacou com sua katana! Bônus de {Bonus}! Você subiu de nível: Level {NewLevel}!";
            }
            else
            {
                return $"{this.Name} atacou com sua katana! Bônus de {Bonus}!";
            }
        }
    }
}