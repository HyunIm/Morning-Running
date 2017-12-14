 /**
  * @file : ReverseScrollObject.cs
  * @author : 임현 (hyunzion@gmail.com)
  * @since : 2017 - 12 - 14
  * @brief : 반대 방향 배경 스크롤
  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseScrollObject : ScrollObject
{
	void Update ()
	{
		// 매 프레임 x 포지션을 조금씩 이동시킨다
		transform.Translate(speed * Time.deltaTime, 0, 0);

		// 스크롤이 목표 지점까지 도달했는지 체크
		if (transform.position.x >= startPosition) ReverseScrollEnd();
	}

	private void ReverseScrollEnd()
	{
		// 스크롤할 거리 만큼을 되돌린다
		transform.Translate(-1 * (startPosition - endPosition), 0, 0);
	}
}
