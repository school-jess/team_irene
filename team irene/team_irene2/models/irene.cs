namespace team_irene2.models
{
    public class irene
    {
        public string fullName
        {
            get
            {
                string fullNameToRet = "";
                fullNameToRet += $"{Capitalize(_firstName)} ";
                if (middleInitial != "")
                {
                    fullNameToRet += $"{middleInitial.ToUpper()}. ";
                }
                if (suffix != "")
                {
                    fullNameToRet += $"{Capitalize(_lastName)} ";
                    fullNameToRet += suffix;
                }
                else
                {
                    fullNameToRet += Capitalize(_lastName);
                }
                return fullNameToRet;
            }
        }

        public int age
        {
            get
            {
                int age_shadow = DateTime.Now.Year - _birthDay.Year;
                if (DateTime.Now < _birthDay.AddYears(age_shadow))
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
                return $"{_houseNumber} {_street}, {_barangay}, {_city}, {_province}, {_country}";
            }
        }

        public string firstName
        {
            get => _firstName; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide first name input");
                }
                _firstName = value;
            }
        }
        private string _firstName { get; set; }

        public string middleInitial { get; set; }

        public string lastName
        {
            get => _lastName; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide last name input");
                }
                _lastName = value;
            }
        }
        public string _lastName { get; set; }

        public string suffix { get; set; }

        public string birthDay
        {
            get => _birthDay.ToString(); set
            {
                string format = "yyyy-MM-dd";
                try
                {
                    _birthDay = DateTime.ParseExact(value, format, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public DateTime _birthDay { get; set; }

        public string houseNumber
        {
            get => _houseNumber; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide house number input");
                }
                _houseNumber = value;
            }
        }
        private string _houseNumber { get; set; }

        public string street
        {
            get => _street; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide street input");
                }
                _street = value;
            }
        }
        private string _street { get; set; }

        public string barangay
        {
            get => _barangay;
            set
            {
                if (value == "")
                {
                    throw new Exception("Must provide barangay input");
                }
                _barangay = value;
            }
        }
        private string _barangay { get; set; }

        public string city
        {
            get => _city;
            set
            {
                if (value == "")
                {
                    throw new Exception("Must provide barangay input");
                }
                _city = value;
            }
        }
        private string _city { get; set; }

        public string province
        {
            get => _province;

            set
            {
                if (value == "")
                {
                    throw new Exception("Must provide province input");
                }
                _country = value;
            }
        }
        private string _province { get; set; }
        public string country
        {
            get => _country; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide country input");
                }
            }
        }
        private string _country { get; set; }
        private static string Capitalize(string stringToRet)
        {
            return $"{stringToRet[0].ToString().ToUpper()}{stringToRet[1..]}";
        }
    }
}


