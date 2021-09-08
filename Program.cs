using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //INICIA O MAPA
            var coordenadasMax = Console.ReadLine().Trim().Split(' ');
            Mapa mapa = new Mapa(Int32.Parse(coordenadasMax[0]), Int32.Parse(coordenadasMax[1]));

            //POSICAO INICIAL DO MARS ROVER            
            string[] posicaoAtual = Console.ReadLine().Trim().Split(' ');
            int coordX = Int32.Parse(posicaoAtual[0].Trim());
            int coordY = Int32.Parse(posicaoAtual[1].Trim());
            string posicaoCabeca = posicaoAtual[2];

            var movimentacao = Console.ReadLine().Trim().ToCharArray();

            string[] posicaoAtual2 = Console.ReadLine().Trim().Split(' ');
            int coordX2 = Int32.Parse(posicaoAtual2[0].Trim());
            int coordY2 = Int32.Parse(posicaoAtual2[1].Trim());
            string posicaoCabeca2 = posicaoAtual2[2];

            var movimentacao2 = Console.ReadLine().Trim().ToCharArray();

            RoverBusiness roverB = new RoverBusiness();
            Console.WriteLine(roverB.movimentaMarsRover(coordX, coordY, posicaoCabeca, movimentacao, mapa));

            Console.WriteLine(roverB.movimentaMarsRover(coordX2, coordY2, posicaoCabeca2, movimentacao2, mapa));

        }


    }
}
