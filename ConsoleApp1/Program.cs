namespace DroneExplorer
{
    public class DroneExplorer
    {

        public static void Main()
        {
            // Bloquear o redimensionamento da janela e alterar a janela pro tam. padrão.
            WindowConfig.BlockResize();

            // Menu de controle de telas aplicação.
            string menu = "D0";

            // Inicializando a classe do drone.
            Drone droneInfo = new();

            while (true)
            {
                switch(menu)
                {
                    case "NumPad0":
                    case "D0":
                        Screen.Home(ref menu);
                        break;
                    case "NumPad1":
                    case "D1":
                        Screen.NameUser(ref menu, droneInfo);
                        break;
                    case "NumPad2":
                    case "D2":
                        Screen.Rules(ref menu);
                        break;
                    case "NumPad3":
                    case "D3":
                        Environment.Exit(0);
                        break;
                    case "Play":
                        Screen.Play(droneInfo);
                        break;
                }
            }
        }
    }
}