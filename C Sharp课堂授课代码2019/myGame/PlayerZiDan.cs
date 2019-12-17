using UnityEngine;
using System.Collections;

public class PlayerZiDan : MonoBehaviour {

	public GameObject liziEffect;
	//static int score=0;
	int score=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag!="Player") 
		{
			Destroy (other.gameObject);
		}



		if (other.gameObject.tag=="enemy"||other.gameObject.tag=="enemyplan")//子弹碰到两种类型敌人，子弹立即销毁
		{

			Destroy(gameObject);
			Debug.Log("score:"+score);
			if (other.gameObject.tag=="enemy") {
				score=1;
				GameManager.Instance.AddScore(score);
				Debug.Log("score:"+score);
			}
			else if (other.gameObject.tag=="enemyplan")
			{
				score=2;
				GameManager.Instance.AddScore(score);
				Debug.Log("score:"+score);
			}
		}
		GameObject lizi_clone = Instantiate (liziEffect, other.transform.position, liziEffect.transform.rotation)as GameObject;
		Destroy (lizi_clone.gameObject, 0.5f);

	}
}
