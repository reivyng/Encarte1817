using Entity.Model.OthersPerson;

namespace Data.Interfaces.OthersDates
{
    public interface INeighborhoodData : IBaseModelData<Neighborhood>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Neighborhood neighborhood);
    }
}
