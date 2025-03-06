namespace team_irene2.models
{
    public class irene
    {
        public string fullName {get {
            string fullNameToRet = "";
            fullNameToRet += $"{Capitalize(firstName)} ";
            if (middleInitial != "") {
                fullNameToRet += $"{middleInitial.ToUpper()}. ";
            }
            if (suffix != "") {
                fullNameToRet += $"{Capitalize(lastName)} ";
                fullNameToRet += suffix;
            } else {
                fullNameToRet += Capitalize(lastName);
            }
            return fullNameToRet;
        }}

        public int age {
            get {
                int age_shadow = DateTime.Now.Year - __birthDay.Year;
                if (DateTime.Now < __birthDay.AddYears(age_shadow))
                {
                    age_shadow--; // Adjust if birthday hasn't occurred this year yet
                }
                return age_shadow;
            }
        }
        public string address {get {
            return $"{houseNumber} {street}, {barangay}, {city}, {province}, {country}";
        }}
        
        public string firstName {get; set;}
        public string middleInitial {get; set;}
        public string lastName {get; set;}
        public string suffix {get; set;}

        public string birthDay {get=>birthDay; set {
            try {
                __birthDay = Convert.ToDateTime(value);
            } catch (Exception e) {
                throw new Exception(e.Message);
            }
        }}
        public DateTime __birthDay {get; set;}

        public string houseNumber {get; set;}
        public string street {get; set;}
        public string barangay {get; set;}
        public string province {get; set;}
        public string city {get; set;}
        public string country {get; set;}

        private static string Capitalize(string stringToRet) {
            return $"{stringToRet[0].ToString().ToUpper()}{stringToRet[1..]}";
        }
    }
}
