using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
	public CandyHolder candyHolder;
	public int reward;

	void OnTriggerEnter (Collider other)
	{
		// 指定数だけCandyのストックを増やす
		candyHolder.AddCandy (reward);

		if (other.gameObject.tag == "Candy") {
			// オブジェクトを削除
			Destroy (other.gameObject);
		}
	}
}
