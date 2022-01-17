using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellocode : MonoBehaviour
{


    void Start()
    {
        //캐릭터의 프로필을 변수로 만들기
        string characterName = "라라";
        char bloodType = 'A';
        int age = 17;
        float height = 163.8f;
        bool isFemale = true;

        //생성한 변수를 콘솔에 출력
        Debug.Log("캐릭터 이름 : " + characterName);
        Debug.Log("혈액형 :" + bloodType);
        Debug.Log("나이 :" + age);
        Debug.Log("키 :" + height);
        Debug.Log(" 여성인가?:" + isFemale);
    }

} 