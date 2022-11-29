using MoqExample;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoqExamples
{
    internal class ProductsService
    {
        private IDatabase database;

        public ProductsService(IDatabase database)
        {
            this.database = database;
        }
    }
}
