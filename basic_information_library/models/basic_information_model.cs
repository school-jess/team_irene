namespace basic_information_library.models
{
    public class BasicInformation
    {
        public string fullName
        {
            get
            {
                string fullNameToRet = "";
                fullNameToRet += $"{Capitalize(_firstName)} ";
                if (_middleInitial != "")
                {
                    fullNameToRet += $"{_middleInitial.ToUpper()}. ";
                }
                if (_suffix != "")
                {
                    fullNameToRet += $"{Capitalize(_lastName)} ";
                    fullNameToRet += _suffix;
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
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of first name");
                }
                _firstName = value;
            }
        }
        private string _firstName { get; set; }

        public string middleInitial
        {
            get => _middleInitial; set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of middle initial");
                }
                _middleInitial = value;
            }
        }

        private string _middleInitial { get; set; }

        public string lastName
        {
            get => _lastName; set
            {
                if (value == "")
                {
                    throw new Exception("Must provide last name input");
                }
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of last name");
                }
                _lastName = value;
            }
        }
        public string _lastName { get; set; }

        public string suffix
        {
            get => _suffix; set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of suffix");
                }
                _suffix = value;
            }
        }

        private string _suffix { get; set; }

        public string birthDay
        {
            get => _birthDay.ToString("yyyy-MM-dd"); set
            {
                if (value == "")
                {
                    throw new Exception("Must provide birthday input");
                }
                string format = "yyyy-MM-dd";
                _birthDay = DateTime.ParseExact(value, format, System.Globalization.CultureInfo.InvariantCulture);
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
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of street");
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
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of barangay");
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
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of city");
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
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of province");
                }
                _province = value;
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
                if (value.Any(char.IsDigit))
                {
                    throw new Exception("Number inside of country");
                }
                _country = value;
            }
        }
        private string _country { get; set; }

        private static string Capitalize(string stringToRet)
        {
            return $"{stringToRet[0].ToString().ToUpper()}{stringToRet[1..]}";
        }
    }
}


