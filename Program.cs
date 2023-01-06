using CalculoComissao.Entidades;

namespace CalculoComissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularComissao calculo = new CalcularComissao();
            calculo.CapturaValores();
        }
    }
}