using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	float power=10f;//玩家子弹弹射速度
	float rotspeed=1f;//按键后玩家左右移动的速度
	GameObject player;//玩家
	Ray myray;//玩家射线
	public	GameObject playerzidan;//玩家子弹预设
	public float m_life=10;//玩家的生命力


	public Transform m_explosionFx;//爆炸特效
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
		//玩家随鼠标位置任意滑动
		Vector3 mousPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);//Input.mousePosition为二维矢量，将其转化为三维矢量
		player.transform.position = new Vector3 (mousPos.x, player.transform.position.y, mousPos.z);
		
		//A键玩家左移
		if (Input.GetKey(KeyCode.A)) {
			player.transform.position+=Vector3.right*rotspeed;
		}
		//A键玩家右移
		if (Input.GetKey(KeyCode.D)) {
			player.transform.position+=Vector3.left*rotspeed;
		}
		
		//玩家打子弹
		myray = new Ray (player.transform.position, Vector3.forward);//射线位置和方向
		//绘制射线颜色和长度
		Debug.DrawRay (myray.origin, myray.direction * 20.0f, Color.red);
		if (Input.GetMouseButtonDown(0)) {//按下鼠标键
			//克隆子弹
			GameObject	clonZidan=Instantiate(playerzidan,myray.origin,playerzidan.transform.rotation)as GameObject;
			clonZidan.rigidbody.AddForce(myray.direction*power,ForceMode.Impulse);//给子弹加力向上弹射
		}
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log (other.gameObject.name);
		if (other.gameObject.tag=="enemy"||other.gameObject.tag=="enemyplan")
		{
			Debug.Log("m_life"+m_life);
			m_life--;
			if (m_life<=0) 
			{
				Instantiate(m_explosionFx,player.transform.position,Quaternion.identity);
				Destroy(gameObject);
			}
		}

		if (other.gameObject.tag=="EnemyRocket") 
		{
			Debug.Log("m_life"+m_life);
			m_life-=2;
			if (m_life<=0)
			{
				Instantiate(m_explosionFx,player.transform.position,Quaternion.identity);
				Destroy(gameObject);
			}
		}

		if (other.gameObject.tag!="PlayerRocket")
			{
				
				Destroy (other.gameObject);//销毁的是未加本脚本的对象
			}
	}
}