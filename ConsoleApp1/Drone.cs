using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Drone
    {
        private double? _Altura { get; set; }
        private double? _Angulo { get; set; }
        private double? _Velocidade { get; set; }
        private string? _Status { get; set; }

        public Drone(double altura)
        {
            _Altura = altura;
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
            if (_Angulo - 5 <= 0)
            {
                _Angulo = (_Angulo * -1) - 360;
            }
            _Angulo -= 5;
        }

        public void MoverDireita()
        {
            if (_Angulo + 5 >= 360)
            {
                _Angulo -= 360;
            }
            else
            {
                _Angulo += 5;
            }
        }
    }
}
