using Binding;

namespace sdk
{
    public partial class SDK
    {
        public partial string Login()
        {
            //return "login by ios";

            var encryption = new TriosProxy();
            string s = encryption.InitFor;

            return s;
        }
    }
}
