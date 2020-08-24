public enum FrecuenciaPago{

    Quincenal,
    Mensual,
    Bimestral
}
class Empleado{

    int idEmpleado;
    string nombreEmpleado;
    bool activo;
    int edad;
    string nacionalidad;

    public int IdEmpleado{
        //PARA OBTENER EL idEmpleado
        get{
            return idEmpleado;
        }
        //PARA DAR UN VALOR A idEmpleado
        set{
            this.idEmpleado = value;
        }
    }
    //DE ESTA MANERA INDICO EL VALOR QUE VA A OBTENER idEmpleado
    public int idEmpleado{ get;set;}

    public string NombreEmpleado{
        get{
            return nombreEmpleado;
        }
    }


}