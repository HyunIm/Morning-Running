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
	const int MinLane = -2;
	const int MaxLane = 2;
	const float LaneWidth = 1.0f;

	CharacterController controller;

	Vector3 moveDirection = Vector3.zero;
	int targetLane;

	public float gravity;
	public float speedZ;
	public float speedX;
	public float speedJump;
	public float accelerationZ;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	private void Update()
	{
		if (Input.GetKeyDown("left")) MoveToLeft();
		if (Input.GetKeyDown("right")) MoveToRight();
		if (Input.GetKeyDown("space")) Jump();

		float acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
		moveDirection.z = Mathf.Clamp(acceleratedZ, 0, speedZ);

		float ratioX = (targetLane * LaneWidth - transform.position.x) / LaneWidth;
		moveDirection.x = ratioX * speedX;

		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection(moveDirection);
		controller.Move(globalDirection * Time.deltaTime);

		if (controller.isGrounded) moveDirection.y = 0;
	}

	public void MoveToLeft ()
	{
		if (controller.isGrounded && targetLane > MinLane) targetLane--;
	}

	public void MoveToRight ()
	{
		if (controller.isGrounded && targetLane < MaxLane) targetLane++;
	}

	public void Jump ()
	{
		if (controller.isGrounded)
		{
			moveDirection.y = speedJump;
		}
	}
}
