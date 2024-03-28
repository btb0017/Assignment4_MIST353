using EcoInvestAPI.Entities;

//Ryan Bankert
namespace EcoInvestAPI.Repositories
{
    public interface ICompanyRatingService
    {
        Task<List<Company>> GetCompanyClimateRating(int companyId);
    }
}
