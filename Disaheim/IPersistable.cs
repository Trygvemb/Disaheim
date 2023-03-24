using System;
namespace Disaheim
{
	public interface IPersistable
	{
		public void Save(string fileName);
		public void Load(string fileName);
	}
}

