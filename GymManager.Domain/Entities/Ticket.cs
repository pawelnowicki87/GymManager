﻿namespace GymManager.Domain.Entities;

public class Ticket
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
    public bool IsPaid { get; set; }
    public string Token { get; set; }
    public DateTime CreatedDate { get; set; }
    public int TicketTypeId { get; set; }
    public TicketType TicketType { get; set; }
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }
    public Invoice Invoice { get; set; }
}