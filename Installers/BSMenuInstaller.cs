using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace BatSaber
{
	internal class BSMenuInstaller : Installer<BSMenuInstaller>
	{
		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<BatController>().AsSingle();
		}
	}
}
