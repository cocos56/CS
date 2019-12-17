using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	GameObject enemyParent;//生成敌人的坐标点--父物体
	Vector3[] points;//随机生成敌人坐标点
	
	public GameObject[] enemys;//敌人预设--含敌人和敌人飞机

	float speed=10f;//敌人飞行速度（两种敌人）
	float rotspeed=3f;//敌人旋转速度
	float zidanspeed=15f;//敌人发射子弹速度一定要大于敌人飞行速度，若相等的话，子弹在敌人飞机上，看不到敌人子弹发射的效果
	Ray enemyray;//敌人飞机射线
	public	GameObject enemyzidan;//敌人子弹预设

	// Use this for initialization
	void Start () {
		enemyParent = GameObject.Find ("EnemyParent");
		points = new Vector3[enemyParent.transform.childCount];
		for (int i = 0; i < points.Length; i++) {//随机生成敌人坐标点
			points[i]=enemyParent.transform.GetChild(i).transform.position;
		}
		InvokeRepeating ("CloneEnemy", 2f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void CloneEnemy()
	{
		int random_point_index=Random.Range(0,points.Length); //克隆敌人的随机点
		int random_enemys_index=Random.Range(0,enemys.Length);//克隆的敌人：飞机和旋转敌人，随机取一个
		GameObject Enemy=enemys[random_enemys_index];//enemys数组--含敌人和敌人飞机，随机取一个
		GameObject clonEnemy=GameObject.Instantiate(Enemy,points[random_point_index],Enemy.transform.rotation)as GameObject;
		clonEnemy.rigidbody.velocity=Vector3.back*speed;//速度也能产生位移，世界坐标系下
		if (clonEnemy.tag=="enemy") 
		{
			Debug.Log(clonEnemy.name);
			clonEnemy.rigidbody.AddTorque(Vector3.up*rotspeed,ForceMode.Impulse);//敌人旋转	
		}

		if(clonEnemy.tag=="enemyplan")
		{
			enemyray=new Ray(clonEnemy.transform.position,Vector3.back);	
			//克隆子弹
			GameObject clonEnemyZidan=Instantiate(enemyzidan,enemyray.origin,enemyzidan.transform.rotation)as GameObject;
			clonEnemyZidan.rigidbody.AddForce(enemyray.direction*zidanspeed,ForceMode.Impulse);
		}
	}

}
