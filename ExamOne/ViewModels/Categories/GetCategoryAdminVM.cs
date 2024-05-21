namespace ExamOne.ViewModels.Categories
{
    public class GetCategoryAdminVM
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string CreatedTime { get; set; }
        public string UpdatedTime { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
