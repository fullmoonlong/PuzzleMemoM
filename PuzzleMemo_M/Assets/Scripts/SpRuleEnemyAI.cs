﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpRuleEnemyAI : MonoBehaviour
{
    float aiTurnTimer, passedTime;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SpRuleCardControl.instance.GetIsMyTurn());

        if (SpRuleCardControl.instance.GetIsMyTurn() == false)
        {
            passedTime += Time.deltaTime;
            aiTurnTimer = Random.Range(2, 4);

            if (passedTime >= aiTurnTimer)
            {
                AIClickCheck();
                passedTime = 0f;
            }

            //카드 움직임
            SpRuleCardControl.instance.CardMove();
            SpRuleCardControl.instance.CardBoardMatch();
        }
    }

    void AIClickCheck()
    {
        if(SpRuleManager.matchOver >= 24)
        {
            return;
        }
        //AI단계별 구현
        int randomCard = Random.Range(1, 24);

        if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
        {
            while (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)//<- false를 true로 바꿈
            {
                if (SpRuleManager.turnCount <= 5)
                {
                    Debug.Log("Phase1");
                    randomCard = Random.Range(1, 24);
                }
                else if (SpRuleManager.turnCount <= 10 && SpRuleManager.turnCount > 5)
                {
                    Debug.Log("Phase2");
                    randomCard = Random.Range(7, 24);
                    if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                    {
                        while (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                        {
                            randomCard = Random.Range(1, 24);
                        }
                    }
                }
                else if (SpRuleManager.turnCount <= 20 && SpRuleManager.turnCount > 10)
                {
                    Debug.Log("Phase3");
                    randomCard = Random.Range(13, 24);
                    if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                    {
                        while (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                        {
                            randomCard = Random.Range(7, 24);
                            if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                            {
                                randomCard = Random.Range(1, 24);
                            }
                        }
                    }
                }
                else
                {
                    Debug.Log("Phase4");
                    randomCard = Random.Range(19, 24);
                    if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                    {
                        while (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                        {
                            randomCard = Random.Range(13, 24);
                            if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                            {
                                randomCard = Random.Range(1, 24);
                            }
                        }
                    }
                }
            }

            //넣어야 위에서 찾은 후에 바로 될꺼 같아서 넣어봄 - 규식
            if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == false)
            {
                Debug.Log(randomCard);
                GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().OpenCard();
                SpRuleManager.turnCount++;
                SpRuleCardControl.instance.SetIsMyTurn(true);
            }
        }
        else
        {
            if (SpRuleManager.turnCount <= 5)
            {
                Debug.Log("Phase1");
                randomCard = Random.Range(1, 24);
            }
            else if (SpRuleManager.turnCount <= 10 && SpRuleManager.turnCount > 5)
            {
                Debug.Log("Phase2");
                randomCard = Random.Range(7, 24);
                if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                {
                    while (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                    {
                        randomCard = Random.Range(1, 24);
                    }
                }
            }
            else if (SpRuleManager.turnCount <= 20 && SpRuleManager.turnCount > 10)
            {
                Debug.Log("Phase3");
                randomCard = Random.Range(13, 24);
                if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                {
                    while (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                    {
                        randomCard = Random.Range(7, 24);
                        if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                        {
                            randomCard = Random.Range(1, 24);
                        }
                    }
                }
            }
            else
            {
                Debug.Log("Phase4");
                randomCard = Random.Range(19, 24);
                if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                {
                    while (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                    {
                        randomCard = Random.Range(13, 24);
                        if (GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().ishitted == true)
                        {
                            randomCard = Random.Range(1, 24);
                        }
                    }
                }
            }
            GameObject.FindWithTag("card" + randomCard).GetComponent<SpRuleCardControl>().OpenCard();
            Debug.Log(randomCard);
            //플레이어의 턴으로 변경
            SpRuleManager.turnCount++;
            SpRuleCardControl.instance.SetIsMyTurn(true);
        }
    }
}