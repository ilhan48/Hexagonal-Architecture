namespace Core.Application.Ports.Driven.Core.Abstracts;

public interface IQuery<T>
{
    IQueryable<T> Query();
}