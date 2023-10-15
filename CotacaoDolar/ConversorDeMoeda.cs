namespace CotacaoDolar
{
    class ConversorDeMoeda
    {
        public static double Cotacao, QuatidadeDolares;
        public static double ValorASerPago()
        {
            return QuatidadeDolares*Cotacao*1.06;
        }
    }
}
