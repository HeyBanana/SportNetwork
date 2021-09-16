using System.Collections.Generic;

namespace Sport.Network.Domain.Models
{
    public class SportType : BaseEntity
    {
        public string Name { get; set; }

        private readonly List<SportPlace> _sportPlaces = new();

        public IReadOnlyCollection<SportPlace> SportPlaces => _sportPlaces.AsReadOnly();
    }
}
