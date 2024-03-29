using System.ComponentModel.DataAnnotations;

namespace Hospital.entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }

        public List<Medicine> Medicine { get; set; }
        public List<Category> Categories { get; set; }

    }
}
