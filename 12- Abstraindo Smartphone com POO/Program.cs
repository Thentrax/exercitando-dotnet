using DesafioPOO.Models;

Nokia nok = new Nokia("(24)99965-5368", "Nokia-10", "29838402", "256gb");
Iphone iph = new Iphone("(24)99974-8751", "Iphone-13", "654646323", "512gb");

nok.Ligar();
nok.ReceberLigacao();
nok.InstalarAplicativo("WhatsApp");

iph.ReceberLigacao();
iph.Ligar();
iph.ReceberLigacao();
iph.InstalarAplicativo("WhatsApp");