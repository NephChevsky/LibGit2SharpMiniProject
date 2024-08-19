using LibGit2Sharp;

namespace ClassLibrary
{
	public class Class1
	{
		public IRepository Repository;

		public void Init(string path)
		{
			Repository = new Repository(path);
		}
	}
}
