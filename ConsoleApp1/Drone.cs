namespace ConsoleApp1
{
    internal class Drone
    {
        private double? _Altura { get; set; }
        private double? _Angulo { get; set; }
        public double? Velocidade { get; set; }
        private string? _Status { get; set; }
        private string? _StatusBracos { get; set; }
        private string? _AnguloBracos { get; set; }
        private List<string>? _Mochila { get; set; }

        public Drone()
        {
            _Altura = 0;
        }
        public void DefinirAltura(double altura)
        {
            if (altura > 25 || altura < 0.5) 
            {
                throw new Exception("Altura inválida, deve estar entre 0,5m e 20m");
            }
            _Altura = altura;
        }
        public void AumentarAltura()
        {
            if (_Altura > 25)
            {
                throw new Exception("Altura máxima já atingida");
            }
            _Altura += 0.5;
        }
        public void DefinirAngulo(double angulo)
        {
            if (angulo > 360 || angulo < 0) 
            {
                throw new Exception("Ângulo inválido");
            }
            _Angulo = angulo;
        }
        public void MoverEsquerda()
        {
            double? novoAngulo = _Angulo - 5;
            if (novoAngulo <= 0)
            {
                _Angulo = 360 - novoAngulo * -1;
            }
            else
            {
                _Angulo -= 5;
            }
        }
        public void MoverDireita()
        {
            double? novoAngulo = _Angulo + 5;
            if (novoAngulo >= 360)
            {
                _Angulo = novoAngulo - 360;   
            }
            else
            {
                _Angulo = novoAngulo;
            }
        }
        public void AumentarVelocidade()
        {
            double? novaVelocidade = Velocidade + 0.5;
            if (novaVelocidade < 15 && _Status == "Em movimento")
            {
                Velocidade = novaVelocidade;
            }
        }
        public void DiminuirVelocidade()
        {
            double? novaVelocidade = Velocidade - 0.5;
            if (novaVelocidade > 0 && _Status == "Em movimento")
            {
                Velocidade = novaVelocidade;
            }
        }
        public void AproximarObjeto()
        {
            if (Velocidade == 0)
            {
                Velocidade = 0.5;
                _Status = "Em aproximação";
            }
            else
            {
                throw new Exception("Drone deve estar parado para se aproximar do objeto");
            }
        }
        public void DistanciarObjeto()
        {
            _Status = "Em movimento";
        }
        public void BracosEmMovimento()
        {
            _StatusBracos = "Repouso";
        }
        public void BracosEmRepouso()
        {
            _StatusBracos = "Disponível";
        }
        public void BracosUsar()
        {
            _StatusBracos = "Em atividade";
        }
        public void BracosPegar(string objeto)
        {
            _Mochila.Add(objeto);
        }
    }
}
