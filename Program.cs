using JsonToFile;

FileHandling fh = new();
string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/file.json";

//AddData();
RetrieveData();

void AddData()
{
    Data dataSave = new();
    dataSave.persons = new List<Person>();
    dataSave.persons.Add(new Person() { Id = 5, Name = "Greta Gunthenberg", Selected = true });
    dataSave.persons.Add(new Person() { Id = 12, Name = "Jason Bourne", Selected = true });
    dataSave.persons.Add(new Person() { Id = 55, Name = "Gudrun Min Gudrun", Selected = false });

    fh.ObjectToJsonToFile(path, dataSave);
}

void RetrieveData()
{
    if (File.Exists(path))
    {
        Data? dataLoad = fh.FileToJsonToObject<Data>(path);
        if (dataLoad != null && dataLoad.persons != null)
        {
            foreach (Person p in dataLoad.persons)
            {
                Console.WriteLine($"Name: {p.Name}, Id: {p.Id}, Selected: {p.Selected}");
            }
        }
    }
    else
    {
        Data dataSave = new();
        dataSave.persons = new();
        fh.ObjectToJsonToFile(path, dataSave);
    }
}