using MiPrimerParcial.DAL;
using MiPrimerParcial.DAL.Entities;
using MiPrimerParcial.Domain.Interfaces;

namespace MiPrimerParcial.Domain.Services
{
    public class CountrySerice : ICountryService
    {
        private readonly DataBaseContext _context;

        public CountrySerice(DataBaseContext context)
        {
            _context = context
        }

        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            var countries = await _context.Countries.ToListAsync();

            return countries;
        }

        public async Task<Country> GetCountryByIdAsync(Guid id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            var country1 = await _context.Countries.FindAsync(id);
            var country2 = await _context.Countries.FirstAsync(c => c.Id == id);
            return country;
        }

        public async Task<Country> CreateCountryAsync(Country country)
        {
            try
            {
                country.Id = Guid.NewGuid();
                country.CreatedDate = DateTime.Now;
                _context.Countries.Add(country);

                await _context.SaveChangesAsync();
                return country;
            }
            catch (DbUptadeException dbUptadeException)
            {
                throw new Exception(dbUptadeException.InnerException?.Message ??
                    dbUptadeException.Message);
            }
        }

        public Task<Country> EditCountryAsync(Country country)
        {
            throw new NotImplementedException();
        }

        public Task<Country> DeleteCountryAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
