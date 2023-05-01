using Microsoft.EntityFrameworkCore;
using SyncFProject.BLL;
using SyncFProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly TransactionDatabaseContext context;

        public TransactionRepository(TransactionDatabaseContext context) : base(context)
        {
            this.context = context;
        }

        //public Task<IEnumerable<Transaction>> GetTransactionByCategory(int amount)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<Transaction>> Search(int amount)
            => await context.Transactions.Where(E => E.Amount==amount).ToListAsync();

    }
}
