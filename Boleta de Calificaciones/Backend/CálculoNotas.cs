using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CálculoNotas
    {
        public int C { 
            get; 
            set; 
        }

        public string Estudiante { 
            get; 
            set; 
        }

        public float Matemáticas { 
            get; 
            set; 
        }

        public float IdiomaE { 
            get; 
            set; 
        }

        public float CSociales { 
            get; 
            set; 
        }

        public float CNaturales { 
            get; 
            set; 
        }

        private float notaMenor;

        public float NMenor
        {
            get {
                if (Matemáticas < IdiomaE && Matemáticas < CSociales && Matemáticas < CNaturales)
                {
                    notaMenor = Matemáticas;
                }
                else if (IdiomaE < Matemáticas && IdiomaE < CSociales && IdiomaE < CNaturales)
                {
                    notaMenor = IdiomaE;
                }
                else if (CSociales < Matemáticas && CSociales < IdiomaE && CSociales < CNaturales)
                {
                    notaMenor = CSociales;
                }
                else if (CNaturales < Matemáticas && CNaturales < IdiomaE && CNaturales < CSociales)
                {
                    notaMenor = CNaturales;
                } else if(Matemáticas == IdiomaE || IdiomaE == Matemáticas) {
                    notaMenor = Matemáticas;
                } else if(Matemáticas == CSociales || CSociales == Matemáticas)
                {
                    notaMenor = Matemáticas;
                } else if(Matemáticas == CNaturales || CNaturales == Matemáticas)
                {
                    notaMenor = Matemáticas;
                } else if (IdiomaE == CSociales || CSociales == IdiomaE)
                {
                    notaMenor = IdiomaE;
                }
                else if (IdiomaE == CNaturales || CNaturales == IdiomaE)
                {
                    notaMenor = IdiomaE;
                }
                else if (CSociales == CNaturales || CNaturales == CSociales)
                {
                    notaMenor = CSociales;
                }

                return notaMenor; 
            }
        }

        private float notaMayor;

        public float NMayor
        {
            get
            {
                if (Matemáticas > IdiomaE && Matemáticas > CSociales && Matemáticas > CNaturales)
                {
                    notaMayor = Matemáticas;
                }
                else if (IdiomaE > Matemáticas && IdiomaE > CSociales && IdiomaE > CNaturales)
                {
                    notaMayor = IdiomaE;
                }
                else if (CSociales > Matemáticas && CSociales > IdiomaE && CSociales > CNaturales)
                {
                    notaMayor = CSociales;
                }
                else if (CNaturales > Matemáticas && CNaturales > IdiomaE && CNaturales > CSociales)
                {
                    notaMayor = CNaturales;
                } else if (Matemáticas == IdiomaE || IdiomaE == Matemáticas)
                {
                    notaMayor = Matemáticas;
                }
                else if (Matemáticas == CSociales || CSociales == Matemáticas)
                {
                    notaMayor = Matemáticas;
                }
                else if (Matemáticas == CNaturales || CNaturales == Matemáticas)
                {
                    notaMayor = Matemáticas;
                }
                else if (IdiomaE == CSociales || CSociales == IdiomaE)
                {
                    notaMayor = IdiomaE;
                }
                else if (IdiomaE == CNaturales || CNaturales == IdiomaE)
                {
                    notaMayor = IdiomaE;
                }
                else if (CSociales == CNaturales || CNaturales == CSociales)
                {
                    notaMayor = CSociales;
                }

                return notaMayor;
            }
        }

    }
}
