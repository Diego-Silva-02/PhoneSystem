using DesafioPOO.Models;

Iphone iphone = new Iphone("999887766", "Iphone X", "89K47A", 256);
iphone.Call();
iphone.ReceiveCall();
iphone.InstallApp("Whatsapp");

Console.WriteLine("--------------------------------------------------");

Nokia nokia = new Nokia("998765432", "Nokia 7.12", "17L22N", 128);
nokia.Call();
nokia.ReceiveCall();
nokia.InstallApp("Angry Birds");