namespace VDesignProject.Web.ViewModels.TodoItems
{
    using VDesignProject.Common.Mapping;
    using VDesignProject.Data.Models;

    public class TodoItemViewModel : IMapFrom<TodoItem>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}
