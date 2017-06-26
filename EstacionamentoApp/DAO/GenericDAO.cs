using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using EstacionamentoApp;

/// <summary>
/// Implementation of the IGenericDAO interface.
/// </summary>
/// <typeparam name="T">Type of the Model to be instanciated.</typeparam>
public abstract class GenericDAO<T> : IGenericDAO<T> where T : class
{
    // Replace with your current DB Context type, if needed.
    public database db;

    public T Add(T e)
    {
        db.Set<T>().Add(e);
        db.SaveChanges();
        return e;
    }

    public int AddRange(IEnumerable<T> e)
    {
        db.Set<T>().AddRange(e);
        return db.SaveChanges();
    }

    public T Get(int id)
    {
        return db.Set<T>().Find(id);
    }

    public IEnumerable<T> All([Optional]params string[] i)
    {
        // If there are no Includes, just returns the list of all entities.
        if (i.Count() == 0)
        {
            return db.Set<T>();
        }

        // Set a return variable.
        var r = db.Set<T>();

        // Loops through the includes and sets them to the list.
        foreach (var e in i)
        {
            r.Include(e);
        }

        // Returns the list with the included relationed entities.
        return r;
    }

    public IEnumerable<T> GetInterval(int itens, int id, [Optional]params string[] include)
    {
        return All(include).Skip(itens * (id - 1)).Take(itens);
    }

    public bool Update(T e)
    {
        try
        {
            db.Entry(e).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool Remove(T e)
    {
        try
        {
            db.Set<T>().Remove(e);
            db.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public int RemoveRange(IEnumerable<T> e)
    {
        db.Set<T>().RemoveRange(e);
        return db.SaveChanges();
    }

    #region Métodos auxiliares

    public bool RemoveById(int id)
    {
        return Remove(Get(id));
    }

    internal abstract void Get(ticket t);

    #endregion
}

public class ApplicationDbContext
{
    internal void SaveChanges()
    {
        throw new NotImplementedException();
    }
}