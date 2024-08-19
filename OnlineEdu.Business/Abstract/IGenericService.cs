using System;
using System.Linq.Expressions;

namespace OnlineEdu.Business.Abstract;

public interface IGenericService<T> where T : class
{
        List<T> TGetList();

    T TGetByFilter(Expression<Func<T,bool>> predicate);
    
    T TGetById(int id);
    void TCreat(T entity);

    void TUpdate(T entity);

    void TDelete(int id);

    int TCount();

    int TFilteredCount(Expression<Func<T,bool>> predicate);


    List<T> TGetFilteredList(Expression<Func<T,bool>> predicate);

}
