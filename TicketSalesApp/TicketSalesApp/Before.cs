namespace Before_origianl
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

        public bool HasInvitation()
        {
            return invitation != null;
        }

        public bool HasTicket()
        {
            return ticket != null;
        }

        public void SetTicket(Ticket ticket)
        {
            this.ticket = ticket;
        }

        public void MinusAmount(int amount)
        {
            amount -= amount;
        }

        public void PlusAmount(int amount)
        {
            amount += amount;
        }
    }

    public class Audience
    {
        public Bag bag;

        public Audience(Bag bag)
        {
            this.bag = bag;
        }

        public Bag GetBag()
        {
            return bag;
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

        public TicketOffice GetTicketOffice()
        {
            return ticketOffice;
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
            if (audience.GetBag().HasInvitation())
            {
                Ticket ticket = ticketSeller.GetTicketOffice().GetTicket();
                audience.GetBag().SetTicket(ticket);
            }
            else
            {
                Ticket ticket = ticketSeller.GetTicketOffice().GetTicket();
                audience.GetBag().MinusAmount(ticket.GetFee());
                ticketSeller.GetTicketOffice().PlusAmount(ticket.GetFee());
                audience.GetBag().SetTicket(ticket);
            }
        }
    }
}