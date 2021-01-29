﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    float aiTurnTimer, passedTime;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SoloModeCardControl.instance.GetIsMyTurn());

        if (SoloModeCardControl.instance.GetIsMyTurn() == false)
        {
            passedTime += Time.deltaTime;
            aiTurnTimer = Random.Range(2, 4);

            if (passedTime >= aiTurnTimer)
            {
                AIClickCheck();
                passedTime = 0f;
            }
            
            //카드 움직임
            SoloModeCardControl.instance.CardMove();
            SoloModeCardControl.instance.CardBoardMatch();
        }
    }

    void AIClickCheck()
    {
        //hit.transform.GetComponent<EnemyAI>().OpenCard();

        //AI단계별 구현
        ///WIP
        /*
        int randomCardPhase1, randomCardPhase2, randomCardPhase3, randomCardPhase4;
        int hitCheckPhase2 = 0, hitCheckPhase3 = 0, hitCheckPhase4 = 0;

        if (GetComponent<SoloModeManager>().turnCount <= 3)
        {
            randomCardPhase1 = Random.Range(1, 24);

            GameObject.FindWithTag("card" + randomCardPhase1);
        }
        else if(GetComponent<SoloModeManager>().turnCount <= 8 && GetComponent<SoloModeManager>().turnCount > 3)
        {
            randomCardPhase2 = Random.Range(7, 24);
            for(int i = 7; i <= 24; i++)
            {
                if (GameObject.FindWithTag("card" + i).GetComponent<SoloModeCardControl>().ishitted == true)
                {
                    hitCheckPhase2++;
                }
                else return;
            }
            GameObject.FindWithTag("card" + randomCardPhase2);
        }
        else if(GetComponent<SoloModeManager>().turnCount <= 12)
        {
            randomCardPhase3 = Random.Range(12, 24);
        }
        */

        int randomCard = Random.Range(1, 24);
        if (GameObject.FindWithTag("card" + randomCard).GetComponent<SoloModeCardControl>().ishitted == true)
        {
            //do
            //{
            //    randomCard = Random.Range(1, 24);
            //}
            while (GameObject.FindWithTag("card" + randomCard).GetComponent<SoloModeCardControl>().ishitted == true)//<- false를 true로 바꿈
            {
                randomCard = Random.Range(1, 24);
            }

            //넣어야 위에서 찾은 후에 바로 될꺼 같아서 넣어봄 - 규식
            if (GameObject.FindWithTag("card" + randomCard).GetComponent<SoloModeCardControl>().ishitted == false)
            {
                GameObject.FindWithTag("card" + randomCard).GetComponent<SoloModeCardControl>().OpenCard();
                SoloModeCardControl.instance.SetIsMyTurn(true);
            }
        }
        else
        {
            GameObject.FindWithTag("card" + randomCard).GetComponent<SoloModeCardControl>().OpenCard();

            //플레이어의 턴으로 변경
            SoloModeCardControl.instance.SetIsMyTurn(true);
            //SoloModeManager.instance.turnCount++;
        }
    }
}