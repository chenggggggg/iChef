using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
