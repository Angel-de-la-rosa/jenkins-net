namespace DemoTest;
using MiApp;
public class UnitTest1
{
    [Fact]
    public void Resstar_CincoMenosTres_EsDos()
    {
        var calc = new Calculadora();
        int resultado = calc.Restar(5, 3);
        Assert.Equal(2, resultado);
    }
}
