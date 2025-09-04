namespace DemoMVC.Models
{
    public class Tuoi
    {
        public string FullName { get; set; }
        public int YearOfBirth { get; set; }
        public int Age 
        {
            get
            {
                return DateTime.Now.Year - YearOfBirth;
            }
        }

    }
}