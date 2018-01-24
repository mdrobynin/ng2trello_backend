﻿using System.Collections.Generic;
using System.Linq;
using ng2trello_backend.Models.Serializable;

namespace ng2trello_backend.Models
{
    public class Todolist
    {
        public int Id { get; set; }
        public string TodoIds { get; set; }
        public string Title { get; set; }

        public Todolist()
        {

        }

        public Todolist(SerTodolist todolist)
        {
            Id = todolist.Id;
            SetTodoIds(todolist.Todos.Select(x => x.Id).ToList());
            Title = todolist.Title;
        }

        public List<int> GetTodoIds()
        {
            return string.IsNullOrEmpty(TodoIds)
                ? new List<int>()
                : TodoIds.Split('#').Select(int.Parse).ToList();
        }

        public void SetTodoIds(List<int> todoIds)
        {
            TodoIds = string.Join('#', todoIds);
        }

        public void AddTodoId(int id)
        {
            if (GetTodoIds().Count < 1)
            {
                TodoIds = id.ToString();
            }
            else
            {
                TodoIds = TodoIds + '#' + id;
            }
        }

        public void DeleteTodoId(int id)
        {
            var currentIds = GetTodoIds();
            if (currentIds.Contains(id))
            {
                SetTodoIds(currentIds.Where(x => x != id).ToList());
            }
        }
    }
}
