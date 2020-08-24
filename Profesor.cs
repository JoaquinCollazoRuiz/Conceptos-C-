class Profesor : Empleado{

    string matricula;
    string materia;
    FrecuenciaPago frecuenciaPago;

    public string matricula{
        get{
            return matricula;
        }        
    }

    public Materia Materia{get;set;}

    public string comprobarHoraLlegada(){
        DateTime horaActual = DateTime.Now;
        string resp = "Hora de llegada -> " + horaActual;
        return resp;
    }
}