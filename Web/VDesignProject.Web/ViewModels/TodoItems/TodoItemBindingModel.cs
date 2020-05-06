namespace VDesignProject.Web.ViewModels.TodoItems
{
    using System.ComponentModel.DataAnnotations;

    using VDesignProject.Common.Mapping;
    using VDesignProject.Data.Models;

    public class TodoItemBindingModel : IMapTo<TodoItem>
    {
        [Required]
        public string Title { get; set; }
    }
}
