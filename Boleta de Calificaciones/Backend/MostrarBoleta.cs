using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class MostrarBoleta
    {
        public CálculoNotas[] calculosNotas
        { 
            get; 
            set; 
        }

        public CálculoNotas calculoNotas { 
            get; 
            set; 
        }

        int indice;

        public MostrarBoleta()
        {
            indice = 0;
            calculosNotas = new CálculoNotas[10];
        }

        public void agregarNotas(
            int c,
            string estudiante,
            float matematicas,
            float indiomeE,
            float cSociales,
            float cNaturales)
        {
            calculoNotas = new CálculoNotas
            {
                C = c,
                Estudiante = estudiante,
                Matemáticas = matematicas,
                IdiomaE = indiomeE,
                CSociales = cSociales,
                CNaturales = cNaturales
            };

            calculosNotas[indice] = calculoNotas;

            indice++;
        }
    }
}
