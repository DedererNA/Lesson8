int[,,] GetMass (int x=2, int y=2, int z=2)
{
    int[,,] res = new int[x,y,z];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int l = 0; l < y; l++)
        {
            for (int m = 0; m < z; m++)
            {
                res [i,l,m] = rand.Next(0, 100);
            }
        }
    }
    return res;
}

void PrintMass(int[,,] mass)
{
  
    for (int i =0; i<mass.GetLength(2); i++)
    {
        for (int l = 0; l<mass.GetLength(0); l++)
        {
            for (int m = 0; m < mass.GetLength(1); m++)
            {
                Console.Write($"{mass [l,m,i]}" + $"({l},{m},{i}) ");
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] mass=GetMass();
PrintMass(mass);