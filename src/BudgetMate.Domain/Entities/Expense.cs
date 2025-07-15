using BudgetMate.Domain.Enums;

namespace BudgetMate.Domain.Entities;

public class Expense
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public ExpenseCategory Category { get; set; } = ExpenseCategory.General;
    public int UserId { get; set; }
}
