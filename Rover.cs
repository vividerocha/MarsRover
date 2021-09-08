using System;

public class Rover
{
	public int coordenadaX { get; set; }
	public int coordenadaY { get; set; }
	public string posicaoAtual { get; set; }

	public Rover()
	{
	}

	public string virarEsquerda(string direcao)
	{
        switch (direcao)
        {
			case "N":
				direcao = "E";
				break;
			case "E":
				direcao = "S";
				break;
			case "S":
				direcao = "W";
				break;
			case "W":
				direcao = "N";
				break;
		}
		return direcao;
	}

	public string virarDireita(string direcao)
    {
		switch (direcao)
		{
			case "N":
				direcao = "W";
				break;
			case "W":
				direcao = "S";
				break;
			case "S":
				direcao = "E";
				break;
			case "E":
				direcao = "N";
				break;
		}
		return direcao;
	}

	public string andar(int coordX, int coordY, string direcao)
    {
		switch (direcao)
        {
			case "N":
				coordY++;
				break;
			case "S":
				coordY--;
				break;
			case "E":
				coordX--;
				break;
			case "W":
				coordX++;
				break;
        }
		posicaoAtual = coordX + " " + coordY + " " + direcao;
		return posicaoAtual;
    }

}
