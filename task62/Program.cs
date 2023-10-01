int[,] GetMatrix (int rows = 4, int columns = 4)
{
    int count=0;
    int num=1;
    int[,] matrix = new int[rows, columns];

    
    while (num<rows*columns)
    {
        for (int i = count; i < (columns-count); i++)
        {
            matrix[count,i]=num;
            num++;
        }
        for (int i = count+1; i < (rows-count); i++)
        {
            matrix[i,columns-1-count]=num;
            num++;
        }
        for (int i = columns-count-2; i >= 0+count; i--)
        {
            matrix[rows-count-1,i]=num;
            num++;
        }
        for (int i = rows-count-2; i >= 1+count; i--)
        {
            matrix[i, count]=num;
            num++;
        }
        count++;
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

int[,] matrix=GetMatrix();
PrintMatrix(matrix);