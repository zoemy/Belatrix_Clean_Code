namespace SOLID._02_OpenClosed
{
    public class Employee : BaseEmployee
    {
        public Employee(int id, string name) : base(id, name) { }

        public override decimal CalculateBonus(decimal salary) => salary * .05M;
    }

    public class PermanentEmployee : BaseEmployee
    {
        public PermanentEmployee(int id, string name) : base(id, name){}

        public override decimal CalculateBonus(decimal salary) => salary * .1M;
    }

    public abstract class BaseEmployee
    {
        public BaseEmployee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public override string ToString() => string.Format("{0}-{1}", Id, Name);

        public abstract decimal CalculateBonus(decimal salary);
    }
}