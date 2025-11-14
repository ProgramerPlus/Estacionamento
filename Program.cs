Console.WriteLine("--- Estacionamento ---");
Console.WriteLine("Tamanho do veículo (P/G).....: ");
string tamanho=Console.ReadLine();
Console.WriteLine("Tempo de permanência (min)...: ");
int tempo=Convert.Int32(Console.ReadLine());
Console.WriteLine("Serviço de vallet (s/n)......: ");
string vallet=Console.ReadLine();
Console.WriteLine("Serviço de lavagem (s/n).....:");
string lavagem=Console.ReadLine();

bool lavagem = lavagem == "s";
bool vallet = vallet =="s";

if()