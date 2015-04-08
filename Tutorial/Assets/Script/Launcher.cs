using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	// 小球的预设
	// 通过检视器设置具体值
	public GameObject	ballPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// 如果按下鼠标左键（按下瞬间的处理）⋯⋯
		if(Input.GetMouseButtonDown(1)) {

			// 实例化小球的预设（生成游戏对象）
			Instantiate(this.ballPrefab);
		}	
	}
}
