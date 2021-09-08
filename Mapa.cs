public class Mapa{

	public int maximoX { get; set; }
	public int maximoY { get; set; }
	public int minimoX { get; }
	public int minimoY { get; }
	public Mapa(int maxY, int maxX)
	{
		maximoX = maxX;
		maximoY = maxY;
		minimoX = 0;
		minimoY = 0;
	}
}
