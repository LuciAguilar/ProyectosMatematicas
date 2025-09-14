using System;

namespace RaicesFunciones.Implementaciones
{
    public class RaicesFunciones
    {

        private int iteraciones;
        private double error;

        public int GetIteraciones()
        {
            return iteraciones;
        }

        public double GetError()
        {
            return error;
        }

        // MÉTODO PARA CALCULO DE BISECCIÓN:
        public double Biseccion(Func<double, double> f, double xi, double xf, double emax)
        {

            iteraciones = 0;
            double xr = 0, xrAnt = 0;
            error = 100;

            do
            {
                xrAnt = xr;
                xr = (xi + xf) / 2; // aplicamos la fórmula correspondiente para calcular "xr"
                iteraciones++;

                if (xr != 0)
                    error = Math.Abs((xr - xrAnt) / xr) * 100; // fórmula del error aproximado

                if (f(xi) * f(xr) < 0) // ← aplicamos la regla "a"
                    xf = xr;

                else if (f(xi) * f(xr) > 0) // ← aplicamos la regla "b"
                    xi = xr;

                else
                    error = 0; // ← raíz exacta

            } while (error > emax);

            return xr;
        }



        // MÉTODO PARA CÁLCULO DE LA REGLA FALSA:
        public double ReglaFalsa(Func<double, double> f, double xi, double xf, double emax)
        {
            iteraciones = 0;
            double xr = 0, xrAnt = 0;
            error = 100;

            do
            {
                xrAnt = xr;
                xr = xi - ((xf - xi) / (f(xf) - f(xi))) * f(xi);
                iteraciones++;

                if (xr != 0)
                    error = Math.Abs((xr - xrAnt) / xr) * 100;

                if (f(xi) * f(xr) < 0)
                    xf = xr;
                else if (f(xi) * f(xr) > 0)
                    xi = xr;
                else
                    error = 0;

            } while (error > emax);

            return xr;
        }
    }
}
