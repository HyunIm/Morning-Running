/**
 * @file : BicycleController.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 17
 * @brief : 자전거 컨트롤러
 */

 /// 출처 : NejikoController.cs (유니티 5로 만드는 3D/2D 스마트폰 게임 개발)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleController : MonoBehaviour
{
	CharacterController controller;

	Vector3 moveDirection = Vector3.zero;

	public float gravity;
	public float speedZ;
	public float speedJump;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	private void Update()
	{
		if (controller.isGrounded)
		{
			if (Input.GetAxis("Vertical") > 0.0f)
				moveDirection.z = Input.GetAxis("Vertical") * speedZ;
			else
				moveDirection.z = 0;

			transform.Rotate(0, Input.GetAxis("Horizontal") * 3, 0);

			if (Input.GetButton("Jump"))
			{
				moveDirection.y = speedJump;
			}
		}

		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection(moveDirection);
		controller.Move(globalDirection * Time.deltaTime);

		if (controller.isGrounded) moveDirection.y = 0;
	}
}
