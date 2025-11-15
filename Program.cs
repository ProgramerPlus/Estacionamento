Console.WriteLine("--- Estacionamento ---");
Console.WriteLine("Tamanho do veículo (P/G).....: ");
string t=Console.ReadLine()!;
Console.WriteLine("Tempo de permanência (min)...: ");
int tempo=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Serviço de vallet (s/n)......: ");
string val=Console.ReadLine()!;
Console.WriteLine("Serviço de lavagem (s/n).....:");
string lav=Console.ReadLine()!;

bool lavagem = lav == "s";
bool vallet = val =="s";
bool tamanho = t == "P";

int valor= 20;
int l;
double total, v;

if(tempo > (60*12))
{
Console.WriteLine("Não é aceito tempo maior que 12h");
}else{
if(tempo<=60){

valor= 20;
    
}
else if(tempo>60 && tempo<(60*5))
{

if(tamanho){
    valor = valor+10*(tempo-1);
}else
{
valor = valor+20*(tempo-1);
}

}
else if(tempo>=(60*5))
{

if(tamanho){
valor=50;
}
else
{
valor=80;
}

}

    if(vallet){
         v=valor*(1/5);
        total=valor+(valor*(1/5)); 
    }

    if(lavagem){
        if(tamanho){
l=50;
total=valor+50;
}
else
{
l=100;
total=valor+100;
}
    }

}

Console.WriteLine($"Estacionamento..: {valor:N2}");
Console.WriteLine($"Valet...........: {v:N2}");
Console.WriteLine($"Lavagem.........: {l}");
Console.WriteLine($"-----------------");
Console.WriteLine($"Total...........: {total:N2}");
