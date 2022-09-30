namespace DomainEvents
{
    public class CustomerModel : DomainEntity
    {
        public int CustomerId { get; set; }
        public bool IsPreferred { get; set; }

        public void Preferred()
        {
            if (!IsPreferred)
            {
                IsPreferred = true;

                RaiseEvent(new CustomerIsPreferred { CustomerId = CustomerId });
            }
        }
    }

    public class CustomerIsPreferred : IEvent
    {
        public int CustomerId { get; set; }
    }
}
