using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("111", " IPHONE", "2222", 123);
nokia.apresentar("NOKIA");
nokia.InstalarAplicativo("Telegram");
nokia.Ligar();
nokia.ReceberLigacao();


Iphone iphone = new Iphone("122", " IPHONE", "5555", 321);
iphone.apresentar("IPHONE");
iphone.InstalarAplicativo("Whatsaap");
iphone.Ligar();
iphone.ReceberLigacao();