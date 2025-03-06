namespace team_irene2.models
{
    public class irene
    {
        public string fullName {get {
            return $"{firstName} {middleInitial} {lastName}";
        }}

        public int age {get {
            return 
        }}
        public string address {get {
            return $"{houseNumber} {street}, {barangay}, {city}, {province}, {country}";
        }}
        
        public string firstName {get; set;}
        public string middleInitial {get; set;}
        public string lastName {get; set;}
        public string suffix {get; set;}

        public string birthDay {get; set;}

        public string houseNumber {get; set;}
        public string street {get; set;}
        public string barangay {get; set;}
        public string province {get; set;}
        public string city {get; set;}
        public string country {get; set;}
    }
}
