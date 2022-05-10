using JsonToFile;


FileHandling fh = new();

AddData();
RetrieveData();

void AddData()
{
    Data dataSave = new Data();
    dataSave.persons = new List<Person>();
    dataSave.persons.Add(new Person() { Id = 5, Name = "Greta Gunthenberg", Selected = true });
    dataSave.persons.Add(new Person() { Id = 12, Name = "Jason Bourne", Selected = true });
    dataSave.persons.Add(new Person() { Id = 55, Name = "Gudrun Min Gudrun", Selected = false });

    fh.ObjectToJsonToFile(dataSave);
}

void RetrieveData()
{
    Data dataLoad = fh.FileToJsonToObject<Data>();
    foreach (Person p in dataLoad.persons)
    {
        Console.WriteLine($"Name: {p.Name}, Id: {p.Id}, Selected: {p.Selected}");
    }
}