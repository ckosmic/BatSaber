using IPA.Config.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace BatSaber
{
	internal class SettingsStore
	{
		public float emissionRate = 2000.0f;
		public float emissionRadius = 25.0f;
		public float batSpeed = 1.0f;
		public bool burnOutE = true;
		public bool eOnFloor = true;
	}
}
