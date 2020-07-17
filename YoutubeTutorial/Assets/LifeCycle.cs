using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 C# 프로그래밍

배열 선언
string[] monsters = {"a","b","c"};
int[] monsterLevel = new int[3];
monsterLevel[1]=3;

리스트 선언
List<string> items = new List<string>();
items.Add("a");
items.Add("b");
items.RemoveAt(0);

콘솔창에 출력
Debug.log(title+" "+playerName);

클래스 : 상속 (인스턴스)

유니티 게임 함수들
<초기화 영역>
Awake : 게임 오브젝트 생성할 때, 최초 실행
Start : 업데이트 시작 직전, 최초 실행

<물리연산 영역>
FixedUpdate : 물리 연산 업데이트
update 함수 : 1초에 여러번 작동

<게임로직 영역>
물리연산 제외 나머지 주기적으로 변화는 로직
환경에 따라 실행 주기 떨어질 수 있음
Update : 게임 로직 업데이트 함수
LateUpdate : 모든 업데이트 끝난 후 / 캐릭터 따라가는 카메라

<해체 영역>
OnDestroy : 게임 오브젝트가 삭제될 때
awake 반대

<활성화>
초기화와 물리영역 사이에 위치
게임 오브젝트 켜고 끄는 것
OnEnable : 최초 1회 실행 아니고 두고두고 사용된다
OnDisable : 모든 업데이트 끝난 후

Awake > OnEnable > Start > FixedUpdate > Update > LateUpdate > OnDisable > OnDestroy

     */

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        //Input : 게임 내 입력을 관리하는 클래스(마우스/키보드)
        if (Input.anyKeyDown)   //Input.anyKeyDown : 아무 입력을 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.anyKey)   //Input.anyKey : 아무 입력을 받을 때 누르고 있으면 계속
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        //key의 세 가지 상태
        //down stay up
    
        if (Input.GetKeyDown(KeyCode.Return))   //keycode : 어떤 키보드 누를지 선택 , 엔터키
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))    //왼쪽 화살표
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        //KeyCode.Escape : esc

        //GetMouse : 마우스 버튼 입력 받으면 true
        if (Input.GetMouseButtonDown(0))    //매개 변수를 숫자로 받음 0(왼쪽) 1(오른쪽)
            Debug.Log("미사일 발사!");
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!");

        //Edit > Project Settings > Input Manager에서도 설정 가능

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점스!");

        //Input Manager 수정 추가 가능
        //GetAxis : 수평, 수직 버튼 입력을 받으면 float(가중치)

        if (Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..."+ Input.GetAxis("Horizontal"));
            //GetAxisRaw : 가중치 없이 1만
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        }


    }
}
