using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Com NOKIA:");
Smartphone nokia = new Nokia(numero:"66669999", modelo: "TIJOLAO-1989", imei: "XPTO8886665", memoria:64); 
nokia.Ligar();
nokia.InstalarAplicativo("freeshop");

Console.WriteLine("\n");

Console.WriteLine("Com Uai-fone:");
Smartphone iphone = new Iphone(numero:"22233344", modelo: "maçã podre", imei: "xmerdoulada", memoria:8); 
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Nutelafree");


