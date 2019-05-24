namespace KitcPPW.Filters.Exception
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException(string entityName, string key) :base($"Entity {entityName} with primary key {key} was not found.")
        {

        }
    }
}
