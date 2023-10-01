int[,] GetMatrix (int rows = 4, int columns = 4, int min = 0, int max = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i =0; i<rows; i++)
    {
        for (int l=0; l<columns; l++)
        {
            matrix [i,l] = rand.Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
  
    for (int i =0; i<matrix.GetLength(0); i++)
    {
        for (int l = 0; l<matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix [i,l]} ");
        }
        Console.WriteLine();
    }
}

int[] Summ(int[,] matrix)
{
    int[] res=new int[matrix.GetLength(0)];
    int sum=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum=0;
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            sum+=matrix[i,l];  
        }
        res[i]=sum;
    }
    return res;
}

void FindMin(int[] arr)
{
    int result=0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[result]>arr[i])
        {
            result=i;
        }
    }
    Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {result}");
}


int[,] matrix=GetMatrix();
PrintMatrix(matrix);
FindMin(Summ(matrix));
