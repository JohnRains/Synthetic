using Bogus;

namespace Synthetic
{
    public class GenerateSynthetic
    {
        public enum Gender  
        {
            Male,
            Female
        }

        private static int userId = 1;

        private static Faker<__Person> fakeData = new Faker<__Person>("en_US")
            .RuleFor(p => p.Id, f => userId++)
            .RuleFor(p => p.RandomId, f => f.Random.Number(1, 1000))
            .RuleFor(p => p.Gender, f => f.PickRandom<Gender>().ToString())
            .RuleFor(p => p.Title, f => f.Name.Prefix(f.Person.Gender))
            .RuleFor(p => p.FirstName, f => f.Name.FirstName(f.Person.Gender))
            .RuleFor(p => p.MiddleName, f => f.Name.FirstName(f.Person.Gender))
            .RuleFor(p => p.LastName, f => f.Name.LastName(f.Person.Gender))
            .RuleFor(p => p.StreetAddress, f => f.Address.StreetAddress())
            .RuleFor(p => p.StreetName, f => f.Address.StreetName())
            .RuleFor(p => p.City, f => f.Address.City())
            .RuleFor(p => p.State, f => f.Address.State())
            .RuleFor(p => p.ZipCode, f => f.Address.ZipCode())
            .RuleFor(p => p.Phone, f => f.Phone.PhoneNumber("(###)-###-####"))
            .RuleFor(p => p.Email, (f, p) => f.Internet.Email(p.FirstName, p.LastName))
            .RuleFor(p => p.SSN, f => f.Random.Replace("###-##-####"))
            .RuleFor(p => p.DOB, f => f.Date.Past(18))
        ;

        public static Faker<__Person> FakeData => fakeData;

    }
}
