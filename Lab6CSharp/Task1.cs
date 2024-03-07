namespace Task1
{
    public interface IDisplayable
    {
        void Show();
    }

    public interface IOrganization
    {
        string Name { get; }
        string Address { get; }
    }

    public interface IComparable
    {
        int CompareTo(object obj);
    }

    public interface ICloneable
    {
        object Clone();
    }

    public class Organization : IOrganization, IDisplayable
    {
        public string Name { get; protected set; }
        public string Address { get; protected set; }

        public Organization(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Organization: \t\t{Name} \nAddress: \t\t{Address}");
        }
    }

    public class InsuranceCompany : Organization, IDisplayable
    {
        protected string insuranceType;

        public InsuranceCompany(string name, string address, string insuranceType) : base(name, address)
        {
            this.insuranceType = insuranceType;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Type of insurance: \t{insuranceType}");
        }
    }

    public class OilCompany : Organization, IDisplayable
    {
        protected string specialization;

        public OilCompany(string name, string address, string specialization) : base(name, address)
        {
            this.specialization = specialization;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Specialization: \t{specialization}");
        }
    }

    public class Factory : Organization, IDisplayable
    {
        protected string productType;

        public Factory(string name, string address, string productType) : base(name, address)
        {
            this.productType = productType;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Type of product: \t{productType}");
        }
    }

    class Program
    {
        public static void Main_Task1()
        {
            IDisplayable[] organizations = new IDisplayable[]
            {
                new InsuranceCompany("Insurance Company 1", "Address 1", "Auto insurance"),
                new OilCompany("Oil and Gas Company 1", "Address 2", "Oil and gas extraction"),
                new Factory("Factory 1", "Address 3", "Electronics"),
                new InsuranceCompany("Insurance Company 2", "Address 4", "Medical insurance"),
                new Factory("Factory 2", "Address 5", "Mechanical engineering")

            };

            Console.WriteLine("\nArray of organizations: \n");
            foreach (IDisplayable org in organizations)
            {
                org.Show();
                Console.WriteLine();
            }
        }
    }
}