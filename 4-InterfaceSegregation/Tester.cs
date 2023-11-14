namespace InterfaceSegregation
{
    public class Tester : ITestActivities, IWorkTeamActivities
    {
        public Tester()
        {
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}