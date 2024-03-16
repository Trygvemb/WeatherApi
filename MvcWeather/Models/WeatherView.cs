
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Telerik.Scaffolders.Models
{
    public class WeatherView
    {
        [ScaffoldColumn(false)]
        public int ProductID
        {
            get;
            set;
        }

        [Required]
        [DisplayName("Product name")]
        public string ProductName
        {
            get;
            set;
        }

        [DisplayName("Unit price")]
        [DataType(DataType.Currency)]
        [Range(0, int.MaxValue)]
        public decimal UnitPrice
        {
            get;
            set;
        }

        [DisplayName("Units in stock")]
        [DataType("Integer")]
        [Range(0, int.MaxValue)]
        public int UnitsInStock
        {
            get;
            set;
        }

        public bool Discontinued
        {
            get;
            set;
        }
    }
}

