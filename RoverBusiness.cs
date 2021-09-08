using System;

public class RoverBusiness
{
	public RoverBusiness()
	{
	}

	public string movimentaMarsRover(int coordX, int coordY, string posicaoCabeca, char[] movimentacao, Mapa mapa)
    {
		string posicaoFinal = "";
        Rover rover = new Rover();
        if (validarCoordenada(coordX, coordY, mapa))
        {
            for(int i = 0; i < movimentacao.Length; i++)
            {
                switch (movimentacao[i])
                {
                    case 'M':
                        posicaoFinal = rover.andar(coordX, coordY, posicaoCabeca);
                        var posicaoIntermediaria = posicaoFinal.Split(' ');
                        coordX = Int32.Parse(posicaoIntermediaria[0]);
                        coordY = Int32.Parse(posicaoIntermediaria[1]);
                        posicaoCabeca = posicaoIntermediaria[2];
                        break;
                    case 'L':
                        posicaoCabeca = rover.virarEsquerda(posicaoCabeca);
                        break;
                    case 'R':
                        posicaoCabeca = rover.virarDireita(posicaoCabeca);
                        break;
                }

            }
        }
        else
        {
            posicaoFinal = "Coordenadas ultrapassam o limite do mapa!";
        }
		return posicaoFinal;
    }
	public bool validarCoordenada(int coordX, int coordY, Mapa mapa)
    {
		if(coordX > mapa.maximoX)
        {
			return false;
		}
		if(coordY > mapa.maximoY)
        {
			return false;
        }
		return true;
    }
}
