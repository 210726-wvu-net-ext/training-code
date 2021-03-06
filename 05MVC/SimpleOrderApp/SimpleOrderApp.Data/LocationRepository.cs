using System.Collections.Generic;
using System.Linq;
using SimpleOrderApp.Data.Model;
using SimpleOrderApp.Domain;

namespace SimpleOrderApp.Data
{
    public class LocationRepository : ILocationRepository
    {
        private readonly SimpleOrderContext _context;

        public LocationRepository(SimpleOrderContext context)
        {
            context.Database.EnsureCreated();
            _context = context;
        }

        // this method's job is to somehow get a collection of locations
        // not location entities. therefore it has to convert from location entities
        // it gets from the dbcontext. (mapping)

        /// <summary>
        /// Get all locations, without order history
        /// </summary>
        /// <returns>The locations</returns>
        /// <remarks>
        /// this method's job is to somehow get a collection of locations
        /// not location entities. therefore it has to convert from location entities
        /// it gets from the dbcontext. (mapping)
        /// </remarks>
        public IEnumerable<Location> GetAll()
        {
            // query from DB
            var entities = _context.Locations.ToList();

            // map to domain model
            return entities.Select(e => new Location(e.Name, e.Stock));
        }

        public void Create(Location location)
        {
            // map to EF model
            var entity = new LocationEntity { Name = location.Name, Stock = location.Stock };

            _context.Locations.Add(entity);

            // write changes to DB
            _context.SaveChanges();
        }

        // only support changing stock
        public void Update(Location location)
        {
            // query the DB
            var entity = _context.Locations.First(l => l.Name == location.Name);

            entity.Stock = location.Stock;

            // write changes to DB
            _context.SaveChanges();
        }

        public void Delete(string name)
        {
            // query the DB
            var entity = _context.Locations.First(x => x.Name == name);

            _context.Remove(entity);

            // write changes to DB
            _context.SaveChanges();
        }
    }
}
