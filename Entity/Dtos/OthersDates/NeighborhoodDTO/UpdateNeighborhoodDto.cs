using Entity.Dtos.Base;
using Entity.Enums;

namespace Entity.Dtos.OthersDates.NeighborhoodDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un rol (operación GET ALL,CREATE,UPDATE(PATCH-PUT))
    /// </summary>
    public class UpdateNeighborhoodDto : GenericDto
    {
        public string CodePostal { get; set; }
        public string DistrictName { get; set; }
        public StreetType StreetType { get; set; }
        public string StreetNumber { get; set; }
        public StreetLetter StreetLetter { get; set; }
        public string SecondaryNumber { get; set; }
        public StreetLetter SecondaryLetter { get; set; }
        public string TertiaryNumber { get; set; }
        public string AdditionalNumber { get; set; }
        public StreetLetter AdditionalLetter { get; set; }
    }
}