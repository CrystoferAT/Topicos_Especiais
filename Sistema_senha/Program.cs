
Console.WriteLine("Login");
Console.Write("Defina um nome de Usuario: ");
string user = (Console.ReadLine());
Console.Write("Defina uma senha: ");
string key =(Console.ReadLine());
bool log = false;
int tentativa = 0;

        while(log == false && tentativa < 3)
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
                    Console.WriteLine($"Usuario: {user} e  senha: {key}");
                    break;
                }else{
                    Console.WriteLine("Senha incorreta tente novamente.");
                    tentativa++;
                }
        }
        if(tentativa == 3)
    {
        Console.Write("Exesso de tentativas.");      
    }
    

