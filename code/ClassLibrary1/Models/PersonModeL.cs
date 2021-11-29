namespace TrackerLibrary.Models
{/// <summary>
/// This class holds information about individual member of the team
/// </summary>
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }
        public PersonModel(){}

        public PersonModel(string firtName, string lastName, string emailAddress, string cellPhone)
        {
            FirstName = firtName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellphoneNumber = cellPhone;

        }

        public string FullName {

            get {
                return $"{FirstName} {LastName}";
            }

        }
    }
    
}