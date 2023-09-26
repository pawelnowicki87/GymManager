using Microsoft.AspNetCore.Identity;

namespace GymManager.Infrastructure.Identity
{
    public class LocalizedIdentityErrorDescriber :IdentityErrorDescriber
    {
        private const string Password = "Password";
        private const string Email = "Email";

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = Password,
                Description = "Hasło i potwierdzone hasło są różne."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = Password,
                Description = "Hasło musi zawierać przynajmniej jedną cyfrę."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = Password,
                Description = "Hasło musi zawierać przynajmniej jedną małą literę."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = Password,
                Description = "Hasło musi zawierać przynajmniej jeden znak specjalny (np. $, #, & itp."
            };
        }



        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = Password,
                Description = "Hasło musi zawierać przynajmniej jedną dużą litere."
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = Password,
                Description = "Hasło musi mieć co najmniej 8 znaków i nie więcej niż 100 znaków."
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = Email,
                Description = "Wybrany email jest już zajęty."
            };
        }
    }
}
