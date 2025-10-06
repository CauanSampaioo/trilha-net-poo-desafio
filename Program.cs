using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//NOKIA
string numero1 = "123456";
string modelo1 = "Modelo 1";
string imei1 = "11111111-1";
int memoria1 = 64;

Nokia nokia = new Nokia(numero1, modelo1, imei1, memoria1);
nokia.apresentarSistema("NOKIA");
nokia.InstalarAplicativo("Telegram");
nokia.Ligar();
nokia.ReceberLigacao();


//IPHONE
string numero2 = "654321";
string modelo2 = "Modelo 2";
string imei2 = "22222222-2";
int memoria2 = 123;

Iphone iphone = new Iphone(numero2, modelo2, imei2, memoria2);
iphone.apresentarSistema("IPHONE");
iphone.InstalarAplicativo("Whatsaap");
iphone.Ligar();
iphone.ReceberLigacao();