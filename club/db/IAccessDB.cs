using System.Collections.Generic;

namespace clubApp.db
{
    interface IAccessDB<T>
    {
        List<T> FindAll(string criterio);
        T FindbyKey(params object[] key);
        bool SaveObj();
    }
}
