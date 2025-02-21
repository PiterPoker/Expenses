using Expenses.Domain.Entities;

namespace Expenses.Domain.Interfaces.Repositories;

/// <summary>
/// Интерфейс для репозитория расходов.
/// </summary>
public interface IExpenseRepository : IRepository<Expense>
{
    /// <summary>
    /// Получает список расходов за определенный период времени.
    /// </summary>
    /// <param name="startDate">Начальная дата периода.</param>
    /// <param name="endDate">Конечная дата периода.</param>
    /// <returns>Список расходов.</returns>
    Task<List<Expense>> GetExpensesByPeriodAsync(DateTime startDate, DateTime endDate);

    /// <summary>
    /// Получает список расходов по определенной категории.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    /// <returns>Список расходов.</returns>
    Task<List<Expense>> GetExpensesByCategoryIdAsync(int categoryId);

    /// <summary>
    /// Получает список расходов по определенному кошельку.
    /// </summary>
    /// <param name="walletId">Идентификатор кошелька.</param>
    /// <returns>Список расходов.</returns>
    Task<List<Expense>> GetExpensesByWalletIdAsync(int walletId);
}