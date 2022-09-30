console.log("Hola Mundo");

const lista = ["Pelusa","Luna","Mimi","Pomelo"]

//var NO SE USA NUNCA MÁS.

//Con map es como hacer un for a la lista.
lista.map((item) => {
    console.log(item);
});

lista.forEach((item) => {
    console.log(item);
});

//Ciclo por índice
for(let index in lista)
{
    console.log(lista[index]);
}

//Ciclo por objeto
for(let item of lista)
{
    console.log(item);
}

for(let i = 0; i < lista.length; i++)
{
    console.log(lista[i]);
}

let index = 0;

while(index < lista.length)
{
    console.log(lista[index]);
    index++;
}

let contador = 0;

while(contador < lista.length)
{
    console.log(contador);
    contador++;
    if(contador === 10)  "=== estrictamente igual"
    {
        break;
    }
}

console.log(1 === "1"); //False
console.log(1 == "1"); //True

let loca = "1" + 1; //CONCATENA

console.log(loca); 

loca = loca + 1; //CONCATENA DE VUELTA

console.log(loca); 

loca = loca + 1; //CONCATENA DE VUELTA

console.log(loca); 

loca = loca - 1; //RESTA

console.log(loca); 

//CADENA CON NÚMERO, CON +, SE CONCATENA

function test() {
    fetch("http://168.181.184.237:8080/api/usuario/getall", { method: "GET" })
        .then((response) => response.text())
        .then((data) => {
            console.log(data);
        }).catch(error => {
            console.log(error);
        })
}

test()