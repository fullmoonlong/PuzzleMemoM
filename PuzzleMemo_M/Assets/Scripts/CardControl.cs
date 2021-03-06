﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour
{
    //이미지 번호
    int imgNum = 1;

    //오픈된 카드 판별 여부
    public bool isOpen = false;
    public bool ishitted = false;

    //물체 이동을 위해서
    public Vector3 cardPos;
    public Vector3 targetPosition;

    private float cardInterval = 1.2f;

    //튜토리얼 순서
    private int tutoIndex;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //애니메이션
        anim = GetComponent<Animator>();

        //보드 번호 - 태그 활용
        if (tag.Substring(0, 5) == "board")//보드
        {
            //보드 번호 가져오기
            int boardNum = int.Parse(transform.tag.Substring(5));

            //이미지 적용
            transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("puzzle2_" + boardNum.ToString()) as Texture2D;
        }
        //카드 번호 - 태그 활용
        if (tag.Substring(0, 4) == "card")//카드
        {
            //카드 번호 가져오기
            imgNum = int.Parse(transform.tag.Substring(4));
        }
    }

    // Update is called once per frame
    void Update()
    {
        //현재 튜토리얼 순서 갱신
        tutoIndex = GameObject.Find("TutorialManager").GetComponent<TutorialManager>().GetPopUpIndex();

        //윈도우(왼버튼), 모바일(터치)
        if (Input.GetButtonDown("Fire1"))
        {
            ClickCheck();
        }

        //맞춘 카드인지 체크

        //카드 움직임
        CardMove();

        //일정시간후 체크
        CardCheck();
        
    }

    void CardCheck()
    {
        if (this.isOpen == false || this.ishitted == true)
        {
            this.cardInterval = 1.2f;
            return;
        }
        else if (this.isOpen == true)
        {
            this.cardInterval -= Time.deltaTime;
        }

        if (this.cardInterval <= 0f)
        {
            if (tutoIndex == 0)
            {

            }

            else if (tutoIndex == 1)
            {

            }

            else if (tutoIndex == 2)
            {

            }

            else if (tutoIndex == 3)
            {

            }

            else if (tutoIndex == 4)
            {

            }

            else if (tutoIndex == 5)
            {

            }

            else if (tutoIndex == 6)
            {

            }

            else if (tutoIndex == 7)
            {

            }

            else if (tutoIndex == 8)
            {

            }

            else if (tutoIndex == 9)
            {
                if (imgNum == 6)
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 10)
            {

            }

            else if (tutoIndex == 11)
            {

            }

            else if (tutoIndex == 12)
            {

            }

            else if (tutoIndex == 13)
            {
                print("13");
                if (imgNum == 18)
                {
                    print("18");
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 14)
            {

            }

            else if (tutoIndex == 15)
            {

            }

            else if (tutoIndex == 16)
            {
                // 아무카드도 안뒤집히게 하기

                if (imgNum == 0)//실패용 없는카드
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 17)
            {
                // 아무카드도 안뒤집히게 하기

                if (imgNum == 0)//실패용 없는카드
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 18)
            {
                // 아무카드도 안뒤집히게 하기

                if (imgNum == 0)//실패용 없는카드
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 19)
            {
                // 아무카드도 안뒤집히게 하기

                if (imgNum == 0)//실패용 없는카드
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 20)
            {
                if (imgNum == 22)
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 21)
            {
                // 아무카드도 안뒤집히게 하기

                if (imgNum == 0)//실패용 없는카드
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 22)
            {
                // 아무카드도 안뒤집히게 하기

                if (imgNum == 0)//실패용 없는카드
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 23)
            {
                // 아무카드도 안뒤집히게 하기

                if (imgNum == 0)//실패용 없는카드
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }

            else if (tutoIndex == 25)
            {
                if (imgNum == 21 || imgNum == 22)
                {
                    this.ishitted = true;

                    return;
                }
                else if (GameObject.FindWithTag("card21").GetComponent<CardControl>().ishitted == true && this.tag == "card15")
                {
                    this.ishitted = true;

                    return;
                }
                else if (GameObject.FindWithTag("card22").GetComponent<CardControl>().ishitted == true && this.tag == "card16")
                {
                    this.ishitted = true;

                    return;
                }
                else//정해진 카드가 아니라면 뒤집기
                {
                    CloseCard();

                    return;
                }
            }


            /*else//마지막, 이전에 쓰던 기본규칙
            {
                if ((imgNum + 6) <= 12 && GameObject.FindWithTag("card" + (imgNum + 6)).transform.GetComponent<CardControl>().ishitted == false)
                    CloseCard();
            
                    return;
                }
                else
                {
                    this.ishitted = true;
            
                    return;
                }
            }*/
        }
    }

    void ClickCheck()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            string tag = hit.transform.tag;

            if (tag.Substring(0, 4) == "card")
            {
                //카드에 있는 OpenCard()함수 실행하기
                hit.transform.GetComponent<CardControl>().OpenCard();
            }
        }
    }

    public void OpenCard()
    {
        //이미 열려있으면 무시
        if (isOpen) return;

        isOpen = true;
        transform.position = new Vector3(transform.position.x, transform.position.y, -1.1f);
        anim.Play("aniOpen");
    }

    public void CloseCard()
    {
        if (!isOpen) return;

        isOpen = false;
        ishitted = false;
        transform.position = new Vector3(transform.position.x, transform.position.y, -1f);
        anim.Play("aniClose");
    }

    void ShowImage()
    {
        //transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("puzzle_" + imgNum.ToString()) as Texture2D;
        transform.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("puzzle_" + imgNum.ToString());
    }

    void HideImage()
    {
        //transform.GetComponent<Renderer>().material.mainTexture = Resources.Load("card_back") as Texture2D;
        transform.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("card_back");
    }

    void CardMove()
    {
        if (this.ishitted == true && this.tag.Substring(0, 4) == "card")
        {
            int hittedcardNum = int.Parse(transform.tag.Substring(4));
            BoardMatch(hittedcardNum);
        }
    }

    void BoardMatch(int _hittedCardNum)
    {
        GameObject.FindWithTag("card" + _hittedCardNum).transform.position = GameObject.FindWithTag("board" + _hittedCardNum).transform.position;
    }
}