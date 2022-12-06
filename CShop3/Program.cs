// See https://aka.ms/new-console-template for more information
using CShop3;

Console.WriteLine("Hello, World!");

using CShop3;

Console.WriteLine("Hello, World!");

Acqua Vitasnella = new Acqua("Vitasnella", "L'acqua che elimina l'acqua");
Sacchettodifrutta Pera = new Sacchettodifrutta("Pera", "Prodotta in Italia");
Elettrodomoestico Aspirapolvere = new Elettrodomestico("Aspirapolvere", "A traino con tubo telescopico", "Estrema leggerezza");
Ciboinscatola Tonno = new Ciboinscatola("Tonno", "Riomare", "Con olio di oliva", 0.5);


Vitasnella.StampaProdotto();
Pera.StampaProdotto();
Aspirapolvere.StampaProdotto();
Tonno.StampaProdotto();


Acqua.ConvertiInGalloni(1.5);