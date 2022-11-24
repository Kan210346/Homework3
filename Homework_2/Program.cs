class Program
{
    static void Main(string[] args)
    {
        Queue<char> Name_Size=new Queue<char>();

        while (true)
        {
            Console.WriteLine("Please Input Size : ");
        char Size = char.Parse(Console.ReadLine());
        if (Size != 'S'&& Size != 'M'&& Size != 'L'){
            break;
            
        }
        else {
            Name_Size.Push(Size);
        }
        
    }
    CircularLinkedList<int>Name_Input=new  CircularLinkedList<int>();
    while (true){ 
        char X=Name_Size.Pop();
        if (X == 'L'){
            Name_Size.Push('M');
            Name_Size.Push('M');
            Name_Input.Add(1);


        }
        else if (X == 'M'){
            Name_Size.Push('S');
            Name_Size.Push('S');
            Name_Size.Push('S');
            Name_Input.Add(2);

    }
    else if (X == 'S'){
        Name_Input.Add(3);

    }
    if (Name_Size.GetLength()==0){
        break;

    }

}
    int number=0;
    while (true){
    if (number>=Name_Input.GetLength()){
    break;
}
    Console.Write(Name_Input.Get(number));
    number++;
}
}
}