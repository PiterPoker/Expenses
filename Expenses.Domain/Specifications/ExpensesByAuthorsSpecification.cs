using Expenses.Domain.Entities;
using Expenses.Domain.SeedWork;

namespace Expenses.Domain.Specifications;

public class ExpensesByAuthorsSpecification : BaseSpecification<Expense>
{
    public ExpensesByAuthorsSpecification(List<long> authorIds)
        : base(e => authorIds.Contains(e.Author.Id))
    {
        AddInclude(e => e.Author);
    }
}