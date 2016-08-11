namespace Spinframe.Common
{
    using System;
    using System.Collections.Generic;

    public static class RandomGenerator
    {
        private static readonly Random Random = new Random();

        public static string GetRandomClientName()
        {
            var clients = new[] { "Aliquam Fringilla Limited", "Sapien Aenean LLC", "Mauris Associates", "A Associates", "Risus Corp", "Aenean Euismod Foundation", "Ornare LLC", "Tellus Limited", "Diam At Pretium Corp", "Sed Consequat Corp", "Molestie Foundation", "Ut Odio Inc", "Phasellus Fermentum Ltd", "Elementum Lorem Ut Consulting", "Ridiculus Mus Institute", "Massa Inc", "Sodales Nisi Associates", "Mollis Lectus Pede Associates", "In Company", "Proin Nisl Sem Corporation", "Eget Metus LLP", "Etiam Incorporated", "Praesent Consulting", "Vitae Mauris Company", "A Arcu Consulting", "At Corporation", "Eu PC", "Sed Pede Cum Industries", "Eu Sem Limited", "Phasellus LLP", "Maecenas Company", "Aliquet Institute", "Dignissim Company", "Eget PC", "Metus Facilisis Lorem Inc", "Eu Corp", "Vitae LLC", "Id Magna Et Ltd", "Arcu Industries", "Ac Facilisis Incorporated", "Augue Id Inc", "Donec Industries", "Nunc Est Associates", "Arcu Iaculis Ltd", "Sed Consequat LLC", "Est Inc", "Ullamcorper Industries", "Mauris Blandit Enim LLC", "Sed Libero Proin Limited", "Pede Nec Ante Incorporated", "Felis Eget Limited", "Sem Consequat Nec Company", "Dolor LLP", "Bibendum Ullamcorper Industries", "Ante Company", "Aliquam Limited", "Donec Institute", "Tellus Institute", "Ut Pellentesque Eget Company", "Turpis Corporation", "Suspendisse Dui Institute", "Ipsum Ac Inc", "Vestibulum Associates", "Tempus Institute", "Hendrerit Inc", "Praesent Eu Institute", "Mus Proin Ltd", "Montes Nascetur Ridiculus Industries", "Phasellus Libero Foundation", "Ac Libero Nec Limited", "Tempor Augue Ac Consulting", "Aliquam Eu Accumsan PC", "Morbi Accumsan Ltd", "Lorem Limited", "Nulla Company", "Sed Dictum Eleifend Associates", "Iaculis Aliquet Incorporated", "Cum Sociis Natoque PC", "Odio A Consulting", "Quis Urna Incorporated", "Tellus Aenean Corp", "Neque Sed Incorporated", "Sed Dolor Foundation", "Magna A Tortor Ltd", "Nec Ante Ltd", "Consequat PC", "Eget Volutpat LLP", "Vestibulum Mauris Magna LLP", "Est Mauris Institute", "Cursus LLC", "Donec Egestas Duis Limited", "Tempus Mauris Industries", "Nec Ante Associates", "Id Libero Institute", "Quis Turpis Vitae Inc", "Nam Nulla Magna Industries", "Sit Amet Dapibus Foundation", "Ligula Elit Inc", "Quis Tristique Corp", "Et Company" };

            return clients[Random.Next(0, clients.Length)];
        }

        public static string GetRandomCompanyName()
        {
            var companies = new[] { "Mauris Ut Quam Associates", "Etiam Corporation", "Sit Amet Ante Associates", "Nulla Tincidunt Neque LLP", "Amet Metus Aliquam Corporation", "Elit Pellentesque A Foundation", "Leo LLP", "Ac Orci Ut Consulting", "Nec Associates", "Cubilia Institute", "Mus Proin Vel Industries", "Ornare Associates", "Dolor Nonummy Consulting", "Id Risus Foundation", "Malesuada Ut Consulting", "Sagittis Placerat Corporation", "Interdum Ligula Eu Limited", "Nulla Semper Tellus Associates", "Elit Consulting", "Risus Inc", "Maecenas Company", "Erat Eget Tincidunt Consulting", "Eleifend Nunc Risus Limited", "Blandit Viverra Institute", "Facilisis Non Bibendum LLP", "Nonummy Ac Institute", "Arcu Inc", "Ultrices Sit Amet Institute", "Sociis Natoque Penatibus Associates", "Mi Fringilla Institute", "Metus Industries", "Risus Limited", "Risus At Corporation", "Enim Mauris Foundation", "Tincidunt Nunc Associates", "Pede Nunc Sed LLC", "Erat Eget Ltd", "Vivamus Euismod Urna Industries", "Amet Company", "Ut Company", "Blandit Nam Nulla Incorporated", "Luctus Felis Purus LLP", "Aliquam Ultrices Consulting", "Aenean Sed Pede Company", "Nam Incorporated", "Aliquet Molestie Foundation", "Ultrices Posuere Cubilia Ltd", "Cras Consulting", "Laoreet Libero LLP", "Tempus Eu Ligula Consulting", "Commodo Corporation", "Curabitur LLP", "Facilisis PC", "Nunc Sed Company", "Maecenas Mi Felis PC", "Erat Semper Rutrum Incorporated", "Quis LLP", "Turpis Nulla Incorporated", "Ligula Institute", "Per Company", "Semper Inc", "Duis Associates", "Praesent Incorporated", "Metus Consulting", "Justo Proin Consulting", "Leo PC", "Fringilla Mi Lacinia Corp", "Id Consulting", "A Ltd", "Augue Scelerisque Limited", "Tristique Pharetra Quisque Limited", "Commodo Hendrerit Industries", "Sem Molestie PC", "Torquent Per Incorporated", "Dui LLC", "Commodo Institute", "Neque Vitae Semper Industries", "Cras Vulputate Velit Incorporated", "Arcu Institute", "Eget Massa Corporation", "Ac Mattis LLP", "Fermentum Fermentum Limited", "Porttitor Industries", "Vulputate PC", "Consequat Auctor Nunc Inc", "Iaculis Lacus LLP", "Nam Corp", "Metus Vivamus PC", "Dolor Quisque Tincidunt LLP", "Lectus Quis Corp", "Nulla Ante Iaculis Institute", "Ligula Elit Pretium Foundation", "Praesent Eu Industries", "Aliquet Nec Consulting", "Sit Industries", "Dignissim Consulting", "Neque Consulting", "Nulla Industries", "Dolor Quam LLP", "Tristique Consulting" };

            return companies[Random.Next(0, companies.Length)];
        }

        public static string GetRandomCarMake()
        {
            var cars = new[] { "Alfa Romeo", "Audi", "Bugatti", "Citroen", "Fiat", "Jaguar", "Mercedes", "Suzuki", "Tesla", };

            return cars[Random.Next(0, cars.Length)];
        }

        public static string GetRandomCarModel()
        {
            var cars = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            return cars[Random.Next(0, cars.Length)];
        }

        public static DateTime GetRandomDateTime(int? fromYear = null, int? toYear = null)
        {
            fromYear = fromYear ?? 1920;
            toYear = toYear ?? 2050;
            var year = Random.Next((int)fromYear, (int)toYear + 1);
            var month = Random.Next(1, 13);
            var day = Random.Next(1, 29);
            var hour = Random.Next(1, 24);
            var minute = Random.Next(1, 60);
            var seconds = Random.Next(1, 60);
            var milliseconds = Random.Next(1, 100);

            return new DateTime(year, month, day, hour, minute, seconds, milliseconds);
        }

        public static string GetRandomPhone()
        {
            var randomPhone = $"{RandomGenerator.GetRandomInt(100, 999).ToString()}-{RandomGenerator.GetRandomInt(1000, 9999).ToString()}-{RandomGenerator.GetRandomInt(1000, 9999).ToString()}";
            return randomPhone;
        }

        public static string GetRandomFirstName()
        {
            var firstNames = new[] { "Callum", "Yen", "Kaden", "Tarik", "Emily", "Plato", "Lane", "Burke", "Buckminster", "Virginia", "Henry", "Elizabeth", "Giselle", "Macy", "Dalton", "Samuel", "Bevis", "Gareth", "Gregory", "Wallace", "Medge", "Ali", "William", "Gary", "Levi", "Buckminster", "James", "Stuart", "Logan", "Timothy", "Virginia", "Oscar", "Hu", "Mariko", "Wyoming", "Yoshi", "Cairo", "Timon", "Lael", "Gail", "Alexis", "Wing", "Kameko", "Mara", "Teagan", "Colin", "Isabelle", "Bert", "Angelica", "Fulton", "John", "Illana", "Lance", "Rose", "Melissa", "Jason", "Dorothy", "Minerva", "Dorothy", "Amanda", "Guy", "Zoe", "Ivy", "Keely", "Freya", "Chanda", "Tanek", "Leah", "Yeo", "Quinn", "Grace", "Garth", "Kieran", "Cassady", "Idona", "Eleanor", "Holmes", "Jordan", "Malik", "Levi", "Tobias", "Angelica", "Hollee", "Alexa", "Sarah", "Althea", "Paki", "Harding", "Raven", "Dale", "Hollee", "Plato", "Ariana", "Teagan", "Phoebe", "Odessa", "Maryam", "Jerry", "Dakota", "Deirdre" };

            return firstNames[Random.Next(0, firstNames.Length)];
        }

        public static int GetRandomInt(int minValue, int maxValue)
        {
            return Random.Next(minValue, maxValue + 1);
        }

        public static string GetRandomLastName()
        {
            var lastNames = new[] { "Cooper", "Chen", "Daugherty", "Johnson", "Mccarthy", "Gutierrez", "Ball", "Casey", "Mcfarland", "Dawson", "Cook", "Hensley", "Wiley", "Morgan", "Frederick", "Price", "Oneal", "Shaw", "Mcdaniel", "Barry", "Dickson", "Rice", "Coffey", "Mckinney", "Davidson", "Mccall", "Gonzales", "Davenport", "Suarez", "Bennett", "Glass", "Valdez", "Lowe", "Mendez", "Nichols", "Stout", "Lee", "Wiley", "Lowery", "Whitney", "Delgado", "Golden", "Sargent", "Hensley", "Whitley", "Walsh", "Rutledge", "Parrish", "Lucas", "Bentley", "Wilkinson", "Byers", "Humphrey", "Ortega", "Nieves", "Blankenship", "Rojas", "Howe", "Jennings", "Sampson", "Stout", "Davidson", "Joyner", "Mercado", "Burnett", "Hill", "Oneal", "Fuentes", "Ortega", "Hendricks", "Everett", "Carpenter", "Noel", "Luna", "Phelps", "Sloan", "Norton", "Bonner", "Horton", "Weber", "Hester", "Phelps", "Webb", "Mcbride", "Stanton", "Floyd", "White", "Ashley", "Mcknight", "Hyde", "Strickland", "Griffith", "Kirk", "Strickland", "Hyde", "Mclean", "Douglas", "West", "Kline", "Haley" };

            return lastNames[Random.Next(0, lastNames.Length)];
        }

        public static ICollection<T> GetRandomsFrom<T>(IList<T> collection)
        {
            var random = new Random();
            var numberOfItems = random.Next(1, collection.Count);
            var collectionToReturn = new HashSet<T>();

            for (int i = 0; i < numberOfItems; i++)
            {
                var index = random.Next(0, collection.Count);
                collectionToReturn.Add(collection[index]);
            }

            return collectionToReturn;
        }
    }
}
