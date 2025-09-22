using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenUnidad2.Implementaciones
{
    public class MetodosRaices
    {
        public List<Iteracion> Iteraciones { get; private set; }

        public MetodosRaices()
        {
            Iteraciones = new List<Iteracion>();
        }


        // FUNCIONES DISPONIBLES PARA RAÍCES
        public Func<double, double> SeleccionarFuncion(int index)
        {
            switch (index)
            {
                case 0: // Polinómica
                    return x => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;

                case 1: // Trigonométrica
                    return x => Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(x))) - 5;

                case 2: // Exponencial
                    return x => Math.Exp(x);

                case 3: // Logarítmica sencilla
                    return x => Math.Pow(Math.Log(x + 3), 2);

                case 4: // Racional con log
                    return x => Math.Log(x) / x;

                default:
                    throw new ArgumentException("Función no válida.");
            }
        }


        // DERIVADAS PARA NEWTON
        public Func<double, double> SeleccionarDerivada(int index)
        {
            switch (index)
            {
                case 0: // f(x) = 4x³ - 6x² + 7x - 2.3
                    return x => 12 * Math.Pow(x, 2) - 12 * x + 7;

                case 1: // f(x) = x^2 √|cos(x)| - 5
                    return x =>
                    {
                        double cosx = Math.Cos(x);
                        double dcos = -Math.Sin(x);
                        return 2 * x * Math.Sqrt(Math.Abs(cosx)) +
                               (x * x * dcos * Math.Sign(cosx)) / (2 * Math.Sqrt(Math.Abs(cosx)));
                    };

                case 2: // f(x) = e^x
                    return x => Math.Exp(x);

                case 3: // f(x) = (ln(x+3))²
                    return x => (2 * Math.Log(x + 3)) / (x + 3);

                case 4: // f(x) = ln(x) / x
                    return x => (1 - Math.Log(x)) / Math.Pow(x, 2);

                default:
                    throw new ArgumentException("No se definió derivada para esta función.");
            }
        }


        // MÉTODO DE BISECCIÓN
        public double Biseccion(Func<double, double> f, double xi, double xf, double emax)
        {
            Iteraciones.Clear();
            double xr = 0, xrAnt = 0, ea = 100;
            int iter = 0;

            try
            {
                do
                {
                    xrAnt = xr;
                    xr = (xi + xf) / 2;
                    iter++;

                    if (xr != 0)
                        ea = Math.Abs((xr - xrAnt) / xr) * 100;

                    Iteraciones.Add(new Iteracion
                    {
                        Numero = iter,
                        Xi = xi,
                        Xf = xf,
                        Xr = xr,
                        Fxi = f(xi),
                        Fxf = f(xf),
                        Fxr = f(xr),
                        FxiporFxr = f(xi) * f(xr),
                        Ea = ea
                    });

                    if (f(xi) * f(xr) < 0)
                        xf = xr;

                    else if (f(xi) * f(xr) > 0)
                        xi = xr;

                    else
                        ea = 0;

                } while (ea > emax);

                return xr;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Bisección: " + ex.Message);
            }
        }



        // MÉTODO DE REGLA FALSA
        public double ReglaFalsa(Func<double, double> f, double xi, double xf, double emax)
        {
            Iteraciones.Clear();
            double xr = 0, xrAnt = 0, ea = 100;
            int iter = 0;

            try
            {
                do
                {
                    xrAnt = xr;
                    xr = xi - ((xf - xi) / (f(xf) - f(xi))) * f(xi);
                    iter++;

                    if (xr != 0)
                        ea = Math.Abs((xr - xrAnt) / xr) * 100;

                    Iteraciones.Add(new Iteracion
                    {
                        Numero = iter,
                        Xi = xi,
                        Xf = xf,
                        Xr = xr,
                        Fxi = f(xi),
                        Fxf = f(xf),
                        Fxr = f(xr),
                        FxiporFxr = f(xi) * f(xr),
                        Ea = ea
                    });

                    if (f(xi) * f(xr) < 0)
                        xf = xr;

                    else if (f(xi) * f(xr) > 0)
                        xi = xr;

                    else
                        ea = 0;

                } while (ea > emax);

                return xr;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Regla Falsa: " + ex.Message);
            }
        }



        // MÉTODO DE NEWTON-RAPHSON
        public double NewtonRaphson(Func<double, double> f, Func<double, double> df, double xi, double emax)
        {
            Iteraciones.Clear();
            double xr = xi, xrAnt, ea = 100;
            int iter = 0;

            try
            {
                do
                {
                    xrAnt = xr;

                    // Validar si la derivada es cero, no se puede dividir entre cero:
                    if (df(xrAnt) == 0)
                        throw new Exception("La derivada es 0, Newton-Raphson no puede continuar.");

                    double paso = f(xrAnt) / df(xrAnt);

                    // Validar resultados inválidos:
                    if (double.IsNaN(paso) || double.IsInfinity(paso))
                        throw new Exception("Valor inválido en el cálculo (NaN o infinito).");

                    xr = xrAnt - paso;
                    iter++;

                    if (xr != 0)
                        ea = Math.Abs((xr - xrAnt) / xr) * 100;

                    Iteraciones.Add(new Iteracion
                    {
                        Numero = iter,
                        Xi = xrAnt,
                        Xr = xr,
                        Fxi = f(xrAnt),
                        DerivadaX = df(xrAnt),
                        Ea = ea
                    });

                } while (ea > emax);

                return xr;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Newton-Raphson: " + ex.Message);
            }
        }



        // MÉTODO DE LA SECANTE
        public double Secante(Func<double, double> f, double x1, double x2, double emax)
        {
            Iteraciones.Clear();
            double xr = 0, ea = 100;
            int iter = 0;

            try
            {
                do
                {
                    // Fórmula del método de la secante
                    xr = x2 - ((x1 - x2) / (f(x1) - f(x2))) * f(x2);
                    iter++;

                    if (xr != 0)
                        ea = Math.Abs((xr - x2) / xr) * 100;

                    Iteraciones.Add(new Iteracion
                    {
                        Numero = iter,
                        X1 = x1,
                        X2 = x2,
                        Xr = xr,
                        FX1 = f(x1),
                        FX2 = f(x2),
                        Fxr = f(xr),
                        Ea = ea
                    });

                    // Avanzamos los valores
                    x1 = x2;
                    x2 = xr;

                } while (ea > emax);

                return xr;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Secante: " + ex.Message);
            }
        }

        // METODO PARA COMPARAR TODOS LOS MÉTODOS CON BASE EN LOS PARAMETROS DADOS:
        public List<Iteracion> CompararTodos(Func<double, double> f, Func<double, double> df,
                                     double xi, double xf, double emax, int decimales)
        {
            var resultados = new List<Iteracion>();

            // BISECCIÓN
            double raizB = Biseccion(f, xi, xf, emax);
            resultados.Add(new Iteracion
            {
                Metodo = "Bisección",
                Iteraciones = Iteraciones.Count,
                Raiz = raizB,
                YRaiz = f(raizB),
                Eaproximado = Iteraciones.Last().Ea
            });

            // REGLA FALSA
            double raizRF = ReglaFalsa(f, xi, xf, emax);
            resultados.Add(new Iteracion
            {
                Metodo = "Regla Falsa",
                Iteraciones = Iteraciones.Count,
                Raiz = raizRF,
                YRaiz = f(raizRF),
                Eaproximado = Iteraciones.Last().Ea
            });

            // NEWTON-RAPHSON
            if (df != null)
            {
                double raizN = NewtonRaphson(f, df, xi, emax);
                resultados.Add(new Iteracion
                {
                    Metodo = "Newton-Raphson",
                    Iteraciones = Iteraciones.Count,
                    Raiz = raizN,
                    YRaiz = f(raizN),
                    Eaproximado = Iteraciones.Last().Ea
                });
            }

            // SECANTE
            double raizS = Secante(f, xi, xf, emax);
            resultados.Add(new Iteracion
            {
                Metodo = "Secante",
                Iteraciones = Iteraciones.Count,
                Raiz = raizS,
                YRaiz = f(raizS),
                Eaproximado = Iteraciones.Last().Ea
            });

            return resultados;
        }
    }
}