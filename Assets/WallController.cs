using UnityEngine;
using UnityEngine.EventSystems; // EventSystems をインポート必要

public class WallController : MonoBehaviour, IPointerDownHandler {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// IPointerDownHandler のインターフェース
	public void OnPointerDown (PointerEventData eventData) {
		// Raycast が当たった3D座標を表示
		Debug.Log (eventData.worldPosition);
	}
}
