using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePanelClose : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ideaPanel01, ideaPanel02;
        ideaPanel01 = GameObject.Find("sampleIdea01");
        ideaPanel02 = GameObject.Find("sampleIdea02");

        float distance = 0.2f;
        float speed = 0.1f;

        moveClose(ideaPanel01, ideaPanel02, distance, speed);
    }

    void moveClose(GameObject movePanel, GameObject stablePanel, float nearestDistance, float moveSpeed)
    {

        Vector3 fromPosition = movePanel.transform.position;
        Vector3 toPosition = stablePanel.transform.position;

        // ゆっくり動かしたかったが、よくわからん
        //		movePanel.transform.position = movePanel.transform.position + Vector3.Lerp(fromPosition, toPosition, 3.0f);

        // 指定の距離までパネルを移動する
        if (Vector3.Magnitude(fromPosition - toPosition) > nearestDistance)
        {
            movePanel.transform.position = movePanel.transform.position + (toPosition - fromPosition) * moveSpeed;
        }

    }
}
