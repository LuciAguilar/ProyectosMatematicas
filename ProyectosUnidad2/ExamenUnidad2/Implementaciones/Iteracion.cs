namespace ExamenUnidad2.Implementaciones
{
    public class Iteracion
    {
        // DATOS DE CADA ITERACIÓN:
        public int Numero { get; set; }

        // Para Bisección / Regla Falsa
        public double? Xi { get; set; }
        public double? Xf { get; set; }
        public double? Xr { get; set; }
        public double? Fxi { get; set; }
        public double? Fxf { get; set; }
        public double? Fxr { get; set; }
        public double? FxiporFxr { get; set; }  // f(xi) * f(xr)
        // Para Newton
        public double? DerivadaX { get; set; }

        // Para Secante
        public double? X1 { get; set; }
        public double? X2 { get; set; }
        public double? FX1 { get; set; }
        public double? FX2 { get; set; }


        // Para todos
        public double? Ea { get; set; }



        // RESULTADOS FINALES:
        public string Metodo { get; set; }
        public int Iteraciones { get; set; }
        public double? Raiz { get; set; }
        public double? YRaiz { get; set; }
        public double? Eaproximado { get; set; }
    }
}
