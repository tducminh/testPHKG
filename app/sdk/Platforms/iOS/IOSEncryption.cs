using Binding;


namespace sdk
{
    // All the code in this file is only included on iOS.
    public class IOSEncryption
    {
        public IOSEncryption()
        {
        }

        public string Login()
        {
            TriosProxy proxy = new TriosProxy();
            string s = proxy.InitFor;
            return s;
        }
    }
}
