﻿using ng2trello_backend.Models.Serializable;

namespace ng2trello_backend.Models
{
  public class Content
  {
    public Content()
    {

    }

    public Content(SerContent content)
    {
      Id = content.Id;
      CardId = content.CardId;
      Text = content.Text;
      ImageUrl = content.ImageUrl;
    }

    public int Id { get; set; }
    public int CardId { get; set; }
    public string Text { get; set; }
    public string ImageUrl { get; set; }
  }
}
