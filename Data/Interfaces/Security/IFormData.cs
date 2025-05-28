using Entity.Model.Security;

namespace Data.Interfaces.Security
{
    public interface IFormData : IBaseModelData<Form>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Form form);
    }
}
