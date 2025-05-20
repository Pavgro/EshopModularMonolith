namespace Shared.DDD;

public interface IAggregatge<T> : IEntity<T>, IAggregatge
{

}

public interface IAggregatge : IEntity
{
    IReadOnlyList<IDomainEvent> DomainEvents { get; }
    IDomainEvent[] ClearDomainEvents();
}

