 /**
  * @file : MenuController.cs
  * @author : 임현 (hyunzion@gmail.com)
  * @since : 2017 - 12 - 17
  * @brief : 하단 메뉴 컨트롤러
  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
	public GameObject Menu;			// 하단 메뉴
	public GameObject preBackground1;	// 다른 배경
	public GameObject preBackground2;	// 다른 배경
	public GameObject preBackground3;	// 다른 배경
	public GameObject postBackground;   // 다른 배경

	/// <summary>
	/// @title : BackgroundMove ()
	/// @brief : 버튼에 해당되는 UnderBackground를 제외하고 다른 곳으로 옮김
	/// </summary>
	public void BackgroundMove ()
	{
		preBackground1.transform.localPosition = new Vector3(-7, 0, 0);
		preBackground2.transform.localPosition = new Vector3(-7, 0, 0);
		preBackground3.transform.localPosition = new Vector3(-7, 0, 0);
		postBackground.transform.localPosition = new Vector3(0, 0, 0);
	}
}
