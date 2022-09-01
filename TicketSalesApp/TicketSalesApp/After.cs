namespace After
{ 
    public class Invitation 
    {
        public DateTime when;
    }

    public class Ticket
    {
        private int fee;

        public int GetFee()
        {
            return fee;
        }
    }

    public class Bag 
    {
        private int amount;
        private Invitation invitation;
        private Ticket ticket;

        public Bag(int amount)
        {
            this.amount = amount;
        }

        public Bag(Invitation invitation, int amount)
        {
            this.invitation = invitation;
            this.amount = amount;
        }

        private bool HasInvitation()
        {
            return invitation != null;
        }

        public bool HasTicket()
        {
            return ticket != null;
        }

        private void SetTicket(Ticket ticket)
        {
            this.ticket = ticket;
        }

        private void MinusAmount(int amount)
        {
            amount -= amount;
        }

        public void PlusAmount(int amount)
        {
            amount += amount;
        }

        public int Hold(Ticket ticket)
        {
            if (HasInvitation())
            {
                SetTicket(ticket);
                return 0;
            }
            else
            {
                MinusAmount(ticket.GetFee());
                SetTicket(ticket);
                return ticket.GetFee();
            }
        }
    }

    public class Audience
    {
        private Bag bag;

        public Audience(Bag bag)
        {
            this.bag = bag;
        }

        public int Buy(Ticket ticket)
        {
            return bag.Hold(ticket);
        }
    }

    public class TicketOffice
    {
        private int amount;
        private List<Ticket> tickets = new List<Ticket>();

        public TicketOffice(int amount, List<Ticket> tickets)
        {
            this.amount = amount;
            this.tickets = tickets;
        }

        public Ticket GetTicket()
        {
            var ticket = tickets[0];
            tickets.RemoveAt(0);
            return ticket;
        }

        public void MinusAmount(int amount)
        {
            this.amount -= amount;
        }

        public void PlusAmount(int amount)
        {
            this.amount += amount;
        }
    }

    public class TicketSeller
    {
        private TicketOffice ticketOffice;

        public TicketSeller(TicketOffice ticketOffice)
        {
            this.ticketOffice = ticketOffice;
        }

        public void SellTo(Audience audience)
        {
            ticketOffice.PlusAmount(audience.Buy(ticketOffice.GetTicket()));
        }
    }

    public class Theater
    {
        private TicketSeller ticketSeller;

        public Theater(TicketSeller ticketSeller)
        {
            this.ticketSeller = ticketSeller;
        }   

        public void Enter(Audience audience)
        {
            this.ticketSeller.SellTo(audience);
        }
    }
}