class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> Flower = new CircularLinkedList<char>();
        Console.WriteLine("1.J = Jasmine");
        Console.WriteLine("2.G = Amaranth");
        Console.WriteLine("3.O = Orchid");
        Console.WriteLine("4.R = Rose");
        Console.WriteLine("=========================");
        while(true)
        {
            
            Flower.Add(char.Parse(Console.ReadLine()));
            int range = Flower.GetLength() - 1;
            if(Flower.Get(Flower.GetLength()-1) != 'J' && Flower.Get(Flower.GetLength()-1) != 'G' 
            && Flower.Get(Flower.GetLength()-1) != 'O' && Flower.Get(Flower.GetLength()-1) != 'R')
            {
                Flower.Remove(Flower.GetLength()-1);

                for (int i =0 ;i<Flower.GetLength(); i++)
                {
                Console.Write(Flower.Get(i));
                }
                break;
            }
            else if (Flower.Get(range) == 'R')
            {
                    if (Flower.Get(range-1)==Flower.Get(0))
                    {
                            Console.WriteLine("Invalid pattern");
                            Flower.Remove(range);
                    }
            }
            else if (Flower.GetLength() <= 2)
            {
                if (Flower.Get(range) == 'R')
                {
                    if(Flower.Get(0) == Flower.Get(range-1))
                    {
                        Console.WriteLine("Invalid pattern");
                        Flower.Remove(range);
                    }
                    else if(Flower.Get(range -1) == Flower.Get(range) && Flower.Get(range -1) == Flower.Get(range))
                    {
                        Console.WriteLine("Invalid pattern");
                        Flower.Remove(range);
                    }
                }
                else if (Flower.Get(range - 1) == 'R')
                {
                    if (Flower.Get(range) == Flower.Get(range - 2))
                    {
                    Console.WriteLine("Invalid pattern");
                    Flower.Remove(range);
                    }
                }
            }
            else if(Flower.GetLength() >= 3)
            {
                if (Flower.Get(range) == 'R')
                {
                    if(Flower.Get(range -1) == Flower.Get(range))
                    {
                        Console.WriteLine("Invalid pattern");
                        Flower.Remove(range);
                    }
                }
                else if (Flower.Get(range - 1) == 'R')
                {
                    if (Flower.Get(range) == Flower.Get(range - 2))
                    {
                    Console.WriteLine("Invalid pattern");
                    Flower.Remove(range);
                    }
                }
                if(Flower.Get(range) == 'G')
                {
                    if(Flower.Get(range) == Flower.Get(0) 
                    && Flower.Get(range) == Flower.Get(1) 
                    && Flower.Get(range) == Flower.Get(2))
                    {
                        Console.WriteLine("Invalid pattern");
                        Flower.Remove(range);
                    }
                    else if (Flower.Get(range) == Flower.Get(range -1) 
                    && Flower.Get(range) == Flower.Get(range -2) 
                    && Flower.Get(range) == Flower.Get(range -3)){
                        Console.WriteLine("Invalid pattern");
                        Flower.Remove(range);
                    }
                    else if (Flower.Get(range) == Flower.Get(range -1) 
                    && Flower.Get(range) == Flower.Get(range -2) 
                    && Flower.Get(range) == Flower.Get(0)){
                        Console.WriteLine("Invalid pattern");
                        Flower.Remove(range);
                    }
                    else if (Flower.Get(range) == Flower.Get(1) 
                    && Flower.Get(range) == Flower.Get(0) 
                    && Flower.Get(range) == Flower.Get(range -1))
                    {
                        Console.WriteLine("Invalid pattern");
                        Flower.Remove(range);
                    }
                    else if (Flower.Get(range - 1) == 'R'){
                        if (Flower.Get(range) == Flower.Get(range - 2))
                        {
                            Console.WriteLine("Invalid pattern");
                            Flower.Remove(range);
                        }
                    }
                }
            }
        }
    }
}