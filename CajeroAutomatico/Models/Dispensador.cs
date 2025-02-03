public class CajeroModel
{
    public enum ModoDispensacion
    {
        Billetes200y1000,
        Billetes100y500,
        Eficiente
    }

    public ModoDispensacion ModoActual { get; set; } = ModoDispensacion.Eficiente;

    public Dictionary<int, int> RetirarDinero(int monto)
    {
        var resultado = new Dictionary<int, int>();
        int[] billetes;

        switch (ModoActual)
        {
            case ModoDispensacion.Billetes200y1000:
                billetes = new int[] { 1000, 200 };
                break;
            case ModoDispensacion.Billetes100y500:
                billetes = new int[] { 500, 100 };
                break;
            case ModoDispensacion.Eficiente:
                billetes = new int[] { 1000, 500, 200, 100 };
                break;
            default:
                return resultado;
        }

        foreach (var billete in billetes)
        {
            while (monto >= billete)
            {
                if (!resultado.ContainsKey(billete))
                    resultado[billete] = 0;
                resultado[billete]++;
                monto -= billete;
            }
        }

        return resultado;
    }
}
