using System.ComponentModel.DataAnnotations;

namespace TestProject.Entities
{
    public class RequestModel
    {
        [Key]
        public int RequestId { get; set; }      
        public string Description { get; set; } 
        public int UserId { get; set; } 
        public bool IsApproved { get; set; }    
        public string Comment { get; set; }
    }
}