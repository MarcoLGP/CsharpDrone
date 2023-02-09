namespace DroneExplorer
{
    internal class Drone
    {
        public string UserName { get; set; }
        public string DroneName { get; set; }
        
        public double? Altura { get; set; }
        public double? Velocidade { get; set; }
        public string? CompDeBordo { get; set; }
        public string? Status { get; set; }
        public string? StatusBracos { get; set; }
        public List<string>? Mochila { get; set; }

        public Drone()
        {
            Altura = 0;
            Velocidade = 0;
            StatusBracos = "Em repouso";
            CompDeBordo = "Coletando objeto";
            Mochila = new List<string>();
            Status = "Coletando";
        }

        public void DefinirDrone(string userName, string droneName)
        {
            UserName = userName;
            DroneName = droneName;
        }

        public void DefinirAltura(double altura)
        {
            if (altura > 25 || altura < 0.5) 
            {
                throw new Exception("Altura inválida, deve estar entre 0,5m e 20m");
            }
            Altura = altura;
        }
        public void AumentarAltura()
        {
            if (Altura > 25)
            {
                throw new Exception("Altura máxima já atingida");
            }
            Altura += 0.5;
        }
       
        public void AumentarVelocidade()
        {
            double? novaVelocidade = Velocidade + 0.5;
            if (novaVelocidade < 15 && Status == "Em movimento")
            {
                Velocidade = novaVelocidade;
            }
        }
        public void DiminuirVelocidade()
        {
            double? novaVelocidade = Velocidade - 0.5;
            if (novaVelocidade > 0 && Status == "Em movimento")
            {
                Velocidade = novaVelocidade;
            }
        }
        public void AproximarObjeto()
        {
            if (Velocidade == 0)
            {
                Velocidade = 0.5;
                Status = "Em aproximação";
            }
            else
            {
                throw new Exception("Drone deve estar parado para se aproximar do objeto");
            }
        }
        public void DistanciarObjeto()
        {
            Status = "Em movimento";
        }
        public void BracosEmMovimento()
        {
            StatusBracos = "Repouso";
        }
        public void BracosEmRepouso()
        {
            StatusBracos = "Disponível";
        }
        public void BracosUsar()
        {
            StatusBracos = "Em atividade";
        }
        public void BracosPegar(string objeto)
        {
            Mochila.Add(objeto);
        }
    }
}
