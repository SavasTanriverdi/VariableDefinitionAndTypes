namespace VariableDefinitionAndTypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Integer türü bir değişken tanımlama
            int age = 25;
            System.Console.WriteLine("Age: " + age);
            
            // String türü bir değişken tanımlama
            string name = "John Doe";
            System.Console.WriteLine("Name: " + name);

            // Double türü bir değişken tanımlama
            double height = 5.9;
            System.Console.WriteLine("Height: " + height + " feet");

            // Boolean türü bir değişken tanımlama
            bool isStudent = true;
            System.Console.WriteLine("Is Student: " + isStudent);

            // Char türü bir değişken tanımlama
            char grade = 'A';
            System.Console.WriteLine("Grade: " + grade);

            // Var anahtar kelimesi ile otomatik türetilen değişken
            var message = "Hello, World!";
            System.Console.WriteLine("Message: " + message);

            // Const ile sabit bir değişken tanımlama
            const double Pi = 3.14159;
            System.Console.WriteLine("Value of Pi: " + Pi);

            // Değişkenlerde tür dönüşümü
            string ageAsString = age.ToString();
            System.Console.WriteLine("Age as String: " + ageAsString);

            int stringToInt = int.Parse("100");
            System.Console.WriteLine("Parsed Integer: " + stringToInt);
        }
    }
}