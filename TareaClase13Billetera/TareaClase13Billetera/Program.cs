

using TareaClase13Billetera.Modelos;

var b1 = new Billetera()
{
    BilletesDe10 = 2,
    BilletesDe20 = 3,
    BilletesDe50 = 4,
    BilletesDe100 = 5,
    BilletesDe200 = 6,
    BilletesDe500 = 7,
    BilletesDe1000 = 8,
};

var b2 = new Billetera()
{
    BilletesDe10 = 2,
    BilletesDe20 = 3,
    BilletesDe50 = 4,
    BilletesDe100 = 5,
    BilletesDe200 = 6,
    BilletesDe500 = 7,
    BilletesDe1000 = 18,
};

Console.WriteLine("================= Billetera 1 =================");
Console.WriteLine(b1.Total());
Console.WriteLine("================= Billetera 2 =================");
Console.WriteLine(b2.Total());
Console.WriteLine("================= Billetera 3 =================");

Billetera b3 = b1.Combinar(b2);

Console.WriteLine(b3.Total());

Console.WriteLine("================= Billetera 1 =================");
Console.WriteLine(b1.Total());
Console.WriteLine("================= Billetera 2 =================");
Console.WriteLine(b2.Total());
