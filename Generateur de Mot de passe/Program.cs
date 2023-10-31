using System;
using System.Collections;
using System.Text;

namespace Generateur_de_Mot_de_passe
{
    class Password
    {
        private static ArrayList passwordsList = new ArrayList();

        public Password()
        {
            Description = "";
            Length = 12;
            UserAccount = "";
        }

        private string passwordValue;
        private string description;
        private string specialCharacters;

        public string LowerCaseCharacters => "abcdefghijklmnopqrstuvwxyz";
        public string DigitCharacters => "0123456789";

        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La description ne peut pas être vide.");

                description = value;
            }
        }

        public int Length { get; set; }
        public string UserAccount { get; set; }

        public string SpecialCharacters
        {
            get => specialCharacters;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Les caractères spéciaux ne peuvent pas être vides.");

                specialCharacters = value;
            }
        }

        public bool HasUppercaseCharacters { get; set; }
        public bool HasDigitCharacters { get; set; }
        public string UpperCaseCharacters => LowerCaseCharacters.ToUpper();

        public bool HasSpecialCharacters()
        {
            return !string.IsNullOrEmpty(specialCharacters);
        }

        public string GeneratePassword()
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            string validChars = LowerCaseCharacters;
            if (HasUppercaseCharacters)
                validChars += UpperCaseCharacters;
            if (HasDigitCharacters)
                validChars += DigitCharacters;
            if (HasSpecialCharacters())
                validChars += specialCharacters;

            for (int i = 0; i < Length; i++)
            {
                password.Append(validChars[random.Next(0, validChars.Length)]);
            }

            passwordValue = password.ToString();
            return passwordValue;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
