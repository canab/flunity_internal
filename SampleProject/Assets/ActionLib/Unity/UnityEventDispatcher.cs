using UnityEngine;
using ActionLib.Common;

namespace ActionLib.Unity
{
	internal class UnityEventDispatcher : MonoBehaviour
	{
		public readonly EventSender onStart = new EventSender();
		public readonly EventSender onDestroy = new EventSender();
		public readonly EventSender onUpdate = new EventSender();
		public readonly EventSender onFixedUpdate = new EventSender();

		void Start()
		{
			onStart.Dispatch();
		}

		void OnDestroy()
		{
			onDestroy.Dispatch();
		}

		void FixedUpdate()
		{
			onFixedUpdate.Dispatch();
		}

		void Update()
		{
			onUpdate.Dispatch();
		}
	}
}

