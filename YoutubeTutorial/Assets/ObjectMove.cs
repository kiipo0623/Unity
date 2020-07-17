using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    //transform : 오브젝트 형태에 대한 기본 컴포넌트
    //gamoe object와 transform 1대1 관계이기 때문에
    //선언할 필요 없음
    void Update()
    {
        //스칼라 값에 방향 주어지면 벡터
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0);


        //Translate : 벡터 값을 현재 위치에 더하는 함수
        transform.Translate(vec);
        
    }
}
