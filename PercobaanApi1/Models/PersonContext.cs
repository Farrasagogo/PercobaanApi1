namespace PercobaanApi1.Models
{
    public class PersonContext
    {
        public List<Person> ListPerson()
        {
            List<Person> list1 = new List<Person>();
            Object[,] arrayPerson = new Object[,]{
                    {1, "Budi", "Jember", "budi@gmail.com" },
                    {2, "Iwan", "Banyuwangi", "iwan@gmail.com" },
                    {3, "Wati", "Lumajang", "wati@gmail.com" }
                    };
                    for (int i = 0; i < arrayPerson.GetLength(0); i++)
                    {
                        list1.Add(new Person()
                        {
                            id_person = int.Parse(arrayPerson[i, 0].ToString()),
                            nama = arrayPerson[i, 1].ToString(),
                            alamat = arrayPerson[i, 2].ToString(),
                            email = arrayPerson[i, 3].ToString()
                        });
                    }
            return list1;
        }
        public Person FilterId(int id)
        {
            var person = ListPerson().Find(p => p.id_person == id);
            return person;
        }

    }
}
