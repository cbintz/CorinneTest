namespace CorinneTest
{
    public class PersonList
    {
        private static PersonList instance = null;

        private PersonList()
        {
        }

        public static PersonList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PersonList();
                }
                return Instance;
            }
        }
    }
}
