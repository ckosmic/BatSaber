using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using IPA;
using IPA.Config;
using IPA.Config.Stores;
using UnityEngine.SceneManagement;
using UnityEngine;
using IPALogger = IPA.Logging.Logger;
using SiraUtil.Zenject;

namespace BatSaber
{
	[Plugin(RuntimeOptions.SingleStartInit)]
	public class Plugin
	{
		internal static Plugin Instance { get; private set; }
		internal static IPALogger Log { get; private set; }
		internal static SettingsStore Settings { get; private set; }

		[Init]
		public void Init(IPALogger logger, Config config, Zenjector zenject) {
			Instance = this;
			Log = logger;
			Settings = config.Generated<SettingsStore>();
			zenject.OnMenu<BSMenuInstaller>();
		}
	}
}
