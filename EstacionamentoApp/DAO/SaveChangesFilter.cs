using System.Web.Mvc;


// Custom filter to save changes after all DAO calls.
public class SaveChangesFilter : ActionFilterAttribute
{
    private ApplicationDbContext db;

    public SaveChangesFilter(ApplicationDbContext db)
    {
        this.db = db;
    }

    public override void OnResultExecuted(ResultExecutedContext filterContext)
    {
        if (filterContext.Exception == null)
        {
            db.SaveChanges();
        }

        db.Dispose();
    }
}
