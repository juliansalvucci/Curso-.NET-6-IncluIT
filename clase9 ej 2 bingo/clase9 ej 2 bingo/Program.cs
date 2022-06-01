
int[,] carton = new int[3,9]; 

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 9; j++)
    {
        carton[i, 1] = new Random().Next(9);
    }
}

for(int i = 0; i < 3; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.WriteLine(carton[i,j]);
    }
}
