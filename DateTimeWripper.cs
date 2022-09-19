namespace MySharedAssembly
{
    public class DateTimeWrapper
    {
        public DateTime CurrentDateTime => DateTime.Now;

        public override string ToString()
        {
            return this.CurrentDateTime.ToLongTimeString();
        }
    }
}