using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	void OnTriggerEnter (Collider hit)
	{
		// 接触対象はPlayerタグですか？
		if (hit.CompareTag ("Player")) {

			// このコンポーネントを持つGameObjectを破棄する
			Destroy(gameObject);
		}
	}
}
