using System;
using System.Collections.Generic;

namespace RaicesFunciones.Implementaciones
{
    public class RaicesFunciones
    {
        // MÉTODO PARA CALCULO DE BISECCIÓN:
        public List<Iteracion> BiseccionTabla(Func<double, double> f, double xi, double xf, double emax)
        {
            var lista = new List<Iteracion>();
            int iter = 0;
            double xr = 0, xrAnt = 0, ea = 100;

            do
            {
                xrAnt = xr;
                xr = (xi + xf) / 2; // aplicamos la fórmula correspondiente para calcular "xr"
                iter++;

                double fxi = f(xi);
                double fxr = f(xr);
                double fxf = f(xf);
                double producto = fxi * fxr;

                if (xr != 0)
                    ea = Math.Abs((xr - xrAnt) / xr) * 100; // fórmula del error aproximado

                lista.Add(new Iteracion
                {
                    N = iter,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    Fxi = fxi,
                    Fxf = fxf,
                    Fxr = fxr,
                    Producto = producto,
                    Ea = ea
                });

                if (producto < 0) // ← aplicamos la regla "a"
                    xf = xr;

                else if (producto > 0) // ← aplicamos la regla "b"
                    xi = xr;

                else
                    ea = 0; // ← raíz exacta

            } while (ea > emax);

            return lista;
        }

        // MÉTODO PARA CÁLCULO DE LA REGLA FALSA:
        public List<Iteracion> ReglaFalsaTabla(Func<double, double> f, double xi, double xf, double emax)
        {
            var lista = new List<Iteracion>();
            int iter = 0;
            double xr = 0, xrAnt = 0, ea = 100;

            do
            {
                xrAnt = xr;
                xr = xi - ((xf - xi) / (f(xf) - f(xi))) * f(xi);
                iter++;

                double fxi = f(xi);
                double fxr = f(xr);
                double fxf = f(xf);
                double producto = fxi * fxr;

                if (xr != 0)
                    ea = Math.Abs((xr - xrAnt) / xr) * 100;

                lista.Add(new Iteracion
                {
                    N = iter,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    Fxi = fxi,
                    Fxf = fxf,
                    Fxr = fxr,
                    Producto = producto,
                    Ea = ea
                });

                if (producto < 0)
                    xf = xr;

                else if (producto > 0)
                    xi = xr;

                else
                    ea = 0;

            } while (ea > emax);

            return lista;
        }
    }
}
