// Klasse => Eigenener Datentyp

public class TodoItem
{
    // Klassen definieren Variablen (Daten) und Methoden (Funktionalität)
    // Variablen können Delder (Fields) oder EIgenschaften (Properties) sein
    // Felder sind privat -> KLassenintern
    // Eigenschaften sind public -> Kann von außen 

    public string Description { get; set; }
    public int Prio { get; set; }
   
    // Instanz-Methode => myTodo.ToString();    
    public override string ToString()
    {
        return $"{Description} - {Prio}";
    }
}
