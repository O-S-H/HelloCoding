using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellocode : MonoBehaviour
{


    void Start()
    {

        //int[] students = new int[5];

        //students[0] = 100;
        // students[1] = 90;
        // students[2] = 80;
        // students[3] = 70;
        // students[4] = 60;

        // Debug.Log("0번학생의 점수" + students[0]);
        // Debug.Log("1번학생의 점수" + students[1]);
        // Debug.Log("2번학생의 점수" + students[2]);
        //Debug.Log("3번학생의 점수" + students[3]);
        // Debug.Log("4번학생의 점수" + students[4]);


        int[] students = new int [5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for (int i = 4; i >= 0; i--)
        {

            Debug.Log((i + 1) +"번 학생의 점수 "+ students[i] );
            
        }


    }

} 