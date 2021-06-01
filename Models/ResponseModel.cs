using System.Data;
namespace SampleTemplate.Models
{
    public class ResponseModel
    {
        public DataTable data { get; set; }
        public string errorMessage { get; set; }
    }
}