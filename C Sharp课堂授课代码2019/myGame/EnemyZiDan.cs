using UnityEngine;
using System.Collections;

public class EnemyZiDan : MonoBehaviour {

	public GameObject liziEffect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{
		//注释代码可让player立即死掉
//		if (other.gameObject.tag!="enemyplan") 
//		{
//			Destroy (other.gameObject);
//		}

		if (other.gameObject.tag=="Player") {
			Destroy(gameObject);
		}
		GameObject lizi_clone = Instantiate (liziEffect, other.transform.position, liziEffect.transform.rotation)as GameObject;
		Destroy (lizi_clone.gameObject, 0.5f);

	}
}
