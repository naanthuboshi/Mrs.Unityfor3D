using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyControler : MonoBehaviour {

	//ゲームオーバを表示するテキスト
	private GameObject MainCamera;



	// Use this for initialization
	void Start () {
		//シーン中のMainCameraオブジェクトを取得
		this.MainCamera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
	//カメラのZ座標と障害物のZ座標の差でかめらのZ座標が大きい場合
		if (this.transform.position.z < this.MainCamera.transform.position.z) {
	//障害物は破棄する
			Destroy(gameObject,0.0f);
		}
	}
}
