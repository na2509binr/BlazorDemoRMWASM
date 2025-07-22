using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorDemoRMWASM.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public int MenuParentId { get; set; }
        public int Sort { get; set; }
        public bool ShowHeader { get; set; }
        public bool ShowFooter { get; set; }
        public bool Active { get; set; }

        [NotMapped]
        public List<Menu> Children { get; set; } = new();

    }
}
