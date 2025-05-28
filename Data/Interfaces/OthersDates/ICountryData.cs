﻿using Entity.Model.OthersPerson;

namespace Data.Interfaces.OthersDates
{
    public interface ICountryData : IBaseModelData<Country>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Country country);
    }
}
