/**
 * @file : GameController.cs
 * @author : 임현 (hyunzion@gmail.com)
 * @since : 2017 - 12 - 17
 * @brief : 게임 컨트롤러 (화폐, 복귀, 장비, 특성, 스킬)
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	/// <summary>
	/// 화폐
	/// </summary>
	int gold = 1;	// 골드
	int credit = 1;	// 학점
	int time = 0;	// 시간

	/// <summary>
	/// 장비
	/// </summary>
	int bag_level = 1;	// 가방 레벨
	int shoes_level = 1;	// 신발 레벨
	int bag1_price = 400;	// 가방 가격들
	int bag2_price = 7000;
	int bag3_price = 32000;
	int bag4_price = 130000;
	int shoes1_price = 100;	// 신발 가격들
	int shoes2_price = 3000;
	int shoes3_price = 15000;
	int shoes4_price = 90000;
	public GameObject PreBag1;
	public GameObject PreBag2;
	public GameObject PreBag3;
	public GameObject PreBag4;
	public GameObject PreBag5;
	public GameObject PostBag1;
	public GameObject PostBag2;
	public GameObject PostBag3;
	public GameObject PostBag4;
	public GameObject PostBag5;
	public GameObject PreShoes1;
	public GameObject PreShoes2;
	public GameObject PreShoes3;
	public GameObject PreShoes4;
	public GameObject PreShoes5;
	public GameObject PostShoes1;
	public GameObject PostShoes2;
	public GameObject PostShoes3;
	public GameObject PostShoes4;
	public GameObject PostShoes5;

	/// <summary>
	/// 특성
	/// </summary>
	int major = 1;	// 전과하기
	int grade = 1;	// 학년증가
	int rname = 1;   // 개명하기
	int name_credit = 1000;	// 개명하기에 필요한 학점 가격
	int major_credit = 10;	// 전과하기에 필요한 학점 가격
	int grade_credit = 100;	// 학년증가에 필요한 학점 가격

	/// <summary>
	/// 스킬
	/// </summary>
	int cooldown_time = 0;	// 스킬 쿨타임

	/// <summary>
	/// UI
	/// </summary>
	public Text goldLabel;		// 골드 UI Text
	public Text creditLabel;	// 학점 UI Text


	/// <summary>
	/// 시작하자마자 골드와 학점 UI를 표시함
	/// </summary>
	private void Start()
	{
		goldLabel.text = "" + gold;
		creditLabel.text = " " + credit;
	}

	/// <summary>
	/// 매 프레임마다 전공과 신발에 비례해서 골드가 오름
	/// </summary>
	private void Update()
	{
		time += shoes_level;
		cooldown_time--;

		if (time >= 100)
		{
			// 전공 레벨과 신발 레벨에 비례해서 오름
			// 신발 레벨 비중이 더 높아야함
			gold += 1 + ((major - 1) * 5) + ((shoes_level - 1) * 30);
			time = 1;
		}
		goldLabel.text = "" + gold;
		creditLabel.text = " " + credit;
	}


	/// <summary>
	/// @title : public void ComeBack ()
	/// @brief : 복귀 버튼 (돈 초기화, 학점 증가)
	/// </summary>
	public void ComeBack()
	{
		print("ComeBack");

		// 골드에 비례해서 학점을 증가시켜줌
		credit += (gold / (100 - (grade + (bag_level * 5))));
		// 골드는 1로 초기화
		gold = 1;

		// 신발과 가방 레벨도 1로 초기화
		bag_level = 1;
		PreBag1.transform.localPosition = new Vector3(0, 0, 0);
		PreBag2.transform.localPosition = new Vector3(-20, 0, 0);
		PreBag3.transform.localPosition = new Vector3(-20, 0, 0);
		PreBag4.transform.localPosition = new Vector3(-20, 0, 0);
		PreBag5.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag1.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag2.transform.localPosition = new Vector3(0, 0, 0);
		PostBag3.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag4.transform.localPosition = new Vector3(-20, 0, 0);
		PostBag5.transform.localPosition = new Vector3(-20, 0, 0);

		shoes_level = 1;
		PreShoes1.transform.localPosition = new Vector3(0, 0, 0);
		PreShoes2.transform.localPosition = new Vector3(-20, 0, 0);
		PreShoes3.transform.localPosition = new Vector3(-20, 0, 0);
		PreShoes4.transform.localPosition = new Vector3(-20, 0, 0);
		PreShoes5.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes1.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes2.transform.localPosition = new Vector3(0, 0, 0);
		PostShoes3.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes4.transform.localPosition = new Vector3(-20, 0, 0);
		PostShoes5.transform.localPosition = new Vector3(-20, 0, 0);
	}

	/// <summary>
	/// 가방 함수 (레벨1 ~ 레벨 5)
	/// 가방 스프라이트의 위치를 바꾸고, 상점 역할을 수행
	/// </summary>
	public void Bag()
	{
		// 가방 레벨이 1일 경우
		if (bag_level == 1)
		{
			// 골드가 가방 가격보다 많은지 확인
			if (gold >= bag1_price)
			{
				// 골드에서 가방 가격만큼 빼고
				gold -= bag1_price;
				// 가방 레벨을 증가시켜줌
				bag_level++;
				PreBag1.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag2.transform.localPosition = new Vector3(0, 0, 0);
				PostBag2.transform.localPosition = new Vector3(-20, 0, 0);
				PostBag3.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (bag_level == 2)
		{
			if (gold >= bag2_price)
			{
				gold -= bag2_price;
				bag_level++;
				PreBag2.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag3.transform.localPosition = new Vector3(0, 0, 0);
				PostBag3.transform.localPosition = new Vector3(-20, 0, 0);
				PostBag4.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (bag_level == 3)
		{
			if (gold >= bag3_price)
			{
				gold -= bag3_price;
				bag_level++;
				PreBag3.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag4.transform.localPosition = new Vector3(0, 0, 0);
				PostBag4.transform.localPosition = new Vector3(-20, 0, 0);
				PostBag5.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (bag_level == 4)
		{
			if (gold >= bag4_price)
			{
				gold -= bag4_price;
				bag_level++;
				PreBag4.transform.localPosition = new Vector3(-20, 0, 0);
				PreBag5.transform.localPosition = new Vector3(0, 0, 0);
				PostBag5.transform.localPosition = new Vector3(-20, 0, 0);
			}
		}
	}

	/// <summary>
	/// 신발 함수 (레벨1 ~ 레벨 5)
	/// 신발 스프라이트의 위치를 바꾸고, 상점 역할을 수행
	/// </summary>
	public void Shoes()
	{
		if (shoes_level == 1)
		{
			if (gold >= shoes1_price)
			{
				gold -= shoes1_price;
				shoes_level++;
				PreShoes1.transform.localPosition = new Vector3(-20, 0, 0);
				PreShoes2.transform.localPosition = new Vector3(0, 0, 0);
				PostShoes2.transform.localPosition = new Vector3(-20, 0, 0);
				PostShoes3.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (shoes_level == 2)
		{
			if (gold >= shoes2_price)
			{
				gold -= shoes2_price;
				shoes_level++;
				PreShoes2.transform.localPosition = new Vector3(-20, 0, 0);
				PreShoes3.transform.localPosition = new Vector3(0, 0, 0);
				PostShoes3.transform.localPosition = new Vector3(-20, 0, 0);
				PostShoes4.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (shoes_level == 3)
		{
			if (gold >= shoes3_price)
			{
				gold -= shoes3_price;
				shoes_level++;
				PreShoes3.transform.localPosition = new Vector3(-20, 0, 0);
				PreShoes4.transform.localPosition = new Vector3(0, 0, 0);
				PostShoes4.transform.localPosition = new Vector3(-20, 0, 0);
				PostShoes5.transform.localPosition = new Vector3(0, 0, 0);
			}
		}

		if (shoes_level == 4)
		{
			if (gold >= shoes4_price)
			{
				gold -= shoes4_price;
				shoes_level++;
				PreShoes4.transform.localPosition = new Vector3(-20, 0, 0);
				PreShoes5.transform.localPosition = new Vector3(0, 0, 0);
				PostShoes5.transform.localPosition = new Vector3(-20, 0, 0);
			}
		}
	}

	/// <summary>
	/// 개명하기 함수
	/// 스킬 쿨타임을 줄여줌
	/// </summary>
	public void ReName()
	{
		print("ReName");
		if (credit >= name_credit)
		{
			credit -= name_credit;
			rname++;
		}
	}

	/// <summary>
	/// 전과하기 함수
	/// 골드 획득량을 증가
	/// </summary>
	public void ReMajor()
	{
		print("ReMajor");
		if (credit >= major_credit)
		{
			credit -= major_credit;
			major++;
		}
	}

	/// <summary>
	/// 학년증가 함수
	/// 학점 획득량을 증가
	/// </summary>
	public void ReGrade()
	{
		print("ReGrade");
		if (credit >= grade_credit)
		{
			credit -= grade_credit;
			grade++;
		}
	}


	/// <summary>
	/// 물 마시기 함수
	/// 다량의 골드를 학과에 비례해서 줌
	/// </summary>
	public void Water()
	{
		if (cooldown_time <= 0)
		{
			gold += 100 + (major * 10);
			cooldown_time = 99 - (rname * 10);
		}
	}

	/// <summary>
	/// 다량의 학점을 학년에 비례해서 줌
	/// </summary>
	public void Breath()
	{
		if (cooldown_time <= 0)
		{
			credit += 10 + (grade * 5);
			cooldown_time = 999 - (rname * 10);
		}
	}


}
