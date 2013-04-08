using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Raven.Client.Document;

namespace Domain.Integrations
{
    public class RavenIntegrationConnector : IIntegrationConnector
    {
        private static DocumentStore _ravenDb;

        public RavenIntegrationConnector()
        {
            Setup();
        }

        public IEnumerable<Character> GetCharacters()
        {

            using (var raven = _ravenDb.OpenSession())
            {
                var characters = raven.Query<Character>().OrderBy(c => c.Id);
                return characters;
            }
        }

        private void Setup()
        {
            _ravenDb = new DocumentStore { Url = "http://localhost:8080" };
            _ravenDb.Initialize();

            using (var raven = _ravenDb.OpenSession())
            {
                if (!raven.Query<Character>().Any())
                {
                    raven.Store(new Character() {Id = 0,  Name = "general" });
                    raven.Store(new Character() {Id = 1,  Name = "captain" });
                    raven.Store(new Character() {Id = 2,  Name = "innkeeper" });
                    raven.Store(new Character() {Id = 3,  Name = "magistrate" });
                    raven.Store(new Character() {Id = 4,  Name = "priest" });
                    raven.Store(new Character() {Id = 5,  Name = "aristocrat" });
                    raven.Store(new Character() {Id = 6,  Name = "merchant" });
                    raven.Store(new Character() {Id = 7,  Name = "printer" });
                    raven.Store(new Character() {Id = 8,  Name = "rogue" });
                    raven.Store(new Character() {Id = 9,  Name = "spy" });
                    raven.Store(new Character() {Id = 10, Name = "apothecary" });
                    raven.Store(new Character() {Id = 11, Name = "mercenary" });
                    raven.SaveChanges();
                }
            }
        }

    }
}
