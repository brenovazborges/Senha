Console.Clear();
string password;
 
Console.Write("Digite sua senha: ");
password = Convert.ToString(Console.ReadLine())!;
 
if (password != Convert.ToString("1234abcd"))
{
    Console.WriteLine("Acesso negado");
}
else
{
    Console.WriteLine("Acesso permitido");
}
