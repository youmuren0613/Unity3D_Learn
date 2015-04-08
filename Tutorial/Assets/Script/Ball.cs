using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		this.rigidbody.velocity = new Vector3(-10.0f, 9.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 其他游戏对象跑出屏幕之外时的处理
	void OnBecameInvisible()
	{
		// 销毁该游戏对象
		// 注意这里的参数！
		// Destory(this) 只会销毁组件
		Destroy(this.gameObject);
	}
}
