/**
 * @file : ScrollObject.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 14
 * @brief : 배경 스크롤
 */

 /* ================= 출처 =================
  * 책 제목 : 유니티 5로 만드는 3D/2D 스마트폰 게임 개발
  * https://github.com/Jpub/Unity5SmartphoneGameDev/blob/master/Projects/FlappySeal/Assets/Scripts/ScrollObject.cs
  * ========================================
  * 
  * ============== 변경된 점 ===============
  * speed 변수 : static 한 값에서 dynamic한 값으로 수정
  * 컴포넌트에 메시지를 보내는 부분 삭제
  * ========================================
  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour {

	public float speed;	// 이동할 속도	(static -> dynamic)
	public float startPosition;	// 시작 지점
	public float endPosition;	// 끝나는 지점

	void Update ()
	{
		// 매 프레임 x 포지션을 조금씩 이동시킨다
		transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

		// 스크롤이 목표 지점까지 도달했는지 체크
		if (transform.position.x <= endPosition) ScrollEnd();
	}

	void ScrollEnd()
	{
		// 스크롤할 거리 만큼을 되돌린다
		transform.Translate(-1 * (endPosition - startPosition), 0, 0);
	}
}
