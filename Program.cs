namespace source{
    struct tFecha{
        public short dia;
        public short mes;
        public short anio;
        public tFecha(short d, short m, short a){
            dia=d;
            mes=m;
            anio=a;
        }
    };
    struct tPersona{
        public string nombre;
        public string apellido;
        public int edad;
        public string dni;
        public tFecha nacimiento;
    }
    struct tlaboral{
        public string obraSocial;
        public float sueldoBruto;
        public tFecha ingreso;
        public int cantFamiliares;
        public tPersona[] familiaresACargo;
       
        public tlaboral(int size){
            familiaresACargo = new tPersona[size];
            obraSocial ="";
            sueldoBruto=0;
            cantFamiliares=0;
            ingreso = new tFecha(0,0,0);
        }

    }
    struct tEmpleado{
        public tPersona datosBasicos;
        public tlaboral datosLaborales;
        public int cantPersACargo;
        public tPersona[] aCargo;

        public override string ToString()
        {
            return $"aqui hay datos de personas";
        }

        public tEmpleado(int maxFamiliares, int maxPersonasACargo){
            datosBasicos = new tPersona();
            datosLaborales = new tlaboral(maxFamiliares);
            cantPersACargo =0;
            aCargo = new tPersona[maxPersonasACargo];
        }
    }
struct tEstructuraColaboradores{
    public tFecha ultimaModificacion;
    public int cantColaboradores;
    public tEmpleado[] colaboradores;
    public tEstructuraColaboradores(int maxColaboradores, int maxFamiliares, int maxPersonasACargo){
        ultimaModificacion = new tFecha(0,0,0);
        colaboradores = new tEmpleado[maxColaboradores];
        cantColaboradores =0;

        for (int i = 0; i < maxColaboradores; i++){
            colaboradores[i]=new tEmpleado();
        }
        {
            
        }
    }
}
}

namespace source{
    class program{
        static void Main(string[] args){
            var trabajadores = new tEstructuraColaboradores(maxColaboradores:50, maxFamiliares:5,maxPersonasACargo:15);

            trabajadores.cantColaboradores =1;
            trabajadores.colaboradores[0].datosBasicos.apellido="Gornet";
            trabajadores.colaboradores[0].datosBasicos.nombre="Edgar";
            trabajadores.colaboradores[0].datosBasicos.dni="123456789";
            trabajadores.colaboradores[0].datosBasicos.edad=22;
            trabajadores.colaboradores[0].datosBasicos.nacimiento.dia=29;
            trabajadores.colaboradores[0].datosBasicos.nacimiento.mes=3;
            trabajadores.colaboradores[0].datosBasicos.nacimiento.anio=2020;
            trabajadores.colaboradores[0].datosLaborales.cantFamiliares=0;
            trabajadores.colaboradores[0].datosLaborales.ingreso.dia=1;
            trabajadores.colaboradores[0].datosLaborales.ingreso.mes=4;
            trabajadores.colaboradores[0].datosLaborales.ingreso.anio=2021;
            trabajadores.colaboradores[0].datosLaborales.obraSocial="La Salud S.A";
            trabajadores.colaboradores[0].datosLaborales.sueldoBruto=60000;

          

        }
    }
}