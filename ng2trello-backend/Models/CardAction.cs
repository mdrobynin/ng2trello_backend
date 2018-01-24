﻿using ng2trello_backend.Models.Serializable;

namespace ng2trello_backend.Models
{
  public class CardAction
  {
    public CardAction()
    {

    }

    public CardAction(SerCardAction cardAction)
    {
      Id = cardAction.Id;
      CardId = cardAction.CardId;
      Text = cardAction.Text;
      ParticipantId = cardAction.ParticipantId;
    }

    public int Id { get; set; }
    public int CardId { get; set; }
    public string Text { get; set; }
    public int ParticipantId { get; set; }
  }
}