using System.ComponentModel;

namespace Web.Odev.Domain.Models
{
    public enum  EUnitOfMeasurement : byte
    {
        [Description("S")]
        Unity = 1,

        [Description("M")]
        Milligram = 2,

        [Description("L")]
        Gram = 3,

        [Description("XL")]
        Kilogram = 4,

        [Description("XXL")]
        Liter = 5

    }
}