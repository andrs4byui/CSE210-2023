public class Scripture{
    //Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

    Reference refernece = new Reference("Juan", 3, 16);
    //string[] words = {" 16", " For", " God", " so", " loved", " the", " world", "," , " that", " he", " gave", " his", " only", " begotten", " Son", ",", " that", " whosoever", " believeth", " in", " him", " should", " not", " perish", ",", " but", " have", " heverlasting", " life", "."}; 
    Random random = new Random();
    public string scriptureText = "";
    public void PopulateScripture(){
        List<string> list = scriptureText.Split(' ').ToList(); 
        for (int i=0 ; i<list.Count(); i++){
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
    public void HideWords(){
        List<string> list = scriptureText.Split(' ').ToList(); 
        string hide1 = list[random.Next(list.Count)];
        string hide2 = list[random.Next(list.Count)];
        string hide3 = list[random.Next(list.Count)];
        Console.WriteLine(hide1);
        Console.WriteLine(hide2);
        Console.WriteLine(hide3);

    }
    
}