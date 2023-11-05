namespace Зоопарк
{
using Zoo;
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] Zoo = new Animal[6];

            Zoo[0] = new Tiger("Ричард", "рычит");
            Zoo[1] = new Giraffe("Жора", "жует листву");
            Zoo[2] = new Bear("Медвежонок", "рычит");
            Zoo[3] = new Penguin("Пингвин", "шумит");
            Zoo[4] = new Moose("Лось", "торчит");
            Zoo[5] = new Rabbit("Заяц", "пищит");

            foreach (Animal animal in Zoo)
            {
                if (animal != null)
                {
                    animal.MakeSound();
                }
            }
        }
    }
}