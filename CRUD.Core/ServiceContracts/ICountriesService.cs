using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface ICountriesService
    {
       Task< CountryResponse> AddCountry(CountryAddRequest? request);

       Task< List<CountryResponse>> GetAllCountries();
        Task< CountryResponse?> GetCountryByCountryId(Guid? countryId);

    }
}
