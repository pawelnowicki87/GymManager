namespace GymManager.Domain.Entities;

public class Invoice
{
    public int Id { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal Value { get; set; }
    public string MethodOfMayment { get; set; }
    public DateTime CreatedDate { get; set; }
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }

}