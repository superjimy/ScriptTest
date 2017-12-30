using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100; //体力
	private int power = 25; //攻撃力
	private int mp = 53; //魔法力
	private int mpower = 5; //魔法攻撃力
	//攻撃の関数
	public void Attack(){
		Debug.Log ("拳で" + this.power + "のダメージを与えた");
		}
	//魔法の関数
	public void Magic(){
		Debug.Log ("魔法で" + this.mpower + "のダメージを与えた");
		}

	//防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		//残りのhpを減らす
		this.hp -= damage;
	}
}

public class Test : MonoBehaviour {

	//Use this for initialization
	void Start () {
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss Lastboss = new Boss ();

		//攻撃用の関数を呼び出す
		Lastboss.Attack();
		//防御用の関数を呼び出す
		Lastboss.Defence(3);
		//魔法用の関数を呼び出す
		Lastboss.Magic();
}
		
	// Update is called once per frame
	void Update () {
		
	}
}
