int[,] GetMatrix (int rows = 4, int columns = 4, int min = -10, int max = 10)
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

int[,] SortArr (int[,] array)
{
    int temp=0;

    for (int rows=0; rows<array.GetLength(0); rows++)
    {
        for (int columns = 1; columns < array.GetLength(1); columns++)
        {
            if (array[rows,columns]>array[rows,columns-1])
            {
                for (int l=columns-1;l>=0;l--)
                {
                    if (array[rows,l+1]>array[rows,l])
                    {
                        temp=array[rows,l];
                        array[rows,l]=array[rows,l+1];
                        array[rows,l+1]=temp;
                    }
                }
            }
        }
    }

    return array;
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

int[,] matrix=GetMatrix();
PrintMatrix(matrix);
Console.WriteLine();
matrix=(SortArr(matrix));
PrintMatrix(matrix);