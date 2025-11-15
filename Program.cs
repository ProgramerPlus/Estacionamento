Console.Clear();

Console.WriteLine("--- Estacionamento ---");
Console.WriteLine("Tamanho do veículo (P/G).....: ");
string t=Console.ReadLine()!;
Console.WriteLine("Tempo de permanência (min)...: ");
int tempo=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Serviço de vallet (s/n)......: ");
string val=Console.ReadLine()!;
Console.WriteLine("Serviço de lavagem (s/n).....:");
string lav=Console.ReadLine()!;

t=t.ToUpper();
val=val.ToLower();
lav=lav.ToLower();

bool lavagem = lav == "s";
bool vallet = val =="s";
bool tamanho = t == "P";

int valor= 20;
int l=0;
double total=0, v=0;


if(tempo<=60){

valor= 20;
    
}
else if(tempo>60 && tempo<(60*5))
{

if(tamanho){
    valor = valor+10*(tempo/60-1);
}else
{
valor = valor+20*(tempo/60-1);
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


if(tempo>(12*60)){
    Console.WriteLine("Não é aceito tempo acima de 12h !");
}else
{
total=valor;

 if(vallet){
         v=valor*1/5;
        total=valor+v;
 }

    if(lavagem){
        if(tamanho){
 l=50;
total=total+50;
}
else
{
l=100;
total=total+100;
}
    }


Console.WriteLine($"Estacionamento..: {valor:N2}");
Console.WriteLine($"Vallet...........: {v:N2}");
Console.WriteLine($"Lavagem.........: {l}");
Console.WriteLine($"-----------------");
Console.WriteLine($"Total...........: {total:N2}");

}