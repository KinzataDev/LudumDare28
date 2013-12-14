using UnityEngine;
using System.Collections;

public class DestroyOnGarbage : MonoBehaviour {

	void OnTriggerEnter(Collider obj)
	{
		if(obj.gameObject.tag.Equals("GarbageCollector") )
		{
			Destroy(gameObject);
		}
	}

}
