namespace team_irene2.models
{
    public class irene
    {
        public string fullName
        {
            get
            {
                string fullNameToRet = "";
                fullNameToRet += $"{Capitalize(firstName)} ";
                if (middleInitial != "")
                {
                    fullNameToRet += $"{middleInitial.ToUpper()}. ";
                }
                if (suffix != "")
                {
                    fullNameToRet += $"{Capitalize(lastName)} ";
                    fullNameToRet += suffix;
                }
                else
                {
                    fullNameToRet += Capitalize(lastName);
                }
                return fullNameToRet;
            }
        }

        public int age
        {
            get
            {
                int age_shadow = DateTime.Now.Year - __birthDay.Year;
                if (DateTime.Now < __birthDay.AddYears(age_shadow))
                {
                    age_shadow--; // Adjust if birthday hasn't occurred this year yet
                }
                return age_shadow;
            }
        }
        public string address
        {
            get
            {
                return $"{houseNumber} {street}, {barangay}, {city}, {province}, {country}";
            }
        }

        public string firstName
        {
            get => firstName; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide first name input");
                }
                firstName = value;
            }
        }
        public string? middleInitial { get; set; }
        public string lastName
        {
            get => lastName; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide last name input");
                }
                lastName = value;
            }
        }
        public string? suffix { get; set; }

        public string birthDay
        {
            get => birthDay; set
            {
                try
                {
                    __birthDay = Convert.ToDateTime(value);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public DateTime __birthDay { get; set; }

        public string houseNumber
        {
            get => houseNumber; set
            {
                if (houseNumber == "")
                {
                    throw new Exception("Must provide house number input");
                }
                houseNumber = value;
            }
        }
        public string street
        {
            get => street; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide street input");
                }
                street = value;
            }
        }
        public string barangay
        {
            get => barangay;
            set
            {
                if (value == "")
                {
                    throw new Exception("Must provide barangay input");
                }
                barangay = value;
            }
        }
        public string province
        {
            get => province;
            set
            {
                if (value == "")
                {
                    throw new Exception("Must provide province input");
                }
                province = value;
            }
        }
        public string city
        {
            get => city; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide city input");
                }
                city = value;
            }
        }
        public string country
        {
            get => country; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide country input");
                }
                country = value;
            }
        }

        private static string Capitalize(string stringToRet)
        {
            return $"{stringToRet[0].ToString().ToUpper()}{stringToRet[1..]}";
        }
    }
}
