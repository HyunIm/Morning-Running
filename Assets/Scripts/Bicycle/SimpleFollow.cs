/**
 * @file : SimpleFollow.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 17
 * @brief : 카메라가 오브젝트 따라가기
 */

 /// 출처 : SimpleFollow.cs (유니티 5로 만드는 3D/2D 스마트폰 게임 개발)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour
{
	Vector3 diff;

	public GameObject target;
	public float followSpeed;

	private void Start ()
	{
		diff = target.transform.position - transform.position;
	}

	private void LateUpdate()
	{
		transform.position = Vector3.Lerp(
			transform.position,
			target.transform.position - diff,
			Time.deltaTime * followSpeed
			);
	}
}
