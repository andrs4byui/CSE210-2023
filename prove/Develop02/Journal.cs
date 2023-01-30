public class Journal{
    List<object> _entries = new List<object>();
    Entry oneEntry = new Entry();
    public void DisplayEntries(){

        _entries.Add(oneEntry.journalInput);
        
        for(int i=0;i<_entries.Count;i++)
            {
            Console.WriteLine(_entries[i]);
            }
    }
}