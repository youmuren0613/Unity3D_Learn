using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	protected float	jump_speed = 12.0f;			// 起跳时的初始速度
	public bool		is_landing = false;			// 着陆过程中

	// Use this for initialization
	void Start () {

		this.is_landing = false;	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// 如果正在着陆⋯⋯
		if(this.is_landing) {

			// 点击鼠标左键（按下的瞬间）⋯⋯
			if(Input.GetMouseButtonDown(0)) {

				// 将落地标记设置为false（意味着未落地）
				this.is_landing = false;

				// 用向上的速度起跳
				this.rigidbody.velocity = Vector3.up*this.jump_speed;

				// 在点击鼠标左键的瞬间（起跳瞬间），
				// 使游戏暂停
				//Debug.Break();
			}
		}	
	}

	// 和其他游戏对象发生冲突时
	void OnCollisionEnter(Collision collision)
	{
		// 如果碰撞对象的tag是“Floor”
		if(collision.gameObject.tag == "Floor") {

			// 开始落地
			this.is_landing = true;
		}
	}
}
