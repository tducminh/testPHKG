



namespace sdk
{
	// All the code in this file is included in all platforms.
	public interface Sdk
	{
        public void Init();
		
        public string Login();

        public string UploadFile();

        public string GetFile();

        public string UpdatPermission();

        public string BackUp();

        public string Restore();
    }
}
