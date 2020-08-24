class Alumno{

    List<int> miLista = new List<int>();
    //miLista.Add(5);

    int[] datos = {1,2,3,4,5};

    int idAlumno;
    string nombre;
    bool Activo;
    int edad;
    string nac;

    bool estatus;

    public string RegistrarAlumno(){
        string resp = "Alumno registrado correctamente";
        return resp;
    }

    public string DarDeBaja(){
        this.estatus = false;
        string respuesta = "Alumno dado de baja";
        return respuesta;
    }
}