using ArbolOrdenado.Clases.ArbolBinarioOrdenado;
using System;

namespace ArbolOrdenado
{
    class Program
    {
        public static void pruebaOrden()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            String[] datos = { "Cesar", "Vanessa", "Anthony", "Jeff", "Sarai", "Pedro", "Antoni", "Michel" };
            Estudiante es = new Estudiante();
            foreach (var d in datos)
            {
                es.nombre = d;
                es.numMat = $"insertar No.{d}";
                ArBus.insertar(es);
                es = new Estudiante();
            }
            int pausa;
            pausa = 0;
            es = new Estudiante();
            es.nombre = "Jeff";
            es.numMat = "cualquier cosa";
            ArBus.eliminar(es);
            pausa = 0;
        }
        static void Main(string[] args)
        {
            pruebaOrden();
        }
    }
}
