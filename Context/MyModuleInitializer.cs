using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Context
{
    public class MyModuleInitializer
    {
        [ModuleInitializer]
        public static void Initialize()
        {
            //Seta variavel do PostgreSQL para evitar erro na gravacao do TIMESTAMP
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}