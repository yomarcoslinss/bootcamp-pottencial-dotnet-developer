using DesafioPOO.Models;

Nokia lumia = new Nokia("11956955517", "Nokia Lumia 930", "0123456789", 32);
lumia.InstalarAplicativo("SAMP Launcher");
lumia.Ligar(46568666);
lumia.ReceberLigacao();

Iphone iphone6s = new Iphone("11943682217", "Iphone 6S", "9876543210", 32);
iphone6s.InstalarAplicativo("Apple Music");
iphone6s.Ligar(40028922);
iphone6s.ReceberLigacao();