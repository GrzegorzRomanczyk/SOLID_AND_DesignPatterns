namespace PersonGenerator_Good
{
    public class PersonValidator
    {
        public static bool Validate(Person user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}