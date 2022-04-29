// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Datos numéricos

byte numeroByte = 0;
int numeroInteger = 0;
long numeroLong = 200;
double numeroDouble = 300;
float numeroFloat = 400;


//Datos lógicos

bool datoBool1 = false; //0
bool datoBool2 = true;  //1

//Datos text

string datoString = "Texto";

Console.WriteLine(datoString);

datoString = "Texto modificado";

Console.WriteLine(datoString);

datoString = Console.ReadLine(); //ReadLine es para ingresar texto.

int datoInt = Convert.ToInt32(Console.ReadLine()); //Hay que parsear porque lo que se ingresa es un string.

//CTRL + K para comentar varias líneas. CTRL + U para descomentar.

const string datoString2 = "Texto constante";
