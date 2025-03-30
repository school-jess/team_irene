namespace basic_information_library.models;

public class BasicInformation
{
    public int id { get; set; }

    public string first_name
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
            if (value.Length > 20)
            {
                throw new Exception("first name too long. Must be less than or equal to 20");
            }
            _firstName = Capitalize(value);
        }
    }

    public string middle_initial
    {
        get => _middleInitial; set
        {
            if (value.Any(char.IsDigit))
            {
                throw new Exception("Number inside of middle initial");
            }
            if (value.Length > 10)
            {
                throw new Exception("middle initial too long. Must be less than or equal to 10");
            }
            _middleInitial = Capitalize(value);
        }
    }

    public string last_name
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
            if (value.Length > 20)
            {
                throw new Exception("last name too long. Must be less than or equal to 20");
            }
            _lastName = Capitalize(value);
        }
    }

    public string suffix
    {
        get => _suffix; set
        {
            if (value.Any(char.IsDigit))
            {
                throw new Exception("Number inside of suffix");
            }
            if (value.Length > 10)
            {
                throw new Exception("suffix too long. Must be less than or equal to 10");
            }
            _suffix = value;
        }
    }

    public string full_name
    {
        get
        {
            string fullNameToRet = "";
            fullNameToRet += $"{_firstName} ";
            if (_middleInitial != "")
            {
                fullNameToRet += $"{_middleInitial.ToUpper()}. ";
            }
            if (_suffix != "")
            {
                fullNameToRet += $"{_lastName} ";
                fullNameToRet += _suffix;
            }
            else
            {
                fullNameToRet += _lastName;
            }
            return fullNameToRet;
        }
    }

    public DateTime birthday
    {
        get => _birthDay; set
        {
            _birthDay = value;
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

    public string house_number
    {
        get => _houseNumber; set
        {
            if (value == "")
            {
                throw new Exception("Must provide house number input");
            }
            if (value.Length > 10)
            {
                throw new Exception("suffix too long. Must be less than or equal to 10");
            }
            _houseNumber = value;
        }
    }

    public string street_name
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
            if (value.Length > 20)
            {
                throw new Exception("suffix too long. Must be less than or equal to 20");
            }
            _street = Capitalize(value);
        }
    }

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
            if (value.Length > 20)
            {
                throw new Exception("suffix too long. Must be less than or equal to 20");
            }
            _barangay = Capitalize(value);
        }
    }

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
            if (value.Length > 20)
            {
                throw new Exception("suffix too long. Must be less than or equal to 20");
            }
            _city = Capitalize(value);
        }
    }

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
            if (value.Length > 20)
            {
                throw new Exception("suffix too long. Must be less than or equal to 20");
            }
            _country = Capitalize(value);
        }
    }

    public string full_address
    {
        get
        {
            return $"{_houseNumber} {_street}, {_barangay}, {_city}, {_province}, {_country}";
        }
    }

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
            if (value.Length > 20)
            {
                throw new Exception("suffix too long. Must be less than or equal to 20");
            }
            _province = Capitalize(value);
        }
    }

    private string _firstName, _middleInitial, _lastName, _suffix, _houseNumber, _street, _barangay, _city, _province, _country;
    public DateTime _birthDay;

    private static string Capitalize(string origStr)
    {
        string strToRet = "";
        bool isFirstChar = true;
        for (int j = 0; j < origStr.Length; j++)
        {
            if (origStr[j] == ' ')
            {
                isFirstChar = true;
                strToRet += " ";
                continue;
            }
            if (isFirstChar)
            {
                strToRet += origStr[j].ToString().ToUpper();
                isFirstChar = false;
            }
            else
            {
                strToRet += origStr[j].ToString().ToLower();
            }
        }
        return strToRet;
    }
}
