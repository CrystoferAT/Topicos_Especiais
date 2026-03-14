
Console.WriteLine("Login");
Console.Write("Defina um nome de Usuario: ");
string user = (Console.ReadLine());
Console.Write("Defina uma senha: ");
string key =(Console.ReadLine());
bool log = false;


    while(log == false)
    {
        Console.Write("Digite seu nome de Usuario: ");
        string user2 = (Console.ReadLine());
        Console.Write("Digite sua senha: ");
        string key2 =(Console.ReadLine());
            
            if(user == user2 && key2 == key)
            {
                Console.WriteLine("Login efetuado com sucesso.");
                Console.WriteLine($"Seja bem vindo(a) {user}");
                log = true;
            }else{
                Console.WriteLine("Senha incorreta tente novamente.");
            }
    }

Console.WriteLine($"Usuario: {user} e  senha: {key}");
