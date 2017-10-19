using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateStatus : MonoBehaviour
{
    //　カウンタ
    float cnt = 0.0f;

    // 公転半径の設定
    float tmpRadius = 2.0f;
    // 公転の中心の設定
    Vector3 tmpCentorPos = new Vector3(0.0f, 0.0f, 1.0f);


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rotateStatMsg(tmpRadius, tmpCentorPos);

        if (cnt % 120 == 0) {
            rotateChngMsg((int)((cnt % 30) % 4)+1);
        }


    }

    void rotateStatMsg(float radius, Vector3 centerPosition)
    {
        cnt += 1.0f;
        // 速度（値が大きいほど高速）
        float speed = 0.5f;
        this.transform.Rotate(new Vector3(0.0f, speed * 360.0f / 60.0f , 0.0f));
        this.transform.position = radius * new Vector3(-1.0f * Mathf.Sin(speed * 2.0f * Mathf.PI * cnt / 60.0f), 0, -1.0f * Mathf.Cos(speed * 2.0f * Mathf.PI * cnt / 60.0f)) + centerPosition;
    }

    void rotateChngMsg(int statNum)
    {
        // 引数を元に、メッセージを変更する

        if (statNum == 1)
        {
            this.GetComponent<TextMesh>().text = "JOIN";
        }
        else if (statNum == 2)
        {
            this.GetComponent<TextMesh>().text = "Thinking Time";
        }
        else if (statNum == 3)
        {
            this.GetComponent<TextMesh>().text = "Discussion";
        }
        else if (statNum == 4)
        {
            this.GetComponent<TextMesh>().text = "Closing";
        }
        else {
            this.GetComponent<TextMesh>().text = "Waiting for Facilitators";
        }
        
    }

}
