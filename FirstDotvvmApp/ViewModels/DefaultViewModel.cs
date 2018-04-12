using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using System.ComponentModel.DataAnnotations;

namespace FirstDotvvmApp.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public List<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();

        public ToDoItem ToDoItem { get; set; } = new ToDoItem();

        public DefaultViewModel()
        {
        }

        public void AddTodoItem(ToDoItem item)
        {
            ToDoItems.Add(ToDoItem);
            ToDoItem = new ToDoItem();
        }

        public void MarkAsDone(ToDoItem item)
        {
            item.IsDone = true;
        }
    }

    public class ToDoItem
    {
        [Required(ErrorMessage = "Task Text is required!")]
        public string Text { get; set; }

        public bool IsDone { get; set; }
    }
}