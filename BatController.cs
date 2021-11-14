using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace BatSaber
{
	internal class BatController : IInitializable
	{
		private ParticleSystem batParticles;
		public void Initialize() {
			GameObject bats = GameObject.Find("Bats");
			batParticles = bats.GetComponent<ParticleSystem>();

			batParticles.emissionRate = Plugin.Settings.emissionRate;
			batParticles.maxParticles = 100000;
			batParticles.startLifetime = 10.0f;
			ParticleSystem.ShapeModule batParticlesShape = batParticles.shape;
			batParticlesShape.radius = Plugin.Settings.emissionRadius;
			ParticleSystem.ForceOverLifetimeModule batParticlesFol = batParticles.forceOverLifetime;
			batParticlesFol.xMultiplier = Plugin.Settings.batSpeed;
			batParticlesFol.zMultiplier = Plugin.Settings.batSpeed;

			GameObject logoE = GameObject.Find("LogoE");
			if (Plugin.Settings.burnOutE) {
				GameObject.Find("EFlickering").SetActive(false);
				logoE.SetActive(false);
			}

			if (Plugin.Settings.eOnFloor) {
				GameObject floorE = GameObject.Instantiate(logoE, new Vector3(5.0f, 0.1f, -3.0f), Quaternion.Euler(90.0f, 120.0f, 0.0f));
				floorE.SetActive(true);
				SpriteRenderer floorERenderer = floorE.GetComponent<SpriteRenderer>();
				floorERenderer.color = new Color(0.6f, 0.0f, 0.0f, 0.6f);
			}
		}
	}
}
