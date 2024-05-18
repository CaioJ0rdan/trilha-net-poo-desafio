using DesafioPOO.Models;
// Implementado !!!

/*------------------Main de teste das classes---------------------*/

// Criação dos objetos
Nokia nk = new Nokia("91234-5678","Silver","87843284872",64);

Iphone ip = new Iphone("98765-4321","Gold","89747347467",128);


//Teste das funções de Ligação

nk.Ligar();
ip.ReceberLigacao();


// teste da função InstalarApp

nk.InstalarAplicativo("Facebook");

ip.InstalarAplicativo("Instagram");





