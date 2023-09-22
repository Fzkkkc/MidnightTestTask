using System.Collections;
using UnityEngine;

namespace MidnightTestTask.Scripts.CameraPreference
{
	public class CameraFollow : MonoBehaviour 
	{
		[SerializeField] private string _carObjectName;
		public Transform СarTransform;
		
		[Range(1, 10)]
		public float followSpeed = 2;
		[Range(1, 10)]
		public float lookSpeed = 5;
		Vector3 initialCameraPosition;
		Vector3 initialCarPosition;
		Vector3 absoluteInitCameraPosition;

		private IEnumerator Start()
		{
			while (СarTransform == null)
			{
				СarTransform = GameObject.Find(_carObjectName)?.transform;
				yield return null; 
			}
			
			initialCameraPosition = gameObject.transform.position;
			initialCarPosition = СarTransform.position;
			absoluteInitCameraPosition = initialCameraPosition - initialCarPosition;
		}

		private void FixedUpdate()
		{
			if (СarTransform == null)
			{
				return;
			}
			
			Vector3 _lookDirection = (new Vector3(СarTransform.position.x, СarTransform.position.y, СarTransform.position.z)) - transform.position;
			Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookSpeed * Time.deltaTime);
		
			Vector3 _targetPos = absoluteInitCameraPosition + СarTransform.transform.position;
			transform.position = Vector3.Lerp(transform.position, _targetPos, followSpeed * Time.deltaTime);

		}

	}
}
