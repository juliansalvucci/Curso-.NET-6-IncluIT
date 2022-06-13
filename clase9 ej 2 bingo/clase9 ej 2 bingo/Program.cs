
int[,] carton = new int[3,9];

int lengthFilas = carton.GetUpperBound(0) + 1;
int lengthColumnas = carton.GetUpperBound(1) + 1;

for (int j = 0; j < lengthFilas; j++)
{
    carton[0,j] = new Random().Next(0, 9);
    carton[1,j] = new Random().Next(0, 9);
    carton[2,j] = new Random().Next(0, 9);


    for (int i = 0; i < lengthColumnas; i++)
    {
        carton[i, 0] = new Random().Next(0, 9);
        carton[i, 1] = new Random().Next(0, 9);
        carton[i, 2] = new Random().Next(0, 9);
        carton[i, 3] = new Random().Next(0, 9);
        carton[i, 4] = new Random().Next(0, 9);
        carton[i, 5] = new Random().Next(0, 9);
        carton[i, 6] = new Random().Next(0, 9);
        carton[i, 7] = new Random().Next(0, 9);
        carton[i, 8] = new Random().Next(0, 9);

    }
}

for(int i = 0; i < 3; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.WriteLine(carton[i,j]);
    }
}
