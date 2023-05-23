public class Indumentaria{
    public string Campera {get; private set;}
    public string Top {get; private set;}
    public string Remera{get; private set;}
    public string Calza{get; private set;}
    public string Zapatilla{get; private set;}

    public Indumentaria(){}
    public Indumentaria(string campera, string top, string remera, string calza, string zapas){
        Campera=campera;
        Top=top;
        Remera=remera;
        Calza=calza;
        Zapatilla=zapas;
    }
}