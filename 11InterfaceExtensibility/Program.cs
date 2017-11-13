using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtensibility
{
    class Program
    {
        //We can use interfaces to change the behaviour of application by extending
        //If a class is dependant on an interface, we can supply it at runtime
        //This way the behaviour of the application changes without any impact on that class
       

        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            DbMigrator dbMigrator2 = new DbMigrator(new FileLogger(AppDomain.CurrentDomain.BaseDirectory + "\\log.txt"));
            dbMigrator2.Migrate();
        }
    }
}
