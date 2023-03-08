// See https://aka.ms/new-console-template for more information
using ConsoleApp_tarde;



Produto p1 = new Produto (1,"mouse xing ling",10.90M);
Produto p2 = new Produto(2,"teclado multilase", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao ("Mouze Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
