using System;

class elsaeolfi{
    static void Main(){
        Console.WriteLine("Pense num número de (0-9)");
        Console.ReadLine();
        
        Console.WriteLine("O número é maior que 5 ?(s/n)");
        string n5 = Console.ReadLine();

        if (n5 == "s"){
            Console.WriteLine("O número é par?(s/n)");
            string n6 = Console.ReadLine();
        if (n6 == "s"){
                Console.WriteLine("O número é 6 ?(s/n/o)");
                string n7 = Console.ReadLine();
                if(n7 == "s"){
                    Console.WriteLine("Acertei!!");
                }
                else if(n7 == "o"){//se não se 
                    Console.WriteLine("O número é maior que 8(s/n)");
                    string n8 = Console.ReadLine();
                    if(n8 == "s"){
                    Console.WriteLine("Acerteii");
                }else{//senão
                    Console.WriteLine("O número é 9");
                }
                }
                else{// senão
                    Console.WriteLine("O número é o 8");
                }
                }else{
                Console.WriteLine("Finalizando com sucesso de multipla escolha skskks");
            }
            } 
                if(n5 == "n"){
            Console.WriteLine("O número é o 4 ?(s/n)");
            string num = Console.ReadLine();
                if(num == "s"){
                    Console.WriteLine("Acertei!! Miseravi");
                }else{
                    Console.WriteLine("Estou apenas começando, é só aquecimento!!");
                }
}
    }
}