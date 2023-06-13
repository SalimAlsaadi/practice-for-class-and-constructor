
namespace practiceForClassAndConstructors
{
     class Constructor
    {
       
        public long id;
        public string name;
        public string grade;
        public string registrationNumber;

        public Constructor(long id, string name, string registrationNumber)//constructor. must be same name of class name.
        {
            this.id = id;
            this.name = name;
            this.registrationNumber = registrationNumber;
            //stdDo();
            Console.WriteLine("student name: " + name + " student id: " + id + " student registrationNumber: " + registrationNumber + " is pass with perfect grade");

        }

        public void stdDo()//method. we can use in any where
        {
            Console.WriteLine("student name: " + name + " student id: " + id + " student registrationNumber: " + registrationNumber + " is pass with perfect grade");
        }
    }
}
