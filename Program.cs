namespace UD_2_listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos una lista para almanecenar Person
            List<Person> personas = new List<Person>();

            // Definimos una serie de Persons
            Person alonso = new Person("Alonso", 32);
            Person maria = new Person("María", 18);
            Person susana = new Person("Susana", 29);
            Person sonia = new Person("Sonia", 14);
            Person eduardo = new Person("Eduardo", 34);

            // Añadimos las personas a la lista
            personas.Add(alonso);
            personas.Add(maria);
            personas.Add(susana);
            personas.Add(sonia);
            personas.Add(eduardo);

            // Mostramos por pantalla los componentes de la lista
            foreach (Person person in personas)
            {
                Console.WriteLine($"The person {person.Name} is {person.Edad} years old");
            }

            // Obtenemos la edad media mediante LINQ (tambien se podria hacer con un bucle, pero es mas costoso)
            double edadMedia = personas.Average(persona => persona.Edad);
            Console.WriteLine($"The average age of people is {edadMedia}");

            // Obtenemos ahora las personas mayores de 25 años
            List<Person> personasMayoresDe25 = personas.Where(persona => persona.Edad > 25).ToList();

            // Mostramos por pantalla los componentes de la lista mayores de 25
            Console.WriteLine($"The following people are over 25 years old");
            foreach (Person person in personasMayoresDe25)
            {
                Console.WriteLine($"{person.Name}");
            }
        }
    }
}