using System.Runtime.InteropServices;

namespace DroneExplorer
{
    class Screen
    {
        public static void Line([Optional]string? text, [Optional]bool? alignCenter)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("{0," + ((Console.WindowWidth / 2) + text.Length / 2) + "}", text);
            }
            else
            {
                string str = new('=', Console.BufferWidth - 1);
                Console.WriteLine(str);
            }
        }

        public static void Header(string textHeader)
        {
            Line();
            Line(text: textHeader, alignCenter: true);
            Line();
        }

        public static void Home(ref string menu)
        {
            Header(textHeader: "DRONE EXPLORER");
            Line(text: "Bem vindo ao Drone Explorer, um passatempo divertido de exploração.", alignCenter: true);
            Line(text: "Colete o máximo possível de objetos e explore por aí com seu drone, vamos começar ?", alignCenter: true);
            Console.WriteLine("");
            Console.WriteLine("[1]. Começar");
            Console.WriteLine("[2]. Regras");
            Console.WriteLine("[3]. Sair");
            Console.WriteLine("");
            Console.Write("Opção: ");
            menu = Console.ReadKey().Key.ToString();
            Console.Clear();
        }

        public static void Rules(ref string menu)
        {
            Header(textHeader: "REGRAS");
            Console.WriteLine("");
            Console.WriteLine("Controle de voo: ");
            Console.WriteLine("Regra: altura máxima deve ser 25 metros do chão");
            Console.WriteLine("Regra: altura mínima deve ser 0,5 metros do chão");
            Console.WriteLine("");
            Console.WriteLine("Velocidade de movimento: ");
            Console.WriteLine("Regra: velocidade máxima de movimento é de 15 metros por segundo");
            Console.WriteLine("Regra: velocidade mínima de movimento é de 0 metros por segundo");
            Console.WriteLine("Dica: caso o drone chegue a velocidade de movimento 0, o estado muda para sem movimento");
            Console.WriteLine("");
            Console.WriteLine("Aproximação de objeto: ");
            Console.WriteLine("Regra: aproximação de objeto só pode ser realizada após estar parado (0 metro/s)");
            Console.WriteLine("Regra: após realizar a aproximação de objeto o drone ficará impedido de fazer nova aproximação, ou mudança de altura e direção");
            Console.WriteLine("Dica: Estando próximo de um objeto o Drone é capaz de se distanciar desse mesmo objeto para voltar as suas funções normais");
            Console.WriteLine("");
            Console.WriteLine("Ações dos braços: ");
            Console.WriteLine("Regra: os braços do drone só podem ser utilizados após realizar aproximação de objeto");
            Console.WriteLine("Regra: qualquer movimento do braço só pode ser realizado quando ele estiver em atividade.");
            Console.WriteLine("Regra: o braço não pode ficar em repouso se estiver no estado ocupado");
            Console.WriteLine("");
            Console.Write("Pressione [0] para voltar: "); menu = Console.ReadKey().Key.ToString();
            Console.Clear();
        }

        public static void NameUser(ref string menu, Drone drone)
        {
            Header("DRONE EXPLORER");
            Console.WriteLine("");
            Console.Write("Digite o seu nome[enter para confirmar]: ");
            var NameUser = Console.ReadLine();
            Console.Write("Digite o nome do seu drone[enter para confirmar]: ");
            var DroneName = Console.ReadLine();

            Console.WriteLine($"Seu nome: {NameUser}");
            Console.WriteLine($"Nome do drone: {DroneName}");

            drone.DefinirDrone(userName: NameUser, droneName: DroneName);
            menu = "Play";
            Console.Clear();
        }

        public static void Play(Drone droneInfo)
        {
            Header(textHeader: "DRONE EXPLORER");
            /*
                		  ^
                         | |       _\^/_                      ============================================
                         | |       >_ _<                      |            PAINEL DE CONTROLE            |
                         | |        '|`                       ============================================ 
                       _|| ||_                                |   Piloto: {droneInfo.UserName}           |
                       |  |  |                                |   Drone: {droneInfo.DroneName}           |             
                       \  |  /                                |   Velocidade: 10 m/s                     |
                       /  |  \                                ============================================
                      /|  |  |\               
                     /    |    \
                    /     |     \
                  //      |      \\
                 /|       |       |\
                / |       !       | \
               / @|       !       |@ \
              |....  ___  !  ___  ....|
              |__----   \_!_/   ----__|
             */
            Console.WriteLine($"   \t\t               ^\r\n                              | |       _\\^/_                  ============================================\r\n      \t\t              | |       >_ _<                  |            PAINEL DE CONTROLE            |\r\n                              | |        '|`                   ============================================ \r\n                            _|| ||_                            |   Piloto: {droneInfo.UserName}           |\r\n                            |  |  |                            |   Drone: {droneInfo.DroneName}           |             \r\n                            \\  |  /                            |   Velocidade: 10 m/s                     |\r\n                            /  |  \\                            ============================================\r\n                           /|  |  |\\               \r\n                          /    |    \\\r\n                         /     |     \\\r\n                       //      |      \\\\\r\n                      /|       |       |\\\r\n                     / |       !       | \\\r\n                    / @|       !       |@ \\\r\n                   |....  ___  !  ___  ....|\r\n                   |__----   \\_!_/   ----__|");
            Console.Read();
        }

    }
}
