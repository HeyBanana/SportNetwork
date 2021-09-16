using System.Collections.Generic;

namespace Sport.Network.Domain.Models
{
    public class SportPlace : BaseEntity
    {
        public string Coords { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        private readonly List<SportType> _sportTypes = new();

        public IReadOnlyCollection<SportType> SportTypes => _sportTypes.AsReadOnly();
    }
}
