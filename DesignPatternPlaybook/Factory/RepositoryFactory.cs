using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlaybook.Factory
{

    //design Patterns On-Ramp (Hfdst.5.)
    public static class RepositoryFactory 
    {
        public static IPersonRepository GetRepository(string repositoryType)
        {
            IPersonRepository repo = null;

            switch(repositoryType)
            {
                case "Service": repo = new ServiceRepository();
                    break;
                case "Sql": repo = new SqlRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid Repository Type");
            }
            
            return repo;

        }
    }
}
