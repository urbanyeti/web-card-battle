public abstract class Card : ICard
{
	public Guid Id;
	public Guid CardId;
	public string Description;
	public int Value;
	
	public virtual Result Use();
}

public class AttackCard : Card
{
	public CardResult Use()
	{
		var cardResult = new CardResult(true);
		return cardResult;
	}
	
}

public class CardResult : IResult
{
	public CardResult (bool isSuccess)
	{
		IsSuccess = isSuccess;
	}
	
	public bool IsSuccess { get; }
}