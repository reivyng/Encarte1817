using Entity.Model.Security;

namespace Data.Interfaces.Security
{
    public interface IRolUserData : IBaseModelData<RolUser>
    {
        Task<bool> UpdatePartial(RolUser rolUser);
    }
}
